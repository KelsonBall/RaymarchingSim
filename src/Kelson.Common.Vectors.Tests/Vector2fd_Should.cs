using System;
using Xunit;
using FluentAssertions;

namespace Kelson.Common.Vectors.Tests
{
    public class Vector2fd_Should
    {
        [Fact]
        public void HaveCorrectValues()
        {
            var v = new vec2(1, 2);
            v.X.Should().BeApproximately(1, double.Epsilon);
            v.Y.Should().BeApproximately(2, double.Epsilon);
        }

        [Fact]
        public void ComputeMagnitudeSquared()
        {            
            new vec2(1, 0)
                .MagnitudeSquared()
                .Should()
                .BeApproximately(1, double.Epsilon);

            new vec2(3, 4)
                .MagnitudeSquared()
                .Should()
                .BeApproximately(25, double.Epsilon);
        }

        [Fact]
        public void ComputeMagnitude()
        {
            new vec2(1, 0)
                .Magnitude()
                .Should()
                .BeApproximately(1, double.Epsilon);

            new vec2(3, 4)
                .Magnitude()
                .Should()
                .BeApproximately(5, double.Epsilon);
        }

        [Fact]
        public void ComputeDotProduct()
        {                        
            new vec2(1, 0)
                .Dot(new vec2(0, 1))
                .Should()
                .BeApproximately(0, double.Epsilon);

            new vec2(1, 1)
                .Dot(new vec2(0, -1))
                .Should()
                .BeApproximately(-1, double.Epsilon);

            new vec2(1, 2)
                .Dot(new vec2(3, 4))
                .Should()
                .BeApproximately(11, double.Epsilon);
        }

        [Fact]
        public void ComputeAddition()
        {            
            new vec2(1, 2)
                .Add(new vec2(3, 4))
                .Should()
                .BeEquivalentTo(new vec2(4, 6));
        }

        [Fact]
        public void ComputeSubtraction()
        {
            new vec2(3, 4)
                .Sub(new vec2(1, 2))
                .Should()
                .BeEquivalentTo(new vec2(2, 2));
        }

        [Fact]
        public void ComputeScale()
        {
            new vec2(1, 0)
                .Scale(2)
                .Should()
                .BeEquivalentTo(new vec2(2, 0));

            new vec2(-2, 1)
                .Scale(3)
                .Should()
                .BeEquivalentTo(new vec2(-6, 3));
        }

        [Fact]
        public void ComputeUnit()
        {
            new vec2(0.1, 0)
                .Unit()
                .X
                .Should()
                .BeApproximately(1, double.Epsilon);
            new vec2(0.1, 0)
                .Unit()
                .Y
                .Should()
                .BeApproximately(0, double.Epsilon);
        }

        [Fact]
        public void ComputeAngle()
        {
            var v1 = new vec2(1, 0);
            var v2 = new vec2(0, 1);
            v1.Angle(v2).Should().BeApproximately(Math.PI / 2, double.Epsilon);
            v2.Angle(v1).Should().BeApproximately(-Math.PI / 2, double.Epsilon);
        }

        [Fact]
        public void ComputeAngularMagnitude()
        {
            var v1 = new vec2(1, 0);
            var v2 = new vec2(0, 1);
            v1.AngularMagnitude(v2).Should().BeApproximately(Math.PI / 2, double.Epsilon);
            v2.AngularMagnitude(v1).Should().BeApproximately(Math.PI / 2, double.Epsilon); // unsigned angle
        }

        [Fact]
        public void ConvertFromValueTupleOfDouble()
        {
            vec2 v = (1, 0);
            v.X.Should().Be(1);
            v.Y.Should().Be(0);
        }

        [Fact]
        public void ConvertFromReferenceTupleOfDouble()
        {
            vec2 v = new Tuple<double, double>(1, 0);
            v.X.Should().Be(1);
            v.Y.Should().Be(0);
        }

        [Fact]
        public void ConvertFromValueTupleOfFloat()
        {
            vec2 v = (1f, 0f);
            v.X.Should().Be(1);
            v.Y.Should().Be(0);
        }

        [Fact]
        public void ConvertFromReferenceTupleOfFloat()
        {
            vec2 v = new Tuple<float, float>(1f, 0f);
            v.X.Should().Be(1);
            v.Y.Should().Be(0);
        }

        [Fact]
        public void ConvertFromDoubleArray()
        {
            var v = (vec2)new double[] { 1, 0 };
            v.X.Should().Be(1);
            v.Y.Should().Be(0);
        }

        [Fact]
        public void ThrowException_WhenCastingFromDoubleArrayWithoutLength2()
        {
            vec2 v;
            ((Action)(() => v = (vec2)new double[] { 1 }))
                .Should()
                .Throw<InvalidOperationException>();
        }

        [Fact]
        public void ConvertFromFloatArray()
        {
            var v = (vec2)new float[] { 1, 0 };
            v.X.Should().Be(1);
            v.Y.Should().Be(0);
        }

        [Fact]
        public void ThrowException_WhenCastingFromArrayFloatWithoutLength2()
        {
            vec2 v;
            ((Action)(() => v = (vec2)new float[] { 1 }))
                .Should()
                .Throw<InvalidOperationException>();
        }

        [Fact]
        public void ConverToSpan()
        {
            vec2 v = (1, 2);
            var span = v.AsSpan();
            span[0].Should().Be(1);
            span[1].Should().Be(2);
        }
    }
}
