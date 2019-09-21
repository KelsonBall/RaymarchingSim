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

MarchStep HandleColorOp(Node node, MarchStep mstate)
{
    if (mstate.State == 0)
    {
        mstate.State = 1;
        mstate.Color = Vector3Entities[node.Parameter];
        mstate.LeftPosition = mstate.Position;
        mstate.Next = node.Left;
    }
    else if (mstate.State == 1)
    {
        mstate.Value = mstate.LeftValue;
        mstate.State = DONE;
        mstate.Next = node.Parent;
    }

	return mstate;
}

MarchStep HandleTranslationOp(Node node, MarchStep mstate)
{
	uint state = mstate.State;

    if (state == 0)
    {
        mstate.State = 1;
		vec3 vec = Vector3Entities[node.Parameter];
		vec3 pos = mstate.Position;
        mstate.LeftPosition = pos + vec;
        mstate.Next = node.Left;
    }
    else if (state == 1)
    {
        mstate.State = DONE;
        mstate.Value = mstate.LeftValue;
        mstate.Color = mstate.LeftColor;
        mstate.Next = node.Parent;
    }

	return mstate;
}

MarchStep HandleSphereOp(Node node, MarchStep mstate)
{    
    mstate.Value = length(mstate.Position) - DoubleEntities[node.Parameter];
    mstate.Next = node.Parent;

	return mstate;
}


MarchStep SetPosition(vec3 pos, MarchStep mstate)
{
	mstate.Position = pos;
	return mstate;
}

MarchResult Sdf_March(vec3 initial)
{
    MarchStep mstates[13];    
	
    uint index = 0;	

	mstates[index] = SetPosition(initial, mstates[index]);

	bool running = true;

    while (running)
    {
        Node node = NodeEntities[index];

        if (node.Left > 0)
        {
            mstates[index].LeftValue = mstates[node.Left].Value;
            mstates[index].LeftColor = mstates[node.Left].Color;
        }

        if (node.Right > 0)
        {
            mstates[index].RightValue = mstates[node.Right].Value;
            mstates[index].RightColor = mstates[node.Right].Color;
        }

        mstates[index].Index = index;
				
        switch (NodeEntities[index].Operation)
        {
            case OpType3d_Color:
                mstates[index] = HandleColorOp(node, mstates[index]);
                break;
            case OpType3d_SpatialTranslation:
                mstates[index] = HandleTranslationOp(node, mstates[index]);
                break;
            case OpType3d_ShapeSphere:
                mstates[index] = HandleSphereOp(node, mstates[index]);
                break;
			default:
				return MarchResult(0, vec3(1, 0, 0));
        }		

        if (node.Left > 0)
            mstates[node.Left].Position = mstates[index].LeftPosition;

        if (node.Right > 0)
            mstates[node.Right].Position = mstates[index].RightPosition;

        index = mstates[index].Next;

        if (index == 0 && mstates[index].State == DONE)
            running = false;
    }
	
    return MarchResult(mstates[0].Value, mstates[0].Color);
}


vec3 getUvRay(vec2 uv, vec2 size)
{
    vec2 xy = uv - (size / 2);
    double z = size.y / HalfTanFoV;
    return normalize(vec3(xy, -z));
}

out vec4 outColor;

void main()
{
	vec2 xy = gl_FragCoord.xy - Origin;

	vec3 ray = getUvRay(xy, Size);

    vec3 position = vec3(0, 0, 3);	

	MarchResult last_result = Sdf_March(position);

    double traveled = 0;

    for (int marches = 0; marches < MarchLimit && traveled < DrawDistance; marches++)
    {
        if (last_result.Value < MinStepLength)
        {
			outColor = vec4(last_result.Color, 1.0);
			return;
        }

        float d = float(last_result.Value);
        position = position + (ray * d);
        traveled += d;

        last_result = Sdf_March(position);
    }

    outColor = vec4((ray / 2) + vec3(0.5, 0.5, 0.5), 1.0);		
}