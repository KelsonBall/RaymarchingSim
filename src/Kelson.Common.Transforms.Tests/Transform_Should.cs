using Xunit;
using Kelson.Common.Vectors;
using FluentAssertions;
using System;
using FluentAssertions.Primitives;

namespace Kelson.Common.Transforms.Tests
{
    public static class ShouldExtensions
    {
        public static void BeAproximatelyEquivalentTo(this ObjectAssertions should, vec3 v, double tolerance = float.Epsilon)
        {
            var subject = (vec3)should.Subject;
            subject.X.Should().BeApproximately(v.X, tolerance);
            subject.Y.Should().BeApproximately(v.Y, tolerance);
            subject.Z.Should().BeApproximately(v.Z, tolerance);
        }
    }

    public class Transform_Should
    {
        [Fact]
        public void TranslateCoordinates()
        {
            var t = Transform.Translation(1, 2, 3);
            t.AppliedTo((0, 0, 0))
             .Should()
             .BeEquivalentTo<vec3>((1, 2, 3));
            t.Inverse()
             .AppliedTo((1, 2, 3))
             .Should()
             .BeAproximatelyEquivalentTo((0, 0, 0));
        }

        [Fact]
        public void RotateCoordinatesAroundZAxis()
        {
            var t = Transform.RotationZ(Math.PI / 2);
            t.AppliedTo((1, 0, 0))
             .Should()
             .BeAproximatelyEquivalentTo((0, 1, 0), 1e-16);
            t.Inverse()
             .AppliedTo((0, 1, 0))
             .Should()
             .BeAproximatelyEquivalentTo((1, 0, 0), 1e-16);
        }

        [Fact]
        public void RotateCoordinatesAroundYAxis()
        {
            var t = Transform.RotationY(Math.PI / 2);
            t.AppliedTo((1, 0, 0))
             .Should()
             .BeAproximatelyEquivalentTo((0, 0, -1), 1e-16);
            t.Inverse()
             .AppliedTo((0, 0, -1))
             .Should()
             .BeAproximatelyEquivalentTo((1, 0, 0), 1e-16);
        }

        [Fact]
        public void RotateCoordinatesAroundXAxis()
        {
            var t = Transform.RotationX(Math.PI / 2);
            t.AppliedTo((0, 1, 0))
             .Should()
             .BeAproximatelyEquivalentTo((0, 0, 1), 1e-16);
            t.Inverse()
             .AppliedTo((0, 0, 1))
             .Should()
             .BeAproximatelyEquivalentTo((0, 1, 0), 1e-16);
        }

        [Fact]
        public void ScaleCoordinates()
        {
            var t = Transform.Scale(2);
            t.AppliedTo((1, 2, 3))
             .Should()
             .BeAproximatelyEquivalentTo((2, 4, 6));
            t.Inverse()
             .AppliedTo((2, 4, 6))
             .Should()
             .BeAproximatelyEquivalentTo((1, 2, 3));
        }

        [Fact]
        public void LookAtPoint()
        {
            var t = Transform.LookAt((1, 1, 0), (1, 0, 0), (0, 0, 1));
            var vs = new vec3[]
            {
                t.AppliedTo((0, 0, 0)),
                t.AppliedTo((1, 0, 0)),
                t.AppliedTo((-1, 0, 0)),
                t.AppliedTo((0, 1, 0)),
                t.AppliedTo((0, -1, 0)),
                t.AppliedTo((0, 0, 1)),
                t.AppliedTo((0, 0, -1))
            };


            vs.Should()
             .BeEquivalentTo((1, 2, 0));
        }
    }
}
