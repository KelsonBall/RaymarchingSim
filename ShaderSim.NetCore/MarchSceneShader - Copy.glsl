#version 430

const uint MAX_ENTITY_COUNT = 30;

uniform vec4 BackgroundColor;
uniform vec2 Origin;
uniform vec2 Size;
uniform vec2 Resolution;
uniform double DrawDistance;
uniform double MinStepLength;
uniform double NormalEpsilon;
uniform double FieldOfView;
uniform double HalfTanFoV;
uniform int MarchLimit;

struct Node
{
	uint EntityId;
	uint Operation;
	uint Left;
	uint Right;
	uint Parent;
	uint Parameter;
};

uniform Node NodeEntities[MAX_ENTITY_COUNT];
uniform mat4 MatrixEntities[MAX_ENTITY_COUNT];
uniform vec3 Vector3Entities[MAX_ENTITY_COUNT];
uniform double DoubleEntities[MAX_ENTITY_COUNT];

const uint DONE = 256;

const uint OpType3d_CsgUnion = 1;
const uint OpType3d_CsgIntersect = 2;
const uint OpType3d_CsgSubtract = 3;
const uint OpType3d_ShapeSphere = 11;
const uint OpType3d_ShapeBox = 12;
const uint OpType3d_SpatialTranslation = 21;
const uint OpType3d_SpatialTransform = 22;
const uint OpType3d_Color = 31;

struct MarchResult
{
	double Value;
	vec3 Color;
};

struct MarchStep
{
	uint Index;
	uint Next;
	uint State;
	double Value;
	double LeftValue;
	double RightValue;
	vec3 Color;
	vec3 LeftColor;
	vec3 RightColor;
	vec3 Position;
	vec3 LeftPosition;
	vec3 RightPosition;
};

MarchStep HandleColorOp(MarchStep step)
{
    Node node = NodeEntities[step.Index];

    if (step.State == 0)
    {
        step.State = 1;
        step.Color = Vector3Entities[node.Parameter];
        step.LeftPosition = step.Position;
        step.Next = node.Left;
    }
    else if (step.State == 1)
    {
        step.Value = step.LeftValue;
        step.State = DONE;
        step.Next = node.Parent;
    }

	return step;
}

MarchStep HandleUnionOp(MarchStep step)
{
    Node node = NodeEntities[step.Index];

    if (step.State == 0)
    {
        step.State = 1;
        step.LeftPosition = step.Position;
        step.Next = node.Left;
    }
    else if (step.State == 1)
    {
        step.State = 2;
        step.RightPosition = step.Position;
        step.Next = node.Right;
    }
    else if (step.State == 2)
    {
        if (step.LeftValue < step.RightValue)
        {
            step.Value = step.LeftValue;
            step.Color = step.LeftColor;
        }
        else
        {
            step.Value = step.RightValue;
            step.Color = step.RightColor;
        }
        step.State = DONE;
        step.Next = node.Parent;
    }

	return step;
}

MarchStep HandleIntersectionOp(MarchStep step)
{
    Node node = NodeEntities[step.Index];

    if (step.State == 0)
    {
        step.State = 1;
        step.LeftPosition = step.Position;
        step.Next = node.Left;
    }
    else if (step.State == 1)
    {
        step.State = 2;
        step.RightPosition = step.Position;
        step.Next = node.Right;
    }
    else if (step.State == 2)
    {
        if (step.LeftValue > step.RightValue)
        {
            step.Value = step.LeftValue;
            step.Color = step.LeftColor;
        }
        else
        {
            step.Value = step.RightValue;
            step.Color = step.RightColor;
        }
        step.State = DONE;
        step.Next = node.Parent;
    }

	return step;
}

MarchStep HandleSubtractionOp(MarchStep step)
{
    Node node = NodeEntities[step.Index];

    if (step.State == 0)
    {
        step.State = 1;
        step.LeftPosition = step.Position;
        step.Next = node.Left;
    }
    else if (step.State == 1)
    {
        step.State = 2;
        step.RightPosition = step.Position;
        step.Next = node.Right;
    }
    else if (step.State == 2)
    {
        if (step.LeftValue > -step.RightValue)
        {
            step.Value = step.LeftValue;
            step.Color = step.LeftColor;
        }
        else
        {
            step.Value = -step.RightValue;
            step.Color = step.RightColor;
        }
        step.State = DONE;
        step.Next = node.Parent;
    }

	return step;
}

MarchStep HandleTransformOp(MarchStep step)
{
    Node node = NodeEntities[step.Index];

    if (step.State == 0)
    {
        step.State = 1;
        step.LeftPosition = (vec4(step.Position, 0) * MatrixEntities[node.Parameter]).xyz;
        step.Next = node.Left;
    }
    else if (step.State == 1)
    {
        step.State = DONE;
        step.Value = step.LeftValue;
        step.Color = step.LeftColor;
        step.Next = node.Parent;
    }

	return step;
}

