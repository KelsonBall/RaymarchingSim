using System;
using System.Diagnostics;
using Kelson.Common.Vectors;
using RaymarchingScenes;

namespace ShaderSim
{
    public class RayMarchingShader : IShader
    {
        protected readonly ref struct MarchResult
        {
            public readonly double Value;
            public readonly vec3 Color;

            public MarchResult(double value, vec3 color)
                => (Value, Color) = (value, color);
        }

        protected readonly RaymarchScene scene;

        public vec3 BackgroundColor { get; set; }

        public RayMarchingShader(RaymarchScene scene, vec3 backgroundColor = default)
        {
            this.scene = scene;
            BackgroundColor = backgroundColor;
        }

        protected virtual MarchResult Sdf_March(vec3 position, int node)
        {
            var entity = scene.NodeEntities[node];
            MarchResult left_result;
            MarchResult right_result;
            switch (entity.Operation)
            {
                case OpType3d.Color:
                    left_result = Sdf_March(position, entity.Left);
                    if (left_result.Color == new vec3(0, 0, 0))
                        return new MarchResult(Sdf_March(position, entity.Left).Value, scene.Vector3Entities[entity.ParameterId]);
                    else
                        return left_result;
                case OpType3d.CsgUnion:
                    left_result = Sdf_March(position, entity.Left);
                    right_result = Sdf_March(position, entity.Right);
                    if (left_result.Value < right_result.Value)
                        return left_result;
                    else
                        return right_result;
                case OpType3d.CsgIntersect:
                    left_result = Sdf_March(position, entity.Left);
                    right_result = Sdf_March(position, entity.Right);
                    if (left_result.Value > right_result.Value)
                        return left_result;
                    else
                        return right_result;
                case OpType3d.CsgSubtract:
                    left_result = Sdf_March(position, entity.Left);
                    right_result = Sdf_March(position, entity.Right);
                    right_result = new MarchResult(-right_result.Value, right_result.Color);
                    if (left_result.Value > right_result.Value)
                        return left_result;
                    else
                        return right_result;
                case OpType3d.SpatialTransform:
                    return Sdf_March(scene.MatrixEntities[entity.ParameterId].AppliedTo(in position), entity.Left);                    
                case OpType3d.SpatialTranslation:
                    return Sdf_March(position + scene.Vector3Entities[entity.ParameterId], entity.Left);                
                case OpType3d.ShapeSphere:
                    return new MarchResult(position.Magnitude() - scene.DoubleEntities[entity.ParameterId], (0, 0, 0));
                case OpType3d.ShapeBox:                    
                    var size = scene.DoubleEntities[entity.ParameterId];
                    var d = new vec3(Math.Abs(position.X), Math.Abs(position.Y), Math.Abs(position.Z)) - (size, size, size);
                    var inside = Math.Min(Math.Max(d.X, Math.Max(d.Y, d.Z)), 0);
                    var outside = new vec3(Math.Max(d.X, 0), Math.Max(d.Y, 0), Math.Max(d.Z, 0)).Magnitude();
                    return new MarchResult(inside + outside, (0, 0, 0));                    
                default:
                    throw new InvalidOperationException();
            }
        }

        protected const double FieldOfView = Math.PI / 3.5;
        protected const int MarchLimit = 250;        
        protected const double DrawDistance = 30;
        protected const double MinStepLength = 0.025;
        protected const double NormalEpsilon = 0.01;

        protected vec3 getUvRay(double fov, vec2 uv, vec2 size)
        {
            vec2 xy = uv - (size / 2);
            var z = size.y / (Math.Tan(fov) / 2);
            return new vec3(xy, -z).Unit();
        }

        protected vec3 estimateNormal(vec3 p)
        {            
            return new vec3(
                Sdf_March(new vec3(p.X + NormalEpsilon, p.Y, p.Z), 0).Value - Sdf_March(new vec3(p.X - NormalEpsilon, p.Y, p.Z), 0).Value,
                Sdf_March(new vec3(p.X, p.Y + NormalEpsilon, p.Z), 0).Value - Sdf_March(new vec3(p.X, p.Y - NormalEpsilon, p.Z), 0).Value,
                Sdf_March(new vec3(p.X, p.Y, p.Z + NormalEpsilon), 0).Value - Sdf_March(new vec3(p.X, p.Y, p.Z - NormalEpsilon), 0).Value
            ).Unit();            
        }

        public virtual vec4 Run(vec2 xy, vec2 wh)
        {            
            var ray = getUvRay(FieldOfView, xy, wh);

            if (xy.X == 89 && xy.Y == 77)
                Debugger.Break();

            vec3 position = (0, 0, 0);
            var last_result = Sdf_March(position, 0);
            double traveled = 0;

            for (int marches = 0; marches < MarchLimit; marches++)
            {
                if (last_result.Value < MinStepLength)
                {
                    var normal = estimateNormal(position);
                    var value = (normal - (0, 1, 0)).Magnitude() - 0.8;
                    
                    return new vec4(last_result.Color * Math.Min(Math.Max(value, 0), 1), 1.0);
                }
                 
                if (traveled > DrawDistance)
                    break;

                var distance = last_result.Value;
                position += ray * distance;
                traveled += distance;

                last_result = Sdf_March(position, 0);
            }

            return new vec4(BackgroundColor, 1.0);
        }
    }

    public class RayMarchingDistanceShader : RayMarchingShader
    {
        public RayMarchingDistanceShader(RaymarchScene scene, vec3 backgroundColor = default) : base(scene, backgroundColor)
        {
        }

        public override vec4 Run(vec2 xy, vec2 wh)
        {
            var ray = getUvRay(FieldOfView, xy, wh);            

            vec3 position = (0, 0, 0);
            var last_result = Sdf_March(position, 0);
            double traveled = 0;

            for (int marches = 0; marches < MarchLimit; marches++)
            {
                if (last_result.Value < MinStepLength)
                {
                    var value = 1 - (traveled / DrawDistance);
                    return new vec4(last_result.Color * value, 1.0);
                }
                if (traveled > DrawDistance)
                    break;

                var distance = last_result.Value;
                position += ray * distance;
                traveled += distance;

                last_result = Sdf_March(position, 0);
            }

            return new vec4(BackgroundColor, 1.0);
        }
    }

    // 
}
