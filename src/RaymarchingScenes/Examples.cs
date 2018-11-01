using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaymarchingScenes
{
    public static partial class Examples
    {
        public static Node3d SphereCsg(vec3 rotation) =>
            new TranslationNode((0, 3, 20),
                new TransformNode(Transform.RotationY(rotation.Z),
                    new ColorNode((0.7, 0.3, 0),
                        new SubtractNode(
                            new SphereNode(5),
                            new TranslationNode((-5.5, 0, -1),
                                new ColorNode((0.3, 0.3, 0),
                                    new SphereNode(5)
                                )
                            )
                        )
                    )
                )
            );

        public static Node3d SphereSubBox(double rotation, double theta)
        {
            vec3 offset = (0, Math.Sin(theta) * 5, 0);

            var sphere =
                new ColorNode((0.7, 0.3, 0),
                    new SubtractNode(
                        new SphereNode(5),
                        new TranslationNode((-5.5, 0, -1),
                            new ColorNode((1, 0, 0),
                                new SphereNode(5)
                            )
                        )
                    )
                );

            var box =
                new TranslationNode(offset,
                    new ColorNode((0.3, 0.7, 0),
                        new BoxNode(4)
                    )
                );

            Node3d op = null;
            int param = 1; // ((int)(theta / 2 / Math.PI)) % 3
            switch (param)
            {
                case 0:
                    op = new UnionNode(sphere, box);
                    break;
                case 1:
                    op = new SubtractNode(sphere, box);
                    break;
                default:
                    op = new IntersectNode(sphere, box);
                    break;
            }

            return
                new TranslationNode((0, 0, 20), new TransformNode(Transform.RotationY(rotation), op));
        }
    }
}
