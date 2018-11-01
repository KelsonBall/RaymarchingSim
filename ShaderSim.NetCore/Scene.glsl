#version 410

uniform vec4 BackgroundColor;
uniform double DrawDistance;
uniform double MinStepLength;
uniform double NormalEpsilon;
uniform double FieldOfView;
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

uniform struct Node NodeEntities[64];
uniform mat4 Matrixentities[64];
uniform vec3 Vector3Entities[64];
uniform double DoubleEntities[64];

struct MarchResult
{
	double Value;
	vec3 Color;
};

struct MarchStep
{
	uint Index;
	double Value;
	vec3 Color;
	vec3 Position;
	vec3 NextPosition;
	uint State;
	uint Next;
};

MarchResult HandleColorOp(MarchResult last_result, out MarchStep step)
{
	Node node = NodeEntities[step.Index];

	if (step.State == 0)
	{
		step.State = 1;
		step.Color = Vector3Entities[step.Index];
		step.NextPosition = step.Position;
		step.Next = node.Left;
	}
	else if (step.State == 1)
	{
		step.Value = last_result.Value;
		step.
	}
}

MarchResult Sdf_March(vec3 position)
{
	MarchStep steps[64];
	
	while (true)
	{
		
	}

	MarchResult result;
	result.Value = 1;
	result.Color = vec3(1, 0.5, 0.2);

	return result;
}
