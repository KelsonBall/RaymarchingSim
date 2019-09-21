using System;

namespace Render.Core.GraphicsInterfaces
{

    public class UniformAttribute : Attribute
    {
        public readonly int? ArrayLength;

        public readonly string ArrayLengthConstant;

        public UniformAttribute() : base()
        {
            ArrayLength = null;
        }

        public UniformAttribute(int arrayLength) : base()
        {
            ArrayLength = arrayLength;
        }

        public UniformAttribute(string arrayLengthConstant) : base()
        {
            ArrayLengthConstant = arrayLengthConstant;
            ArrayLength = null;
        }
    }
}