MarchStep HandleTranslationOp(MarchStep step)
{
    Node node = NodeEntities[step.Index];

    if (step.State == 0)
    {
        step.State = 1;
        step.LeftPosition = step.Position + Vector3Entities[node.Parameter];
        step.Next = node.Left;
    }
    else if (step.State == 1)
    {
        step.State = DONE;
        step.Value = step.LeftValue;
        step.Color = step.LeftColor;
        step.Next = node.Parent;
    }

	return step;
}

MarchStep HandleSphereOp(MarchStep step)
{
    Node node = NodeEntities[step.Index];

    step.Value = length(step.Position) - DoubleEntities[node.Parameter];
    step.Next = node.Parent;

	return step;
}

//MarchStep HandleBoxOp(MarchStep step)
//{
//    Node node = NodeEntities[step.Index];
//
//    double size = DoubleEntities[node.Parameter];
//    vec3 d = vec3(abs(step.Position.x), abs(step.Position.y), abs(step.Position.z) ) - vec3(size, size, size);
//    double inside = min(max(d.x, max(d.y, d.z)), 0);
//    double outside = length(vec3(max(d.x, 0), max(d.y, 0), max(d.z, 0)));
//	step.Value = inside + outside;
//    step.Next = node.Parent;
//
//	return step;
//}

MarchResult Sdf_March(vec3 initial)
{
    MarchStep steps[13];
    steps[0].Position = initial;
	
    uint index = 0;	
	bool running = true;

    while (running)
    {
        Node node = NodeEntities[index];

        if (node.Left > 0)
        {
            steps[index].LeftValue = steps[node.Left].Value;
            steps[index].LeftColor = steps[node.Left].Color;
        }

        if (node.Right > 0)
        {
            steps[index].RightValue = steps[node.Right].Value;
            steps[index].RightColor = steps[node.Right].Color;
        }

        steps[index].Index = index;
		
		MarchStep stepResult;
		
        switch (NodeEntities[index].Operation)
        {
            case OpType3d_Color:
                stepResult = HandleColorOp(steps[index]);
                break;
            case OpType3d_CsgUnion:
                stepResult = HandleUnionOp(steps[index]);
                break;
            case OpType3d_CsgIntersect:
                stepResult = HandleIntersectionOp(steps[index]);
                break;
            case OpType3d_CsgSubtract:
                stepResult = HandleSubtractionOp(steps[index]);
                break;
            case OpType3d_SpatialTransform:
                stepResult = HandleTransformOp(steps[index]);
                break;
            case OpType3d_SpatialTranslation:
                stepResult = HandleTranslationOp(steps[index]);
                break;
            case OpType3d_ShapeSphere:
                stepResult = HandleSphereOp(steps[index]);
                break;
            case OpType3d_ShapeBox:
                stepResult = HandleBoxOp(steps[index]);
                break;
        }

		steps[index] = stepResult;

        if (node.Left > 0)
            steps[node.Left].Position = steps[index].LeftPosition;

        if (node.Right > 0)
            steps[node.Right].Position = steps[index].RightPosition;

        index = steps[index].Next;

        if (index == 0 && steps[index].State == DONE)
            running = false;
    }
	
    return MarchResult(steps[0].Value, steps[0].Color);
}


vec3 getUvRay(vec2 uv, vec2 size)
{
    vec2 xy = uv - (size / 2);
    double z = size.y / HalfTanFoV;
    return normalize(vec3(xy, -z));
}

vec3 estimateNormal(vec3 p)
{
	return normalize(
		vec3(
			Sdf_March(vec3(p.x + NormalEpsilon, p.y, p.z)).Value - Sdf_March(vec3(p.x - NormalEpsilon, p.y, p.z)).Value,
			Sdf_March(vec3(p.x, p.y + NormalEpsilon, p.z)).Value - Sdf_March(vec3(p.x, p.y - NormalEpsilon, p.z)).Value,
			Sdf_March(vec3(p.x, p.y, p.z + NormalEpsilon)).Value - Sdf_March(vec3(p.x, p.y, p.z - NormalEpsilon)).Value
		)
	);
}

out vec4 outColor;

void main()
{
	vec2 xy = gl_FragCoord.xy - Origin;

	vec3 ray = getUvRay(xy, Size);

    vec3 position = vec3(0, 0, 0);
    MarchResult last_result = Sdf_March(position + (ray * 5));

	double v = last_result.Value - 13;

	double saturation = min(1, max(0, v * v));

	outColor = vec4(saturation, saturation, saturation, 1.0);
	return;

    double traveled = 0;

    for (int marches = 0; marches < MarchLimit; marches++)
    {
        if (last_result.Value < MinStepLength)
        {
//            vec3 normal = estimateNormal(position);
//            double value = length(normal - vec3(0, 1, 0)) - 0.8;
//
//            outColor = vec4(last_result.Color * min(max(value, 0.0), 1.0), 1.0);
			outColor = vec4(last_result.Color, 1.0);
//			outColor = vec4(0.1, 0.3, 0.7, 1.0);
			return;
        }

        if (traveled > DrawDistance)
            break;

        float distance = float(last_result.Value);
        position = position + (ray * distance);
        traveled += distance;

        last_result = Sdf_March(position);
    }

    outColor = BackgroundColor;
}