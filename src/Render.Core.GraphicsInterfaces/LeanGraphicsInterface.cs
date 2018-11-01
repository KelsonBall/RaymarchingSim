using System;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Render.Core.GraphicsInterface
{
    public class LeanGraphicsInterface : IGraphicsInterface
    {
        public void Uniform2(int location, Vector2 vector)
        {
            GL.Uniform2(location, vector);
        }

        public void Uniform3(int location, Vector3 vector)
        {
            GL.Uniform3(location, vector);
        }

        public void Uniform4(int location, Vector4 vector)
        {
            GL.Uniform4(location, vector);
        }

        public void Uniform4(int location, Color4 color)
        {
            GL.Uniform4(location, color);
        }

        public void Uniform4(int location, Quaternion quaternion)
        {
            GL.Uniform4(location, quaternion);
        }

        public string GetActiveUniformName(int program, int uniformIndex)
        {
            return GL.GetActiveUniformName(program, uniformIndex);
        }

        public string GetActiveUniformBlockName(int program, int uniformIndex)
        {
            return GL.GetActiveUniformBlockName(program, uniformIndex);
        }

        public void ShaderSource(int shader, string @string)
        {
            GL.ShaderSource(shader, @string);
        }

        public string GetShaderInfoLog(int shader)
        {
            return GL.GetShaderInfoLog(shader);
        }

        public string GetProgramInfoLog(int program)
        {
            return GL.GetProgramInfoLog(program);
        }

        public void PointParameter(PointSpriteCoordOriginParameter param)
        {
            GL.PointParameter(param);
        }

        public void VertexAttrib2(int index, Vector2 v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib3(int index, Vector3 v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib4(int index, Vector4 v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib2(int index, Vector2d v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib3(int index, Vector3d v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib4(int index, Vector4d v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void Rect(RectangleF rect)
        {
            GL.Rect(rect);
        }

        public void Rect(Rectangle rect)
        {
            GL.Rect(rect);
        }

        public void VertexPointer(int size, VertexPointerType type, int stride, int offset)
        {
            GL.VertexPointer(size, type, stride, offset);
        }

        public void NormalPointer(NormalPointerType type, int stride, int offset)
        {
            GL.NormalPointer(type, stride, offset);
        }

        public void IndexPointer(IndexPointerType type, int stride, int offset)
        {
            GL.IndexPointer(type, stride, offset);
        }

        public void ColorPointer(int size, ColorPointerType type, int stride, int offset)
        {
            GL.ColorPointer(size, type, stride, offset);
        }

        public void FogCoordPointer(FogPointerType type, int stride, int offset)
        {
            GL.FogCoordPointer(type, stride, offset);
        }

        public void EdgeFlagPointer(int stride, int offset)
        {
            GL.EdgeFlagPointer(stride, offset);
        }

        public void TexCoordPointer(int size, TexCoordPointerType type, int stride, int offset)
        {
            GL.TexCoordPointer(size, type, stride, offset);
        }

        public void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, offset);
        }

        public void Viewport(Size size)
        {
            GL.Viewport(size);
        }

        public void Viewport(Point location, Size size)
        {
            GL.Viewport(location, size);
        }

        public void Viewport(Rectangle rectangle)
        {
            GL.Viewport(rectangle);
        }

        public void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color color)
        {
            GL.TexEnv(target, pname, color);
        }

        public void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color4 color)
        {
            GL.TexEnv(target, pname, color);
        }

        public void VertexAttribPointer<T5>(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, T5[] pointer)
                where T5 : struct
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexAttribPointer<T5>(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, T5[,] pointer)
                where T5 : struct
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexAttribPointer<T5>(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, T5[,,] pointer)
                where T5 : struct
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexBindingDivisor(int bindingindex, int divisor)
        {
            GL.VertexBindingDivisor(bindingindex, divisor);
        }

        public void VertexBindingDivisor(uint bindingindex, uint divisor)
        {
            GL.VertexBindingDivisor(bindingindex, divisor);
        }

        public void VertexP2(PackedPointerType type, int value)
        {
            GL.VertexP2(type, value);
        }

        public void VertexP2(PackedPointerType type, uint value)
        {
            GL.VertexP2(type, value);
        }

        public void VertexP3(PackedPointerType type, int value)
        {
            GL.VertexP3(type, value);
        }

        public void VertexP3(PackedPointerType type, uint value)
        {
            GL.VertexP3(type, value);
        }

        public void VertexP4(PackedPointerType type, int value)
        {
            GL.VertexP4(type, value);
        }

        public void VertexP4(PackedPointerType type, uint value)
        {
            GL.VertexP4(type, value);
        }

        public void VertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer)
        {
            GL.VertexPointer(size, type, stride, pointer);
        }

        public void VertexPointer<T3>(int size, VertexPointerType type, int stride, T3[] pointer)
                where T3 : struct
        {
            GL.VertexPointer(size, type, stride, pointer);
        }

        public void VertexPointer<T3>(int size, VertexPointerType type, int stride, T3[,] pointer)
                where T3 : struct
        {
            GL.VertexPointer(size, type, stride, pointer);
        }

        public void VertexPointer<T3>(int size, VertexPointerType type, int stride, T3[,,] pointer)
                where T3 : struct
        {
            GL.VertexPointer(size, type, stride, pointer);
        }

        public void Viewport(int x, int y, int width, int height)
        {
            GL.Viewport(x, y, width, height);
        }

        public void ViewportArray(int first, int count, Single[] v)
        {
            GL.ViewportArray(first, count, v);
        }

        public void ViewportArray(uint first, int count, Single[] v)
        {
            GL.ViewportArray(first, count, v);
        }

        public void ViewportIndexed(int index, float x, float y, float w, float h)
        {
            GL.ViewportIndexed(index, x, y, w, h);
        }

        public void ViewportIndexed(uint index, float x, float y, float w, float h)
        {
            GL.ViewportIndexed(index, x, y, w, h);
        }

        public void ViewportIndexed(int index, Single[] v)
        {
            GL.ViewportIndexed(index, v);
        }

        public void ViewportIndexed(uint index, Single[] v)
        {
            GL.ViewportIndexed(index, v);
        }

        public WaitSyncStatus WaitSync(IntPtr sync, WaitSyncFlags flags, long timeout)
        {
            return GL.WaitSync(sync, flags, timeout);
        }

        public WaitSyncStatus WaitSync(IntPtr sync, WaitSyncFlags flags, ulong timeout)
        {
            return GL.WaitSync(sync, flags, timeout);
        }

        public void WindowPos2(double x, double y)
        {
            GL.WindowPos2(x, y);
        }

        public void WindowPos2(Double[] v)
        {
            GL.WindowPos2(v);
        }

        public void WindowPos2(float x, float y)
        {
            GL.WindowPos2(x, y);
        }

        public void WindowPos2(Single[] v)
        {
            GL.WindowPos2(v);
        }

        public void WindowPos2(int x, int y)
        {
            GL.WindowPos2(x, y);
        }

        public void WindowPos2(Int32[] v)
        {
            GL.WindowPos2(v);
        }

        public void WindowPos2(short x, short y)
        {
            GL.WindowPos2(x, y);
        }

        public void WindowPos2(Int16[] v)
        {
            GL.WindowPos2(v);
        }

        public void WindowPos3(double x, double y, double z)
        {
            GL.WindowPos3(x, y, z);
        }

        public void WindowPos3(Double[] v)
        {
            GL.WindowPos3(v);
        }

        public void WindowPos3(float x, float y, float z)
        {
            GL.WindowPos3(x, y, z);
        }

        public void WindowPos3(Single[] v)
        {
            GL.WindowPos3(v);
        }

        public void WindowPos3(int x, int y, int z)
        {
            GL.WindowPos3(x, y, z);
        }

        public void WindowPos3(Int32[] v)
        {
            GL.WindowPos3(v);
        }

        public void WindowPos3(short x, short y, short z)
        {
            GL.WindowPos3(x, y, z);
        }

        public void WindowPos3(Int16[] v)
        {
            GL.WindowPos3(v);
        }

        public void Color3(Color color)
        {
            GL.Color3(color);
        }

        public void Color4(Color color)
        {
            GL.Color4(color);
        }

        public void Color3(Vector3 color)
        {
            GL.Color3(color);
        }

        public void Color4(Vector4 color)
        {
            GL.Color4(color);
        }

        public void Color4(Color4 color)
        {
            GL.Color4(color);
        }

        public void ClearColor(Color color)
        {
            GL.ClearColor(color);
        }

        public void ClearColor(Color4 color)
        {
            GL.ClearColor(color);
        }

        public void BlendColor(Color color)
        {
            GL.BlendColor(color);
        }

        public void BlendColor(Color4 color)
        {
            GL.BlendColor(color);
        }

        public void Material(MaterialFace face, MaterialParameter pname, Vector4 @params)
        {
            GL.Material(face, pname, @params);
        }

        public void Material(MaterialFace face, MaterialParameter pname, Color4 @params)
        {
            GL.Material(face, pname, @params);
        }

        public void Light(LightName name, LightParameter pname, Vector4 @params)
        {
            GL.Light(name, pname, @params);
        }

        public void Light(LightName name, LightParameter pname, Color4 @params)
        {
            GL.Light(name, pname, @params);
        }

        public void Normal3(Vector3 normal)
        {
            GL.Normal3(normal);
        }

        public void RasterPos2(Vector2 pos)
        {
            GL.RasterPos2(pos);
        }

        public void RasterPos3(Vector3 pos)
        {
            GL.RasterPos3(pos);
        }

        public void RasterPos4(Vector4 pos)
        {
            GL.RasterPos4(pos);
        }

        public void Vertex2(Vector2 v)
        {
            GL.Vertex2(v);
        }

        public void Vertex3(Vector3 v)
        {
            GL.Vertex3(v);
        }

        public void Vertex4(Vector4 v)
        {
            GL.Vertex4(v);
        }

        public void TexCoord2(Vector2 v)
        {
            GL.TexCoord2(v);
        }

        public void TexCoord3(Vector3 v)
        {
            GL.TexCoord3(v);
        }

        public void TexCoord4(Vector4 v)
        {
            GL.TexCoord4(v);
        }

        public void Rotate(float angle, Vector3 axis)
        {
            GL.Rotate(angle, axis);
        }

        public void Scale(Vector3 scale)
        {
            GL.Scale(scale);
        }

        public void Translate(Vector3 trans)
        {
            GL.Translate(trans);
        }

        public void Normal3(Vector3d normal)
        {
            GL.Normal3(normal);
        }

        public void RasterPos2(Vector2d pos)
        {
            GL.RasterPos2(pos);
        }

        public void RasterPos3(Vector3d pos)
        {
            GL.RasterPos3(pos);
        }

        public void RasterPos4(Vector4d pos)
        {
            GL.RasterPos4(pos);
        }

        public void Vertex2(Vector2d v)
        {
            GL.Vertex2(v);
        }

        public void Vertex3(Vector3d v)
        {
            GL.Vertex3(v);
        }

        public void Vertex4(Vector4d v)
        {
            GL.Vertex4(v);
        }

        public void TexCoord2(Vector2d v)
        {
            GL.TexCoord2(v);
        }

        public void TexCoord3(Vector3d v)
        {
            GL.TexCoord3(v);
        }

        public void TexCoord4(Vector4d v)
        {
            GL.TexCoord4(v);
        }

        public void Rotate(double angle, Vector3d axis)
        {
            GL.Rotate(angle, axis);
        }

        public void Scale(Vector3d scale)
        {
            GL.Scale(scale);
        }

        public void Translate(Vector3d trans)
        {
            GL.Translate(trans);
        }

        public void VertexAttribIPointer(int index, int size, VertexAttribIntegerType type, int stride, IntPtr pointer)
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribIPointer<T4>(int index, int size, VertexAttribIntegerType type, int stride, T4[] pointer)
                where T4 : struct
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribIPointer<T4>(int index, int size, VertexAttribIntegerType type, int stride, T4[,] pointer)
                where T4 : struct
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribIPointer<T4>(int index, int size, VertexAttribIntegerType type, int stride, T4[,,] pointer)
                where T4 : struct
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribIPointer(uint index, int size, VertexAttribIntegerType type, int stride, IntPtr pointer)
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribIPointer<T4>(uint index, int size, VertexAttribIntegerType type, int stride, T4[] pointer)
                where T4 : struct
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribIPointer<T4>(uint index, int size, VertexAttribIntegerType type, int stride, T4[,] pointer)
                where T4 : struct
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribIPointer<T4>(uint index, int size, VertexAttribIntegerType type, int stride, T4[,,] pointer)
                where T4 : struct
        {
            GL.VertexAttribIPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribL1(int index, double x)
        {
            GL.VertexAttribL1(index, x);
        }

        public void VertexAttribL1(uint index, double x)
        {
            GL.VertexAttribL1(index, x);
        }

        public void VertexAttribL2(int index, double x, double y)
        {
            GL.VertexAttribL2(index, x, y);
        }

        public void VertexAttribL2(uint index, double x, double y)
        {
            GL.VertexAttribL2(index, x, y);
        }

        public void VertexAttribL2(int index, Double[] v)
        {
            GL.VertexAttribL2(index, v);
        }

        public void VertexAttribL2(uint index, Double[] v)
        {
            GL.VertexAttribL2(index, v);
        }

        public void VertexAttribL3(int index, double x, double y, double z)
        {
            GL.VertexAttribL3(index, x, y, z);
        }

        public void VertexAttribL3(uint index, double x, double y, double z)
        {
            GL.VertexAttribL3(index, x, y, z);
        }

        public void VertexAttribL3(int index, Double[] v)
        {
            GL.VertexAttribL3(index, v);
        }

        public void VertexAttribL3(uint index, Double[] v)
        {
            GL.VertexAttribL3(index, v);
        }

        public void VertexAttribL4(int index, double x, double y, double z, double w)
        {
            GL.VertexAttribL4(index, x, y, z, w);
        }

        public void VertexAttribL4(uint index, double x, double y, double z, double w)
        {
            GL.VertexAttribL4(index, x, y, z, w);
        }

        public void VertexAttribL4(int index, Double[] v)
        {
            GL.VertexAttribL4(index, v);
        }

        public void VertexAttribL4(uint index, Double[] v)
        {
            GL.VertexAttribL4(index, v);
        }

        public void VertexAttribLFormat(int attribindex, int size, VertexAttribDoubleType type, int relativeoffset)
        {
            GL.VertexAttribLFormat(attribindex, size, type, relativeoffset);
        }

        public void VertexAttribLFormat(uint attribindex, int size, VertexAttribDoubleType type, uint relativeoffset)
        {
            GL.VertexAttribLFormat(attribindex, size, type, relativeoffset);
        }

        public void VertexAttribLPointer(int index, int size, VertexAttribDoubleType type, int stride, IntPtr pointer)
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribLPointer<T4>(int index, int size, VertexAttribDoubleType type, int stride, T4[] pointer)
                where T4 : struct
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribLPointer<T4>(int index, int size, VertexAttribDoubleType type, int stride, T4[,] pointer)
                where T4 : struct
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribLPointer<T4>(int index, int size, VertexAttribDoubleType type, int stride, T4[,,] pointer)
                where T4 : struct
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribLPointer(uint index, int size, VertexAttribDoubleType type, int stride, IntPtr pointer)
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribLPointer<T4>(uint index, int size, VertexAttribDoubleType type, int stride, T4[] pointer)
                where T4 : struct
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribLPointer<T4>(uint index, int size, VertexAttribDoubleType type, int stride, T4[,] pointer)
                where T4 : struct
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribLPointer<T4>(uint index, int size, VertexAttribDoubleType type, int stride, T4[,,] pointer)
                where T4 : struct
        {
            GL.VertexAttribLPointer(index, size, type, stride, pointer);
        }

        public void VertexAttribP1(int index, PackedPointerType type, bool normalized, int value)
        {
            GL.VertexAttribP1(index, type, normalized, value);
        }

        public void VertexAttribP1(uint index, PackedPointerType type, bool normalized, uint value)
        {
            GL.VertexAttribP1(index, type, normalized, value);
        }

        public void VertexAttribP2(int index, PackedPointerType type, bool normalized, int value)
        {
            GL.VertexAttribP2(index, type, normalized, value);
        }

        public void VertexAttribP2(uint index, PackedPointerType type, bool normalized, uint value)
        {
            GL.VertexAttribP2(index, type, normalized, value);
        }

        public void VertexAttribP3(int index, PackedPointerType type, bool normalized, int value)
        {
            GL.VertexAttribP3(index, type, normalized, value);
        }

        public void VertexAttribP3(uint index, PackedPointerType type, bool normalized, uint value)
        {
            GL.VertexAttribP3(index, type, normalized, value);
        }

        public void VertexAttribP4(int index, PackedPointerType type, bool normalized, int value)
        {
            GL.VertexAttribP4(index, type, normalized, value);
        }

        public void VertexAttribP4(uint index, PackedPointerType type, bool normalized, uint value)
        {
            GL.VertexAttribP4(index, type, normalized, value);
        }

        public void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer)
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexAttribPointer<T5>(int index, int size, VertexAttribPointerType type, bool normalized, int stride, T5[] pointer)
                where T5 : struct
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexAttribPointer<T5>(int index, int size, VertexAttribPointerType type, bool normalized, int stride, T5[,] pointer)
                where T5 : struct
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexAttribPointer<T5>(int index, int size, VertexAttribPointerType type, bool normalized, int stride, T5[,,] pointer)
                where T5 : struct
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer)
        {
            GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public void VertexAttrib4(uint index, Single[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(int index, Int32[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(uint index, Int32[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4N(uint index, SByte[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(int index, Int32[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(uint index, Int32[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(int index, Int16[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(uint index, Int16[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(int index, byte x, byte y, byte z, byte w)
        {
            GL.VertexAttrib4N(index, x, y, z, w);
        }

        public void VertexAttrib4N(uint index, byte x, byte y, byte z, byte w)
        {
            GL.VertexAttrib4N(index, x, y, z, w);
        }

        public void VertexAttrib4N(int index, Byte[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(uint index, Byte[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(uint index, UInt32[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4N(uint index, UInt16[] v)
        {
            GL.VertexAttrib4N(index, v);
        }

        public void VertexAttrib4(int index, short x, short y, short z, short w)
        {
            GL.VertexAttrib4(index, x, y, z, w);
        }

        public void VertexAttrib4(uint index, short x, short y, short z, short w)
        {
            GL.VertexAttrib4(index, x, y, z, w);
        }

        public void VertexAttrib4(int index, Int16[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(uint index, Int16[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(int index, Byte[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(uint index, Byte[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(uint index, UInt32[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(uint index, UInt16[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttribBinding(int attribindex, int bindingindex)
        {
            GL.VertexAttribBinding(attribindex, bindingindex);
        }

        public void VertexAttribBinding(uint attribindex, uint bindingindex)
        {
            GL.VertexAttribBinding(attribindex, bindingindex);
        }

        public void VertexAttribDivisor(int index, int divisor)
        {
            GL.VertexAttribDivisor(index, divisor);
        }

        public void VertexAttribDivisor(uint index, uint divisor)
        {
            GL.VertexAttribDivisor(index, divisor);
        }

        public void VertexAttribFormat(int attribindex, int size, VertexAttribType type, bool normalized, int relativeoffset)
        {
            GL.VertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
        }

        public void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset)
        {
            GL.VertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
        }

        public void VertexAttribI1(int index, int x)
        {
            GL.VertexAttribI1(index, x);
        }

        public void VertexAttribI1(uint index, int x)
        {
            GL.VertexAttribI1(index, x);
        }

        public void VertexAttribI1(uint index, uint x)
        {
            GL.VertexAttribI1(index, x);
        }

        public void VertexAttribI2(int index, int x, int y)
        {
            GL.VertexAttribI2(index, x, y);
        }

        public void VertexAttribI2(uint index, int x, int y)
        {
            GL.VertexAttribI2(index, x, y);
        }

        public void VertexAttribI2(int index, Int32[] v)
        {
            GL.VertexAttribI2(index, v);
        }

        public void VertexAttribI2(uint index, Int32[] v)
        {
            GL.VertexAttribI2(index, v);
        }

        public void VertexAttribI2(uint index, uint x, uint y)
        {
            GL.VertexAttribI2(index, x, y);
        }

        public void VertexAttribI2(uint index, UInt32[] v)
        {
            GL.VertexAttribI2(index, v);
        }

        public void VertexAttribI3(int index, int x, int y, int z)
        {
            GL.VertexAttribI3(index, x, y, z);
        }

        public void VertexAttribI3(uint index, int x, int y, int z)
        {
            GL.VertexAttribI3(index, x, y, z);
        }

        public void VertexAttribI3(int index, Int32[] v)
        {
            GL.VertexAttribI3(index, v);
        }

        public void VertexAttribI3(uint index, Int32[] v)
        {
            GL.VertexAttribI3(index, v);
        }

        public void VertexAttribI3(uint index, uint x, uint y, uint z)
        {
            GL.VertexAttribI3(index, x, y, z);
        }

        public void VertexAttribI3(uint index, UInt32[] v)
        {
            GL.VertexAttribI3(index, v);
        }

        public void VertexAttribI4(uint index, SByte[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(int index, int x, int y, int z, int w)
        {
            GL.VertexAttribI4(index, x, y, z, w);
        }

        public void VertexAttribI4(uint index, int x, int y, int z, int w)
        {
            GL.VertexAttribI4(index, x, y, z, w);
        }

        public void VertexAttribI4(int index, Int32[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(uint index, Int32[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(int index, Int16[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(uint index, Int16[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(int index, Byte[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(uint index, Byte[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(uint index, uint x, uint y, uint z, uint w)
        {
            GL.VertexAttribI4(index, x, y, z, w);
        }

        public void VertexAttribI4(uint index, UInt32[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribI4(uint index, UInt16[] v)
        {
            GL.VertexAttribI4(index, v);
        }

        public void VertexAttribIFormat(int attribindex, int size, VertexAttribIntegerType type, int relativeoffset)
        {
            GL.VertexAttribIFormat(attribindex, size, type, relativeoffset);
        }

        public void VertexAttribIFormat(uint attribindex, int size, VertexAttribIntegerType type, uint relativeoffset)
        {
            GL.VertexAttribIFormat(attribindex, size, type, relativeoffset);
        }

        public void Vertex3(double x, double y, double z)
        {
            GL.Vertex3(x, y, z);
        }

        public void Vertex3(Double[] v)
        {
            GL.Vertex3(v);
        }

        public void Vertex3(float x, float y, float z)
        {
            GL.Vertex3(x, y, z);
        }

        public void Vertex3(Single[] v)
        {
            GL.Vertex3(v);
        }

        public void Vertex3(int x, int y, int z)
        {
            GL.Vertex3(x, y, z);
        }

        public void Vertex3(Int32[] v)
        {
            GL.Vertex3(v);
        }

        public void Vertex3(short x, short y, short z)
        {
            GL.Vertex3(x, y, z);
        }

        public void Vertex3(Int16[] v)
        {
            GL.Vertex3(v);
        }

        public void Vertex4(double x, double y, double z, double w)
        {
            GL.Vertex4(x, y, z, w);
        }

        public void Vertex4(Double[] v)
        {
            GL.Vertex4(v);
        }

        public void Vertex4(float x, float y, float z, float w)
        {
            GL.Vertex4(x, y, z, w);
        }

        public void Vertex4(Single[] v)
        {
            GL.Vertex4(v);
        }

        public void Vertex4(int x, int y, int z, int w)
        {
            GL.Vertex4(x, y, z, w);
        }

        public void Vertex4(Int32[] v)
        {
            GL.Vertex4(v);
        }

        public void Vertex4(short x, short y, short z, short w)
        {
            GL.Vertex4(x, y, z, w);
        }

        public void Vertex4(Int16[] v)
        {
            GL.Vertex4(v);
        }

        public void VertexArrayAttribBinding(int vaobj, int attribindex, int bindingindex)
        {
            GL.VertexArrayAttribBinding(vaobj, attribindex, bindingindex);
        }

        public void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
        {
            GL.VertexArrayAttribBinding(vaobj, attribindex, bindingindex);
        }

        public void VertexArrayAttribFormat(int vaobj, int attribindex, int size, VertexAttribType type, bool normalized, int relativeoffset)
        {
            GL.VertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
        }

        public void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset)
        {
            GL.VertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
        }

        public void VertexArrayAttribIFormat(int vaobj, int attribindex, int size, VertexAttribType type, int relativeoffset)
        {
            GL.VertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
        }

        public void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, VertexAttribType type, uint relativeoffset)
        {
            GL.VertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
        }

        public void VertexArrayAttribLFormat(int vaobj, int attribindex, int size, All type, int relativeoffset)
        {
            GL.VertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
        }

        public void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, All type, uint relativeoffset)
        {
            GL.VertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
        }

        public void VertexArrayBindingDivisor(int vaobj, int bindingindex, int divisor)
        {
            GL.VertexArrayBindingDivisor(vaobj, bindingindex, divisor);
        }

        public void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
        {
            GL.VertexArrayBindingDivisor(vaobj, bindingindex, divisor);
        }

        public void VertexArrayElementBuffer(int vaobj, int buffer)
        {
            GL.VertexArrayElementBuffer(vaobj, buffer);
        }

        public void VertexArrayElementBuffer(uint vaobj, uint buffer)
        {
            GL.VertexArrayElementBuffer(vaobj, buffer);
        }

        public void VertexArrayVertexBuffer(int vaobj, int bindingindex, int buffer, IntPtr offset, int stride)
        {
            GL.VertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
        }

        public void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride)
        {
            GL.VertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
        }

        public void VertexArrayVertexBuffers(int vaobj, int first, int count, Int32[] buffers, IntPtr[] offsets, Int32[] strides)
        {
            GL.VertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
        }

        public void VertexArrayVertexBuffers(uint vaobj, uint first, int count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
        {
            GL.VertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
        }

        public void VertexAttrib1(int index, double x)
        {
            GL.VertexAttrib1(index, x);
        }

        public void VertexAttrib1(uint index, double x)
        {
            GL.VertexAttrib1(index, x);
        }

        public void VertexAttrib1(int index, float x)
        {
            GL.VertexAttrib1(index, x);
        }

        public void VertexAttrib1(uint index, float x)
        {
            GL.VertexAttrib1(index, x);
        }

        public void VertexAttrib1(int index, short x)
        {
            GL.VertexAttrib1(index, x);
        }

        public void VertexAttrib1(uint index, short x)
        {
            GL.VertexAttrib1(index, x);
        }

        public void VertexAttrib2(int index, double x, double y)
        {
            GL.VertexAttrib2(index, x, y);
        }

        public void VertexAttrib2(uint index, double x, double y)
        {
            GL.VertexAttrib2(index, x, y);
        }

        public void VertexAttrib2(int index, Double[] v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib2(uint index, Double[] v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib2(int index, float x, float y)
        {
            GL.VertexAttrib2(index, x, y);
        }

        public void VertexAttrib2(uint index, float x, float y)
        {
            GL.VertexAttrib2(index, x, y);
        }

        public void VertexAttrib2(int index, Single[] v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib2(uint index, Single[] v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib2(int index, short x, short y)
        {
            GL.VertexAttrib2(index, x, y);
        }

        public void VertexAttrib2(uint index, short x, short y)
        {
            GL.VertexAttrib2(index, x, y);
        }

        public void VertexAttrib2(int index, Int16[] v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib2(uint index, Int16[] v)
        {
            GL.VertexAttrib2(index, v);
        }

        public void VertexAttrib3(int index, double x, double y, double z)
        {
            GL.VertexAttrib3(index, x, y, z);
        }

        public void VertexAttrib3(uint index, double x, double y, double z)
        {
            GL.VertexAttrib3(index, x, y, z);
        }

        public void VertexAttrib3(int index, Double[] v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib3(uint index, Double[] v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib3(int index, float x, float y, float z)
        {
            GL.VertexAttrib3(index, x, y, z);
        }

        public void VertexAttrib3(uint index, float x, float y, float z)
        {
            GL.VertexAttrib3(index, x, y, z);
        }

        public void VertexAttrib3(int index, Single[] v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib3(uint index, Single[] v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib3(int index, short x, short y, short z)
        {
            GL.VertexAttrib3(index, x, y, z);
        }

        public void VertexAttrib3(uint index, short x, short y, short z)
        {
            GL.VertexAttrib3(index, x, y, z);
        }

        public void VertexAttrib3(int index, Int16[] v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib3(uint index, Int16[] v)
        {
            GL.VertexAttrib3(index, v);
        }

        public void VertexAttrib4(uint index, SByte[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(int index, double x, double y, double z, double w)
        {
            GL.VertexAttrib4(index, x, y, z, w);
        }

        public void VertexAttrib4(uint index, double x, double y, double z, double w)
        {
            GL.VertexAttrib4(index, x, y, z, w);
        }

        public void VertexAttrib4(int index, Double[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(uint index, Double[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void VertexAttrib4(int index, float x, float y, float z, float w)
        {
            GL.VertexAttrib4(index, x, y, z, w);
        }

        public void VertexAttrib4(uint index, float x, float y, float z, float w)
        {
            GL.VertexAttrib4(index, x, y, z, w);
        }

        public void VertexAttrib4(int index, Single[] v)
        {
            GL.VertexAttrib4(index, v);
        }

        public void Uniform2(int location, int v0, int v1)
        {
            GL.Uniform2(location, v0, v1);
        }

        public void Uniform2(int location, int count, Int32[] value)
        {
            GL.Uniform2(location, count, value);
        }

        public void Uniform2(int location, uint v0, uint v1)
        {
            GL.Uniform2(location, v0, v1);
        }

        public void Uniform2(int location, int count, UInt32[] value)
        {
            GL.Uniform2(location, count, value);
        }

        public void Uniform3(int location, double x, double y, double z)
        {
            GL.Uniform3(location, x, y, z);
        }

        public void Uniform3(int location, int count, Double[] value)
        {
            GL.Uniform3(location, count, value);
        }

        public void Uniform3(int location, float v0, float v1, float v2)
        {
            GL.Uniform3(location, v0, v1, v2);
        }

        public void Uniform3(int location, int count, Single[] value)
        {
            GL.Uniform3(location, count, value);
        }

        public void Uniform3(int location, int v0, int v1, int v2)
        {
            GL.Uniform3(location, v0, v1, v2);
        }

        public void Uniform3(int location, int count, Int32[] value)
        {
            GL.Uniform3(location, count, value);
        }

        public void Uniform3(int location, uint v0, uint v1, uint v2)
        {
            GL.Uniform3(location, v0, v1, v2);
        }

        public void Uniform3(int location, int count, UInt32[] value)
        {
            GL.Uniform3(location, count, value);
        }

        public void Uniform4(int location, double x, double y, double z, double w)
        {
            GL.Uniform4(location, x, y, z, w);
        }

        public void Uniform4(int location, int count, Double[] value)
        {
            GL.Uniform4(location, count, value);
        }

        public void Uniform4(int location, float v0, float v1, float v2, float v3)
        {
            GL.Uniform4(location, v0, v1, v2, v3);
        }

        public void Uniform4(int location, int count, Single[] value)
        {
            GL.Uniform4(location, count, value);
        }

        public void Uniform4(int location, int v0, int v1, int v2, int v3)
        {
            GL.Uniform4(location, v0, v1, v2, v3);
        }

        public void Uniform4(int location, int count, Int32[] value)
        {
            GL.Uniform4(location, count, value);
        }

        public void Uniform4(int location, uint v0, uint v1, uint v2, uint v3)
        {
            GL.Uniform4(location, v0, v1, v2, v3);
        }

        public void Uniform4(int location, int count, UInt32[] value)
        {
            GL.Uniform4(location, count, value);
        }

        public void UniformBlockBinding(int program, int uniformBlockIndex, int uniformBlockBinding)
        {
            GL.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
        }

        public void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
        {
            GL.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
        }

        public void UniformMatrix2(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix2(location, count, transpose, value);
        }

        public void UniformMatrix2(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix2(location, count, transpose, value);
        }

        public void UniformMatrix2x3(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix2x3(location, count, transpose, value);
        }

        public void UniformMatrix2x3(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix2x3(location, count, transpose, value);
        }

        public void UniformMatrix2x4(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix2x4(location, count, transpose, value);
        }

        public void UniformMatrix2x4(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix2x4(location, count, transpose, value);
        }

        public void UniformMatrix3(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix3(location, count, transpose, value);
        }

        public void UniformMatrix3(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix3(location, count, transpose, value);
        }

        public void UniformMatrix3x2(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix3x2(location, count, transpose, value);
        }

        public void UniformMatrix3x2(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix3x2(location, count, transpose, value);
        }

        public void UniformMatrix3x4(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix3x4(location, count, transpose, value);
        }

        public void UniformMatrix3x4(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix3x4(location, count, transpose, value);
        }

        public void UniformMatrix4(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix4(location, count, transpose, value);
        }

        public void UniformMatrix4(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix4(location, count, transpose, value);
        }

        public void UniformMatrix4x2(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix4x2(location, count, transpose, value);
        }

        public void UniformMatrix4x2(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix4x2(location, count, transpose, value);
        }

        public void UniformMatrix4x3(int location, int count, bool transpose, Double[] value)
        {
            GL.UniformMatrix4x3(location, count, transpose, value);
        }

        public void UniformMatrix4x3(int location, int count, bool transpose, Single[] value)
        {
            GL.UniformMatrix4x3(location, count, transpose, value);
        }

        public void UniformSubroutines(ShaderType shadertype, int count, Int32[] indices)
        {
            GL.UniformSubroutines(shadertype, count, indices);
        }

        public void UniformSubroutines(ShaderType shadertype, int count, UInt32[] indices)
        {
            GL.UniformSubroutines(shadertype, count, indices);
        }

        public bool UnmapBuffer(BufferTarget target)
        {
            return GL.UnmapBuffer(target);
        }

        public bool UnmapNamedBuffer(int buffer)
        {
            return GL.UnmapNamedBuffer(buffer);
        }

        public bool UnmapNamedBuffer(uint buffer)
        {
            return GL.UnmapNamedBuffer(buffer);
        }

        public void UseProgram(int program)
        {
            GL.UseProgram(program);
        }

        public void UseProgram(uint program)
        {
            GL.UseProgram(program);
        }

        public void UseProgramStages(int pipeline, ProgramStageMask stages, int program)
        {
            GL.UseProgramStages(pipeline, stages, program);
        }

        public void UseProgramStages(uint pipeline, ProgramStageMask stages, uint program)
        {
            GL.UseProgramStages(pipeline, stages, program);
        }

        public void ValidateProgram(int program)
        {
            GL.ValidateProgram(program);
        }

        public void ValidateProgram(uint program)
        {
            GL.ValidateProgram(program);
        }

        public void ValidateProgramPipeline(int pipeline)
        {
            GL.ValidateProgramPipeline(pipeline);
        }

        public void ValidateProgramPipeline(uint pipeline)
        {
            GL.ValidateProgramPipeline(pipeline);
        }

        public void Vertex2(double x, double y)
        {
            GL.Vertex2(x, y);
        }

        public void Vertex2(Double[] v)
        {
            GL.Vertex2(v);
        }

        public void Vertex2(float x, float y)
        {
            GL.Vertex2(x, y);
        }

        public void Vertex2(Single[] v)
        {
            GL.Vertex2(v);
        }

        public void Vertex2(int x, int y)
        {
            GL.Vertex2(x, y);
        }

        public void Vertex2(Int32[] v)
        {
            GL.Vertex2(v);
        }

        public void Vertex2(short x, short y)
        {
            GL.Vertex2(x, y);
        }

        public void Vertex2(Int16[] v)
        {
            GL.Vertex2(v);
        }

        public void TexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,] pixels)
                where T10 : struct
        {
            GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,,] pixels)
                where T10 : struct
        {
            GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureBarrier()
        {
            GL.TextureBarrier();
        }

        public void TextureBuffer(int texture, SizedInternalFormat internalformat, int buffer)
        {
            GL.TextureBuffer(texture, internalformat, buffer);
        }

        public void TextureBuffer(uint texture, SizedInternalFormat internalformat, uint buffer)
        {
            GL.TextureBuffer(texture, internalformat, buffer);
        }

        public void TextureBufferRange(int texture, SizedInternalFormat internalformat, int buffer, IntPtr offset, int size)
        {
            GL.TextureBufferRange(texture, internalformat, buffer, offset, size);
        }

        public void TextureBufferRange(uint texture, SizedInternalFormat internalformat, uint buffer, IntPtr offset, int size)
        {
            GL.TextureBufferRange(texture, internalformat, buffer, offset, size);
        }

        public void TextureParameter(int texture, TextureParameterName pname, float param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureParameter(uint texture, TextureParameterName pname, float param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureParameter(int texture, TextureParameterName pname, Single[] param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureParameter(uint texture, TextureParameterName pname, Single[] param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureParameter(int texture, TextureParameterName pname, int param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureParameter(uint texture, TextureParameterName pname, int param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureParameterI(int texture, All pname, Int32[] @params)
        {
            GL.TextureParameterI(texture, pname, @params);
        }

        public void TextureParameterI(uint texture, All pname, Int32[] @params)
        {
            GL.TextureParameterI(texture, pname, @params);
        }

        public void TextureParameterI(uint texture, All pname, UInt32[] @params)
        {
            GL.TextureParameterI(texture, pname, @params);
        }

        public void TextureParameter(int texture, TextureParameterName pname, Int32[] param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureParameter(uint texture, TextureParameterName pname, Int32[] param)
        {
            GL.TextureParameter(texture, pname, param);
        }

        public void TextureStorage1D(int texture, int levels, SizedInternalFormat internalformat, int width)
        {
            GL.TextureStorage1D(texture, levels, internalformat, width);
        }

        public void TextureStorage1D(uint texture, int levels, SizedInternalFormat internalformat, int width)
        {
            GL.TextureStorage1D(texture, levels, internalformat, width);
        }

        public void TextureStorage2D(int texture, int levels, SizedInternalFormat internalformat, int width, int height)
        {
            GL.TextureStorage2D(texture, levels, internalformat, width, height);
        }

        public void TextureStorage2D(uint texture, int levels, SizedInternalFormat internalformat, int width, int height)
        {
            GL.TextureStorage2D(texture, levels, internalformat, width, height);
        }

        public void TextureStorage2DMultisample(int texture, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            GL.TextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
        }

        public void TextureStorage2DMultisample(uint texture, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            GL.TextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
        }

        public void TextureStorage3D(int texture, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
        {
            GL.TextureStorage3D(texture, levels, internalformat, width, height, depth);
        }

        public void TextureStorage3D(uint texture, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
        {
            GL.TextureStorage3D(texture, levels, internalformat, width, height, depth);
        }

        public void TextureStorage3DMultisample(int texture, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            GL.TextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
        }

        public void TextureStorage3DMultisample(uint texture, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            GL.TextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
        }

        public void TextureSubImage1D(int texture, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage1D<T6>(int texture, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[] pixels)
                where T6 : struct
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage1D<T6>(int texture, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[,] pixels)
                where T6 : struct
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage1D<T6>(int texture, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[,,] pixels)
                where T6 : struct
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage1D<T6>(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[] pixels)
                where T6 : struct
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage1D<T6>(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[,] pixels)
                where T6 : struct
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage1D<T6>(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[,,] pixels)
                where T6 : struct
        {
            GL.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public void TextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage2D<T8>(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[] pixels)
                where T8 : struct
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage2D<T8>(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[,] pixels)
                where T8 : struct
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage2D<T8>(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[,,] pixels)
                where T8 : struct
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage2D<T8>(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[] pixels)
                where T8 : struct
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage2D<T8>(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[,] pixels)
                where T8 : struct
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage2D<T8>(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[,,] pixels)
                where T8 : struct
        {
            GL.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureSubImage3D<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[] pixels)
                where T10 : struct
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureSubImage3D<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,] pixels)
                where T10 : struct
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureSubImage3D<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,,] pixels)
                where T10 : struct
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureSubImage3D<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[] pixels)
                where T10 : struct
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureSubImage3D<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,] pixels)
                where T10 : struct
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureSubImage3D<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,,] pixels)
                where T10 : struct
        {
            GL.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TextureView(int texture, TextureTarget target, int origtexture, PixelInternalFormat internalformat, int minlevel, int numlevels, int minlayer, int numlayers)
        {
            GL.TextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
        }

        public void TextureView(uint texture, TextureTarget target, uint origtexture, PixelInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
        {
            GL.TextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
        }

        public void TransformFeedbackBufferBase(int xfb, int index, int buffer)
        {
            GL.TransformFeedbackBufferBase(xfb, index, buffer);
        }

        public void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
        {
            GL.TransformFeedbackBufferBase(xfb, index, buffer);
        }

        public void TransformFeedbackBufferRange(int xfb, int index, int buffer, IntPtr offset, int size)
        {
            GL.TransformFeedbackBufferRange(xfb, index, buffer, offset, size);
        }

        public void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, int size)
        {
            GL.TransformFeedbackBufferRange(xfb, index, buffer, offset, size);
        }

        public void TransformFeedbackVaryings(int program, int count, String[] varyings, TransformFeedbackMode bufferMode)
        {
            GL.TransformFeedbackVaryings(program, count, varyings, bufferMode);
        }

        public void TransformFeedbackVaryings(uint program, int count, String[] varyings, TransformFeedbackMode bufferMode)
        {
            GL.TransformFeedbackVaryings(program, count, varyings, bufferMode);
        }

        public void Translate(double x, double y, double z)
        {
            GL.Translate(x, y, z);
        }

        public void Translate(float x, float y, float z)
        {
            GL.Translate(x, y, z);
        }

        public void Uniform1(int location, double x)
        {
            GL.Uniform1(location, x);
        }

        public void Uniform1(int location, int count, Double[] value)
        {
            GL.Uniform1(location, count, value);
        }

        public void Uniform1(int location, float v0)
        {
            GL.Uniform1(location, v0);
        }

        public void Uniform1(int location, int count, Single[] value)
        {
            GL.Uniform1(location, count, value);
        }

        public void Uniform1(int location, int v0)
        {
            GL.Uniform1(location, v0);
        }

        public void Uniform1(int location, int count, Int32[] value)
        {
            GL.Uniform1(location, count, value);
        }

        public void Uniform1(int location, uint v0)
        {
            GL.Uniform1(location, v0);
        }

        public void Uniform1(int location, int count, UInt32[] value)
        {
            GL.Uniform1(location, count, value);
        }

        public void Uniform2(int location, double x, double y)
        {
            GL.Uniform2(location, x, y);
        }

        public void Uniform2(int location, int count, Double[] value)
        {
            GL.Uniform2(location, count, value);
        }

        public void Uniform2(int location, float v0, float v1)
        {
            GL.Uniform2(location, v0, v1);
        }

        public void Uniform2(int location, int count, Single[] value)
        {
            GL.Uniform2(location, count, value);
        }

        public void TexCoord3(short s, short t, short r)
        {
            GL.TexCoord3(s, t, r);
        }

        public void TexCoord3(Int16[] v)
        {
            GL.TexCoord3(v);
        }

        public void TexCoord4(double s, double t, double r, double q)
        {
            GL.TexCoord4(s, t, r, q);
        }

        public void TexCoord4(Double[] v)
        {
            GL.TexCoord4(v);
        }

        public void TexCoord4(float s, float t, float r, float q)
        {
            GL.TexCoord4(s, t, r, q);
        }

        public void TexCoord4(Single[] v)
        {
            GL.TexCoord4(v);
        }

        public void TexCoord4(int s, int t, int r, int q)
        {
            GL.TexCoord4(s, t, r, q);
        }

        public void TexCoord4(Int32[] v)
        {
            GL.TexCoord4(v);
        }

        public void TexCoord4(short s, short t, short r, short q)
        {
            GL.TexCoord4(s, t, r, q);
        }

        public void TexCoord4(Int16[] v)
        {
            GL.TexCoord4(v);
        }

        public void TexCoordP1(PackedPointerType type, int coords)
        {
            GL.TexCoordP1(type, coords);
        }

        public void TexCoordP1(PackedPointerType type, uint coords)
        {
            GL.TexCoordP1(type, coords);
        }

        public void TexCoordP2(PackedPointerType type, int coords)
        {
            GL.TexCoordP2(type, coords);
        }

        public void TexCoordP2(PackedPointerType type, uint coords)
        {
            GL.TexCoordP2(type, coords);
        }

        public void TexCoordP3(PackedPointerType type, int coords)
        {
            GL.TexCoordP3(type, coords);
        }

        public void TexCoordP3(PackedPointerType type, uint coords)
        {
            GL.TexCoordP3(type, coords);
        }

        public void TexCoordP4(PackedPointerType type, int coords)
        {
            GL.TexCoordP4(type, coords);
        }

        public void TexCoordP4(PackedPointerType type, uint coords)
        {
            GL.TexCoordP4(type, coords);
        }

        public void TexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer)
        {
            GL.TexCoordPointer(size, type, stride, pointer);
        }

        public void TexCoordPointer<T3>(int size, TexCoordPointerType type, int stride, T3[] pointer)
                where T3 : struct
        {
            GL.TexCoordPointer(size, type, stride, pointer);
        }

        public void TexCoordPointer<T3>(int size, TexCoordPointerType type, int stride, T3[,] pointer)
                where T3 : struct
        {
            GL.TexCoordPointer(size, type, stride, pointer);
        }

        public void TexCoordPointer<T3>(int size, TexCoordPointerType type, int stride, T3[,,] pointer)
                where T3 : struct
        {
            GL.TexCoordPointer(size, type, stride, pointer);
        }

        public void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float param)
        {
            GL.TexEnv(target, pname, param);
        }

        public void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Single[] @params)
        {
            GL.TexEnv(target, pname, @params);
        }

        public void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, int param)
        {
            GL.TexEnv(target, pname, param);
        }

        public void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
        {
            GL.TexEnv(target, pname, @params);
        }

        public void TexGend(TextureCoordName coord, TextureGenParameter pname, double param)
        {
            GL.TexGend(coord, pname, param);
        }

        public void TexGen(TextureCoordName coord, TextureGenParameter pname, Double[] @params)
        {
            GL.TexGen(coord, pname, @params);
        }

        public void TexGen(TextureCoordName coord, TextureGenParameter pname, float param)
        {
            GL.TexGen(coord, pname, param);
        }

        public void TexGen(TextureCoordName coord, TextureGenParameter pname, Single[] @params)
        {
            GL.TexGen(coord, pname, @params);
        }

        public void TexGen(TextureCoordName coord, TextureGenParameter pname, int param)
        {
            GL.TexGen(coord, pname, param);
        }

        public void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
        {
            GL.TexGen(coord, pname, @params);
        }

        public void TexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
        }

        public void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, T7[] pixels)
                where T7 : struct
        {
            GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
        }

        public void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, T7[,] pixels)
                where T7 : struct
        {
            GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
        }

        public void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, T7[,,] pixels)
                where T7 : struct
        {
            GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
        }

        public void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, T8[] pixels)
                where T8 : struct
        {
            GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, T8[,] pixels)
                where T8 : struct
        {
            GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, T8[,,] pixels)
                where T8 : struct
        {
            GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public void TexImage2DMultisample(TextureTargetMultisample target, int samples, PixelInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            GL.TexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
        }

        public void TexImage3D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }

        public void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T9[] pixels)
                where T9 : struct
        {
            GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }

        public void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T9[,] pixels)
                where T9 : struct
        {
            GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }

        public void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T9[,,] pixels)
                where T9 : struct
        {
            GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }

        public void TexImage3DMultisample(TextureTargetMultisample target, int samples, PixelInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            GL.TexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        }

        public void TexParameter(TextureTarget target, TextureParameterName pname, float param)
        {
            GL.TexParameter(target, pname, param);
        }

        public void TexParameter(TextureTarget target, TextureParameterName pname, Single[] @params)
        {
            GL.TexParameter(target, pname, @params);
        }

        public void TexParameter(TextureTarget target, TextureParameterName pname, int param)
        {
            GL.TexParameter(target, pname, param);
        }

        public void TexParameterI(TextureTarget target, TextureParameterName pname, Int32[] @params)
        {
            GL.TexParameterI(target, pname, @params);
        }

        public void TexParameterI(TextureTarget target, TextureParameterName pname, UInt32[] @params)
        {
            GL.TexParameterI(target, pname, @params);
        }

        public void TexParameter(TextureTarget target, TextureParameterName pname, Int32[] @params)
        {
            GL.TexParameter(target, pname, @params);
        }

        public void TexStorage1D(TextureTarget1d target, int levels, SizedInternalFormat internalformat, int width)
        {
            GL.TexStorage1D(target, levels, internalformat, width);
        }

        public void TexStorage2D(TextureTarget2d target, int levels, SizedInternalFormat internalformat, int width, int height)
        {
            GL.TexStorage2D(target, levels, internalformat, width, height);
        }

        public void TexStorage2DMultisample(TextureTargetMultisample2d target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            GL.TexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
        }

        public void TexStorage3D(TextureTarget3d target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
        {
            GL.TexStorage3D(target, levels, internalformat, width, height, depth);
        }

        public void TexStorage3DMultisample(TextureTargetMultisample3d target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            GL.TexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        }

        public void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }

        public void TexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[] pixels)
                where T6 : struct
        {
            GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }

        public void TexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[,] pixels)
                where T6 : struct
        {
            GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }

        public void TexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, T6[,,] pixels)
                where T6 : struct
        {
            GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }

        public void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[] pixels)
                where T8 : struct
        {
            GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[,] pixels)
                where T8 : struct
        {
            GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T8[,,] pixels)
                where T8 : struct
        {
            GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void TexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[] pixels)
                where T10 : struct
        {
            GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public void SeparableFilter2D(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, IntPtr column)
        {
            GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
        }

        public void SeparableFilter2D<T6, T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, T6[] row, T7[] column)
                where T6 : struct
                where T7 : struct
        {
            GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
        }

        public void SeparableFilter2D<T6, T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, T6[,] row, T7[,] column)
                where T6 : struct
                where T7 : struct
        {
            GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
        }

        public void SeparableFilter2D<T6, T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, T6[,,] row, T7[,,] column)
                where T6 : struct
                where T7 : struct
        {
            GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
        }

        public void ShadeModel(ShadingModel mode)
        {
            GL.ShadeModel(mode);
        }

        public void ShaderBinary(int count, Int32[] shaders, BinaryFormat binaryformat, IntPtr binary, int length)
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary<T3>(int count, Int32[] shaders, BinaryFormat binaryformat, T3[] binary, int length)
                where T3 : struct
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary<T3>(int count, Int32[] shaders, BinaryFormat binaryformat, T3[,] binary, int length)
                where T3 : struct
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary<T3>(int count, Int32[] shaders, BinaryFormat binaryformat, T3[,,] binary, int length)
                where T3 : struct
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary(int count, UInt32[] shaders, BinaryFormat binaryformat, IntPtr binary, int length)
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary<T3>(int count, UInt32[] shaders, BinaryFormat binaryformat, T3[] binary, int length)
                where T3 : struct
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary<T3>(int count, UInt32[] shaders, BinaryFormat binaryformat, T3[,] binary, int length)
                where T3 : struct
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary<T3>(int count, UInt32[] shaders, BinaryFormat binaryformat, T3[,,] binary, int length)
                where T3 : struct
        {
            GL.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderSource(int shader, int count, String[] @string, Int32[] length)
        {
            GL.ShaderSource(shader, count, @string, length);
        }

        public void ShaderSource(uint shader, int count, String[] @string, Int32[] length)
        {
            GL.ShaderSource(shader, count, @string, length);
        }

        public void ShaderStorageBlockBinding(int program, int storageBlockIndex, int storageBlockBinding)
        {
            GL.ShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
        }

        public void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
        {
            GL.ShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
        }

        public void StencilFunc(StencilFunction func, int @ref, int mask)
        {
            GL.StencilFunc(func, @ref, mask);
        }

        public void StencilFunc(StencilFunction func, int @ref, uint mask)
        {
            GL.StencilFunc(func, @ref, mask);
        }

        public void StencilFuncSeparate(StencilFace face, StencilFunction func, int @ref, int mask)
        {
            GL.StencilFuncSeparate(face, func, @ref, mask);
        }

        public void StencilFuncSeparate(StencilFace face, StencilFunction func, int @ref, uint mask)
        {
            GL.StencilFuncSeparate(face, func, @ref, mask);
        }

        public void StencilMask(int mask)
        {
            GL.StencilMask(mask);
        }

        public void StencilMask(uint mask)
        {
            GL.StencilMask(mask);
        }

        public void StencilMaskSeparate(StencilFace face, int mask)
        {
            GL.StencilMaskSeparate(face, mask);
        }

        public void StencilMaskSeparate(StencilFace face, uint mask)
        {
            GL.StencilMaskSeparate(face, mask);
        }

        public void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
        {
            GL.StencilOp(fail, zfail, zpass);
        }

        public void StencilOpSeparate(StencilFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
        {
            GL.StencilOpSeparate(face, sfail, dpfail, dppass);
        }

        public void TexBuffer(TextureBufferTarget target, SizedInternalFormat internalformat, int buffer)
        {
            GL.TexBuffer(target, internalformat, buffer);
        }

        public void TexBuffer(TextureBufferTarget target, SizedInternalFormat internalformat, uint buffer)
        {
            GL.TexBuffer(target, internalformat, buffer);
        }

        public void TexBufferRange(TextureBufferTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, int size)
        {
            GL.TexBufferRange(target, internalformat, buffer, offset, size);
        }

        public void TexBufferRange(TextureBufferTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, IntPtr size)
        {
            GL.TexBufferRange(target, internalformat, buffer, offset, size);
        }

        public void TexBufferRange(TextureBufferTarget target, SizedInternalFormat internalformat, uint buffer, IntPtr offset, int size)
        {
            GL.TexBufferRange(target, internalformat, buffer, offset, size);
        }

        public void TexBufferRange(TextureBufferTarget target, SizedInternalFormat internalformat, uint buffer, IntPtr offset, IntPtr size)
        {
            GL.TexBufferRange(target, internalformat, buffer, offset, size);
        }

        public void TexCoord1(double s)
        {
            GL.TexCoord1(s);
        }

        public void TexCoord1(float s)
        {
            GL.TexCoord1(s);
        }

        public void TexCoord1(int s)
        {
            GL.TexCoord1(s);
        }

        public void TexCoord1(short s)
        {
            GL.TexCoord1(s);
        }

        public void TexCoord2(double s, double t)
        {
            GL.TexCoord2(s, t);
        }

        public void TexCoord2(Double[] v)
        {
            GL.TexCoord2(v);
        }

        public void TexCoord2(float s, float t)
        {
            GL.TexCoord2(s, t);
        }

        public void TexCoord2(Single[] v)
        {
            GL.TexCoord2(v);
        }

        public void TexCoord2(int s, int t)
        {
            GL.TexCoord2(s, t);
        }

        public void TexCoord2(Int32[] v)
        {
            GL.TexCoord2(v);
        }

        public void TexCoord2(short s, short t)
        {
            GL.TexCoord2(s, t);
        }

        public void TexCoord2(Int16[] v)
        {
            GL.TexCoord2(v);
        }

        public void TexCoord3(double s, double t, double r)
        {
            GL.TexCoord3(s, t, r);
        }

        public void TexCoord3(Double[] v)
        {
            GL.TexCoord3(v);
        }

        public void TexCoord3(float s, float t, float r)
        {
            GL.TexCoord3(s, t, r);
        }

        public void TexCoord3(Single[] v)
        {
            GL.TexCoord3(v);
        }

        public void TexCoord3(int s, int t, int r)
        {
            GL.TexCoord3(s, t, r);
        }

        public void TexCoord3(Int32[] v)
        {
            GL.TexCoord3(v);
        }

        public void Rect(int x1, int y1, int x2, int y2)
        {
            GL.Rect(x1, y1, x2, y2);
        }

        public void Rect(Int32[] v1, Int32[] v2)
        {
            GL.Rect(v1, v2);
        }

        public void Rects(short x1, short y1, short x2, short y2)
        {
            GL.Rects(x1, y1, x2, y2);
        }

        public void Rect(Int16[] v1, Int16[] v2)
        {
            GL.Rect(v1, v2);
        }

        public void ReleaseShaderCompiler()
        {
            GL.ReleaseShaderCompiler();
        }

        public void RenderbufferStorage(RenderbufferTarget target, RenderbufferStorage internalformat, int width, int height)
        {
            GL.RenderbufferStorage(target, internalformat, width, height);
        }

        public void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, RenderbufferStorage internalformat, int width, int height)
        {
            GL.RenderbufferStorageMultisample(target, samples, internalformat, width, height);
        }

        public int RenderMode(RenderingMode mode)
        {
            return GL.RenderMode(mode);
        }

        public void ResetHistogram(HistogramTarget target)
        {
            GL.ResetHistogram(target);
        }

        public void ResetMinmax(MinmaxTarget target)
        {
            GL.ResetMinmax(target);
        }

        public void ResumeTransformFeedback()
        {
            GL.ResumeTransformFeedback();
        }

        public void Rotate(double angle, double x, double y, double z)
        {
            GL.Rotate(angle, x, y, z);
        }

        public void Rotate(float angle, float x, float y, float z)
        {
            GL.Rotate(angle, x, y, z);
        }

        public void SampleCoverage(float value, bool invert)
        {
            GL.SampleCoverage(value, invert);
        }

        public void SampleMask(int maskNumber, int mask)
        {
            GL.SampleMask(maskNumber, mask);
        }

        public void SampleMask(uint maskNumber, uint mask)
        {
            GL.SampleMask(maskNumber, mask);
        }

        public void SamplerParameter(int sampler, SamplerParameterName pname, float param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void SamplerParameter(uint sampler, SamplerParameterName pname, float param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void SamplerParameter(int sampler, SamplerParameterName pname, Single[] param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void SamplerParameter(uint sampler, SamplerParameterName pname, Single[] param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void SamplerParameter(int sampler, SamplerParameterName pname, int param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void SamplerParameter(uint sampler, SamplerParameterName pname, int param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void SamplerParameterI(int sampler, SamplerParameterName pname, Int32[] param)
        {
            GL.SamplerParameterI(sampler, pname, param);
        }

        public void SamplerParameterI(uint sampler, SamplerParameterName pname, Int32[] param)
        {
            GL.SamplerParameterI(sampler, pname, param);
        }

        public void SamplerParameterI(uint sampler, SamplerParameterName pname, UInt32[] param)
        {
            GL.SamplerParameterI(sampler, pname, param);
        }

        public void SamplerParameter(int sampler, SamplerParameterName pname, Int32[] param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void SamplerParameter(uint sampler, SamplerParameterName pname, Int32[] param)
        {
            GL.SamplerParameter(sampler, pname, param);
        }

        public void Scale(double x, double y, double z)
        {
            GL.Scale(x, y, z);
        }

        public void Scale(float x, float y, float z)
        {
            GL.Scale(x, y, z);
        }

        public void Scissor(int x, int y, int width, int height)
        {
            GL.Scissor(x, y, width, height);
        }

        public void ScissorArray(int first, int count, Int32[] v)
        {
            GL.ScissorArray(first, count, v);
        }

        public void ScissorArray(uint first, int count, Int32[] v)
        {
            GL.ScissorArray(first, count, v);
        }

        public void ScissorIndexed(int index, int left, int bottom, int width, int height)
        {
            GL.ScissorIndexed(index, left, bottom, width, height);
        }

        public void ScissorIndexed(uint index, int left, int bottom, int width, int height)
        {
            GL.ScissorIndexed(index, left, bottom, width, height);
        }

        public void ScissorIndexed(int index, Int32[] v)
        {
            GL.ScissorIndexed(index, v);
        }

        public void ScissorIndexed(uint index, Int32[] v)
        {
            GL.ScissorIndexed(index, v);
        }

        public void SecondaryColor3(sbyte red, sbyte green, sbyte blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(SByte[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColor3(double red, double green, double blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(Double[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColor3(float red, float green, float blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(Single[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColor3(int red, int green, int blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(Int32[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColor3(short red, short green, short blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(Int16[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColor3(byte red, byte green, byte blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(Byte[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColor3(uint red, uint green, uint blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(UInt32[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColor3(ushort red, ushort green, ushort blue)
        {
            GL.SecondaryColor3(red, green, blue);
        }

        public void SecondaryColor3(UInt16[] v)
        {
            GL.SecondaryColor3(v);
        }

        public void SecondaryColorP3(PackedPointerType type, int color)
        {
            GL.SecondaryColorP3(type, color);
        }

        public void SecondaryColorP3(PackedPointerType type, uint color)
        {
            GL.SecondaryColorP3(type, color);
        }

        public void SecondaryColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
        {
            GL.SecondaryColorPointer(size, type, stride, pointer);
        }

        public void SecondaryColorPointer<T3>(int size, ColorPointerType type, int stride, T3[] pointer)
                where T3 : struct
        {
            GL.SecondaryColorPointer(size, type, stride, pointer);
        }

        public void SecondaryColorPointer<T3>(int size, ColorPointerType type, int stride, T3[,] pointer)
                where T3 : struct
        {
            GL.SecondaryColorPointer(size, type, stride, pointer);
        }

        public void SecondaryColorPointer<T3>(int size, ColorPointerType type, int stride, T3[,,] pointer)
                where T3 : struct
        {
            GL.SecondaryColorPointer(size, type, stride, pointer);
        }

        public void SelectBuffer(int size, Int32[] buffer)
        {
            GL.SelectBuffer(size, buffer);
        }

        public void SelectBuffer(int size, UInt32[] buffer)
        {
            GL.SelectBuffer(size, buffer);
        }

        public void ProgramUniformMatrix3x4(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix3x4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3x4(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix3x4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x2(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix4x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x2(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix4x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x2(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix4x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x2(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix4x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x3(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix4x3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x3(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix4x3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x3(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix4x3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix4x3(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix4x3(program, location, count, transpose, value);
        }

        public void ProvokingVertex(ProvokingVertexMode mode)
        {
            GL.ProvokingVertex(mode);
        }

        public void PushAttrib(AttribMask mask)
        {
            GL.PushAttrib(mask);
        }

        public void PushClientAttrib(ClientAttribMask mask)
        {
            GL.PushClientAttrib(mask);
        }

        public void PushDebugGroup(DebugSourceExternal source, int id, int length, string message)
        {
            GL.PushDebugGroup(source, id, length, message);
        }

        public void PushDebugGroup(DebugSourceExternal source, uint id, int length, string message)
        {
            GL.PushDebugGroup(source, id, length, message);
        }

        public void PushMatrix()
        {
            GL.PushMatrix();
        }

        public void PushName(int name)
        {
            GL.PushName(name);
        }

        public void PushName(uint name)
        {
            GL.PushName(name);
        }

        public void QueryCounter(int id, QueryCounterTarget target)
        {
            GL.QueryCounter(id, target);
        }

        public void QueryCounter(uint id, QueryCounterTarget target)
        {
            GL.QueryCounter(id, target);
        }

        public void RasterPos2(double x, double y)
        {
            GL.RasterPos2(x, y);
        }

        public void RasterPos2(Double[] v)
        {
            GL.RasterPos2(v);
        }

        public void RasterPos2(float x, float y)
        {
            GL.RasterPos2(x, y);
        }

        public void RasterPos2(Single[] v)
        {
            GL.RasterPos2(v);
        }

        public void RasterPos2(int x, int y)
        {
            GL.RasterPos2(x, y);
        }

        public void RasterPos2(Int32[] v)
        {
            GL.RasterPos2(v);
        }

        public void RasterPos2(short x, short y)
        {
            GL.RasterPos2(x, y);
        }

        public void RasterPos2(Int16[] v)
        {
            GL.RasterPos2(v);
        }

        public void RasterPos3(double x, double y, double z)
        {
            GL.RasterPos3(x, y, z);
        }

        public void RasterPos3(Double[] v)
        {
            GL.RasterPos3(v);
        }

        public void RasterPos3(float x, float y, float z)
        {
            GL.RasterPos3(x, y, z);
        }

        public void RasterPos3(Single[] v)
        {
            GL.RasterPos3(v);
        }

        public void RasterPos3(int x, int y, int z)
        {
            GL.RasterPos3(x, y, z);
        }

        public void RasterPos3(Int32[] v)
        {
            GL.RasterPos3(v);
        }

        public void RasterPos3(short x, short y, short z)
        {
            GL.RasterPos3(x, y, z);
        }

        public void RasterPos3(Int16[] v)
        {
            GL.RasterPos3(v);
        }

        public void RasterPos4(double x, double y, double z, double w)
        {
            GL.RasterPos4(x, y, z, w);
        }

        public void RasterPos4(Double[] v)
        {
            GL.RasterPos4(v);
        }

        public void RasterPos4(float x, float y, float z, float w)
        {
            GL.RasterPos4(x, y, z, w);
        }

        public void RasterPos4(Single[] v)
        {
            GL.RasterPos4(v);
        }

        public void RasterPos4(int x, int y, int z, int w)
        {
            GL.RasterPos4(x, y, z, w);
        }

        public void RasterPos4(Int32[] v)
        {
            GL.RasterPos4(v);
        }

        public void RasterPos4(short x, short y, short z, short w)
        {
            GL.RasterPos4(x, y, z, w);
        }

        public void RasterPos4(Int16[] v)
        {
            GL.RasterPos4(v);
        }

        public void ReadBuffer(ReadBufferMode src)
        {
            GL.ReadBuffer(src);
        }

        public void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
        {
            GL.ReadnPixels(x, y, width, height, format, type, bufSize, data);
        }

        public void ReadnPixels<T7>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, T7[] data)
                where T7 : struct
        {
            GL.ReadnPixels(x, y, width, height, format, type, bufSize, data);
        }

        public void ReadnPixels<T7>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, T7[,] data)
                where T7 : struct
        {
            GL.ReadnPixels(x, y, width, height, format, type, bufSize, data);
        }

        public void ReadnPixels<T7>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, T7[,,] data)
                where T7 : struct
        {
            GL.ReadnPixels(x, y, width, height, format, type, bufSize, data);
        }

        public void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.ReadPixels(x, y, width, height, format, type, pixels);
        }

        public void ReadPixels<T6>(int x, int y, int width, int height, PixelFormat format, PixelType type, T6[] pixels)
                where T6 : struct
        {
            GL.ReadPixels(x, y, width, height, format, type, pixels);
        }

        public void ReadPixels<T6>(int x, int y, int width, int height, PixelFormat format, PixelType type, T6[,] pixels)
                where T6 : struct
        {
            GL.ReadPixels(x, y, width, height, format, type, pixels);
        }

        public void ReadPixels<T6>(int x, int y, int width, int height, PixelFormat format, PixelType type, T6[,,] pixels)
                where T6 : struct
        {
            GL.ReadPixels(x, y, width, height, format, type, pixels);
        }

        public void Rect(double x1, double y1, double x2, double y2)
        {
            GL.Rect(x1, y1, x2, y2);
        }

        public void Rect(Double[] v1, Double[] v2)
        {
            GL.Rect(v1, v2);
        }

        public void Rect(float x1, float y1, float x2, float y2)
        {
            GL.Rect(x1, y1, x2, y2);
        }

        public void Rect(Single[] v1, Single[] v2)
        {
            GL.Rect(v1, v2);
        }

        public void ProgramUniform2(uint program, int location, int count, Int32[] value)
        {
            GL.ProgramUniform2(program, location, count, value);
        }

        public void ProgramUniform2(uint program, int location, uint v0, uint v1)
        {
            GL.ProgramUniform2(program, location, v0, v1);
        }

        public void ProgramUniform2(uint program, int location, int count, UInt32[] value)
        {
            GL.ProgramUniform2(program, location, count, value);
        }

        public void ProgramUniform3(int program, int location, double v0, double v1, double v2)
        {
            GL.ProgramUniform3(program, location, v0, v1, v2);
        }

        public void ProgramUniform3(uint program, int location, double v0, double v1, double v2)
        {
            GL.ProgramUniform3(program, location, v0, v1, v2);
        }

        public void ProgramUniform3(int program, int location, int count, Double[] value)
        {
            GL.ProgramUniform3(program, location, count, value);
        }

        public void ProgramUniform3(uint program, int location, int count, Double[] value)
        {
            GL.ProgramUniform3(program, location, count, value);
        }

        public void ProgramUniform3(int program, int location, float v0, float v1, float v2)
        {
            GL.ProgramUniform3(program, location, v0, v1, v2);
        }

        public void ProgramUniform3(uint program, int location, float v0, float v1, float v2)
        {
            GL.ProgramUniform3(program, location, v0, v1, v2);
        }

        public void ProgramUniform3(int program, int location, int count, Single[] value)
        {
            GL.ProgramUniform3(program, location, count, value);
        }

        public void ProgramUniform3(uint program, int location, int count, Single[] value)
        {
            GL.ProgramUniform3(program, location, count, value);
        }

        public void ProgramUniform3(int program, int location, int v0, int v1, int v2)
        {
            GL.ProgramUniform3(program, location, v0, v1, v2);
        }

        public void ProgramUniform3(uint program, int location, int v0, int v1, int v2)
        {
            GL.ProgramUniform3(program, location, v0, v1, v2);
        }

        public void ProgramUniform3(int program, int location, int count, Int32[] value)
        {
            GL.ProgramUniform3(program, location, count, value);
        }

        public void ProgramUniform3(uint program, int location, int count, Int32[] value)
        {
            GL.ProgramUniform3(program, location, count, value);
        }

        public void ProgramUniform3(uint program, int location, uint v0, uint v1, uint v2)
        {
            GL.ProgramUniform3(program, location, v0, v1, v2);
        }

        public void ProgramUniform3(uint program, int location, int count, UInt32[] value)
        {
            GL.ProgramUniform3(program, location, count, value);
        }

        public void ProgramUniform4(int program, int location, double v0, double v1, double v2, double v3)
        {
            GL.ProgramUniform4(program, location, v0, v1, v2, v3);
        }

        public void ProgramUniform4(uint program, int location, double v0, double v1, double v2, double v3)
        {
            GL.ProgramUniform4(program, location, v0, v1, v2, v3);
        }

        public void ProgramUniform4(int program, int location, int count, Double[] value)
        {
            GL.ProgramUniform4(program, location, count, value);
        }

        public void ProgramUniform4(uint program, int location, int count, Double[] value)
        {
            GL.ProgramUniform4(program, location, count, value);
        }

        public void ProgramUniform4(int program, int location, float v0, float v1, float v2, float v3)
        {
            GL.ProgramUniform4(program, location, v0, v1, v2, v3);
        }

        public void ProgramUniform4(uint program, int location, float v0, float v1, float v2, float v3)
        {
            GL.ProgramUniform4(program, location, v0, v1, v2, v3);
        }

        public void ProgramUniform4(int program, int location, int count, Single[] value)
        {
            GL.ProgramUniform4(program, location, count, value);
        }

        public void ProgramUniform4(uint program, int location, int count, Single[] value)
        {
            GL.ProgramUniform4(program, location, count, value);
        }

        public void ProgramUniform4(int program, int location, int v0, int v1, int v2, int v3)
        {
            GL.ProgramUniform4(program, location, v0, v1, v2, v3);
        }

        public void ProgramUniform4(uint program, int location, int v0, int v1, int v2, int v3)
        {
            GL.ProgramUniform4(program, location, v0, v1, v2, v3);
        }

        public void ProgramUniform4(int program, int location, int count, Int32[] value)
        {
            GL.ProgramUniform4(program, location, count, value);
        }

        public void ProgramUniform4(uint program, int location, int count, Int32[] value)
        {
            GL.ProgramUniform4(program, location, count, value);
        }

        public void ProgramUniform4(uint program, int location, uint v0, uint v1, uint v2, uint v3)
        {
            GL.ProgramUniform4(program, location, v0, v1, v2, v3);
        }

        public void ProgramUniform4(uint program, int location, int count, UInt32[] value)
        {
            GL.ProgramUniform4(program, location, count, value);
        }

        public void ProgramUniformMatrix2(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x3(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix2x3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x3(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix2x3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x3(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix2x3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x3(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix2x3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x4(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix2x4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x4(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix2x4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x4(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix2x4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix2x4(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix2x4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix3(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3x2(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix3x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3x2(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix3x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3x2(int program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix3x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3x2(uint program, int location, int count, bool transpose, Single[] value)
        {
            GL.ProgramUniformMatrix3x2(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3x4(int program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix3x4(program, location, count, transpose, value);
        }

        public void ProgramUniformMatrix3x4(uint program, int location, int count, bool transpose, Double[] value)
        {
            GL.ProgramUniformMatrix3x4(program, location, count, transpose, value);
        }

        public void ObjectPtrLabel<T0>(T0[] ptr, int length, string label)
                where T0 : struct
        {
            GL.ObjectPtrLabel(ptr, length, label);
        }

        public void ObjectPtrLabel<T0>(T0[,] ptr, int length, string label)
                where T0 : struct
        {
            GL.ObjectPtrLabel(ptr, length, label);
        }

        public void ObjectPtrLabel<T0>(T0[,,] ptr, int length, string label)
                where T0 : struct
        {
            GL.ObjectPtrLabel(ptr, length, label);
        }

        public void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
        {
            GL.Ortho(left, right, bottom, top, zNear, zFar);
        }

        public void PassThrough(float token)
        {
            GL.PassThrough(token);
        }

        public void PatchParameter(PatchParameterFloat pname, Single[] values)
        {
            GL.PatchParameter(pname, values);
        }

        public void PatchParameter(PatchParameterInt pname, int value)
        {
            GL.PatchParameter(pname, value);
        }

        public void PauseTransformFeedback()
        {
            GL.PauseTransformFeedback();
        }

        public void PixelMap(PixelMap map, int mapsize, Single[] values)
        {
            GL.PixelMap(map, mapsize, values);
        }

        public void PixelMap(PixelMap map, int mapsize, Int32[] values)
        {
            GL.PixelMap(map, mapsize, values);
        }

        public void PixelMap(PixelMap map, int mapsize, UInt32[] values)
        {
            GL.PixelMap(map, mapsize, values);
        }

        public void PixelMap(PixelMap map, int mapsize, Int16[] values)
        {
            GL.PixelMap(map, mapsize, values);
        }

        public void PixelMap(PixelMap map, int mapsize, UInt16[] values)
        {
            GL.PixelMap(map, mapsize, values);
        }

        public void PixelMapx(OesFixedPoint map, int size, Int32[] values)
        {
            GL.PixelMapx(map, size, values);
        }

        public void PixelStore(PixelStoreParameter pname, float param)
        {
            GL.PixelStore(pname, param);
        }

        public void PixelStore(PixelStoreParameter pname, int param)
        {
            GL.PixelStore(pname, param);
        }

        public void PixelStorex(OesFixedPoint pname, int param)
        {
            GL.PixelStorex(pname, param);
        }

        public void PixelTransfer(PixelTransferParameter pname, float param)
        {
            GL.PixelTransfer(pname, param);
        }

        public void PixelTransfer(PixelTransferParameter pname, int param)
        {
            GL.PixelTransfer(pname, param);
        }

        public void PixelZoom(float xfactor, float yfactor)
        {
            GL.PixelZoom(xfactor, yfactor);
        }

        public void PointParameter(PointParameterName pname, float param)
        {
            GL.PointParameter(pname, param);
        }

        public void PointParameter(PointParameterName pname, Single[] @params)
        {
            GL.PointParameter(pname, @params);
        }

        public void PointParameter(PointParameterName pname, int param)
        {
            GL.PointParameter(pname, param);
        }

        public void PointParameter(PointParameterName pname, Int32[] @params)
        {
            GL.PointParameter(pname, @params);
        }

        public void PointSize(float size)
        {
            GL.PointSize(size);
        }

        public void PolygonMode(MaterialFace face, PolygonMode mode)
        {
            GL.PolygonMode(face, mode);
        }

        public void PolygonOffset(float factor, float units)
        {
            GL.PolygonOffset(factor, units);
        }

        public void PolygonStipple(Byte[] mask)
        {
            GL.PolygonStipple(mask);
        }

        public void PopAttrib()
        {
            GL.PopAttrib();
        }

        public void PopClientAttrib()
        {
            GL.PopClientAttrib();
        }

        public void PopDebugGroup()
        {
            GL.PopDebugGroup();
        }

        public void PopMatrix()
        {
            GL.PopMatrix();
        }

        public void PopName()
        {
            GL.PopName();
        }

        public void PrimitiveRestartIndex(int index)
        {
            GL.PrimitiveRestartIndex(index);
        }

        public void PrimitiveRestartIndex(uint index)
        {
            GL.PrimitiveRestartIndex(index);
        }

        public void PrioritizeTextures(int n, Int32[] textures, Single[] priorities)
        {
            GL.PrioritizeTextures(n, textures, priorities);
        }

        public void PrioritizeTextures(int n, UInt32[] textures, Single[] priorities)
        {
            GL.PrioritizeTextures(n, textures, priorities);
        }

        public void ProgramBinary(int program, BinaryFormat binaryFormat, IntPtr binary, int length)
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramBinary<T2>(int program, BinaryFormat binaryFormat, T2[] binary, int length)
                where T2 : struct
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramBinary<T2>(int program, BinaryFormat binaryFormat, T2[,] binary, int length)
                where T2 : struct
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramBinary<T2>(int program, BinaryFormat binaryFormat, T2[,,] binary, int length)
                where T2 : struct
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramBinary(uint program, BinaryFormat binaryFormat, IntPtr binary, int length)
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramBinary<T2>(uint program, BinaryFormat binaryFormat, T2[] binary, int length)
                where T2 : struct
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramBinary<T2>(uint program, BinaryFormat binaryFormat, T2[,] binary, int length)
                where T2 : struct
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramBinary<T2>(uint program, BinaryFormat binaryFormat, T2[,,] binary, int length)
                where T2 : struct
        {
            GL.ProgramBinary(program, binaryFormat, binary, length);
        }

        public void ProgramParameter(int program, ProgramParameterName pname, int value)
        {
            GL.ProgramParameter(program, pname, value);
        }

        public void ProgramParameter(uint program, ProgramParameterName pname, int value)
        {
            GL.ProgramParameter(program, pname, value);
        }

        public void ProgramUniform1(int program, int location, double v0)
        {
            GL.ProgramUniform1(program, location, v0);
        }

        public void ProgramUniform1(uint program, int location, double v0)
        {
            GL.ProgramUniform1(program, location, v0);
        }

        public void ProgramUniform1(int program, int location, float v0)
        {
            GL.ProgramUniform1(program, location, v0);
        }

        public void ProgramUniform1(uint program, int location, float v0)
        {
            GL.ProgramUniform1(program, location, v0);
        }

        public void ProgramUniform1(int program, int location, int v0)
        {
            GL.ProgramUniform1(program, location, v0);
        }

        public void ProgramUniform1(uint program, int location, int v0)
        {
            GL.ProgramUniform1(program, location, v0);
        }

        public void ProgramUniform1(uint program, int location, uint v0)
        {
            GL.ProgramUniform1(program, location, v0);
        }

        public void ProgramUniform2(int program, int location, double v0, double v1)
        {
            GL.ProgramUniform2(program, location, v0, v1);
        }

        public void ProgramUniform2(uint program, int location, double v0, double v1)
        {
            GL.ProgramUniform2(program, location, v0, v1);
        }

        public void ProgramUniform2(int program, int location, int count, Double[] value)
        {
            GL.ProgramUniform2(program, location, count, value);
        }

        public void ProgramUniform2(uint program, int location, int count, Double[] value)
        {
            GL.ProgramUniform2(program, location, count, value);
        }

        public void ProgramUniform2(int program, int location, float v0, float v1)
        {
            GL.ProgramUniform2(program, location, v0, v1);
        }

        public void ProgramUniform2(uint program, int location, float v0, float v1)
        {
            GL.ProgramUniform2(program, location, v0, v1);
        }

        public void ProgramUniform2(int program, int location, int count, Single[] value)
        {
            GL.ProgramUniform2(program, location, count, value);
        }

        public void ProgramUniform2(uint program, int location, int count, Single[] value)
        {
            GL.ProgramUniform2(program, location, count, value);
        }

        public void ProgramUniform2(int program, int location, int v0, int v1)
        {
            GL.ProgramUniform2(program, location, v0, v1);
        }

        public void ProgramUniform2(uint program, int location, int v0, int v1)
        {
            GL.ProgramUniform2(program, location, v0, v1);
        }

        public void ProgramUniform2(int program, int location, int count, Int32[] value)
        {
            GL.ProgramUniform2(program, location, count, value);
        }

        public void MultMatrix(Single[] m)
        {
            GL.MultMatrix(m);
        }

        public void MultTransposeMatrix(Double[] m)
        {
            GL.MultTransposeMatrix(m);
        }

        public void MultTransposeMatrix(Single[] m)
        {
            GL.MultTransposeMatrix(m);
        }

        public void NamedBufferData(int buffer, int size, IntPtr data, BufferUsageHint usage)
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferData<T2>(int buffer, int size, T2[] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferData<T2>(int buffer, int size, T2[,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferData<T2>(int buffer, int size, T2[,,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferData(uint buffer, int size, IntPtr data, BufferUsageHint usage)
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferData<T2>(uint buffer, int size, T2[] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferData<T2>(uint buffer, int size, T2[,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferData<T2>(uint buffer, int size, T2[,,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.NamedBufferData(buffer, size, data, usage);
        }

        public void NamedBufferStorage(int buffer, int size, IntPtr data, BufferStorageFlags flags)
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferStorage<T2>(int buffer, int size, T2[] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferStorage<T2>(int buffer, int size, T2[,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferStorage<T2>(int buffer, int size, T2[,,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferStorage(uint buffer, int size, IntPtr data, BufferStorageFlags flags)
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferStorage<T2>(uint buffer, int size, T2[] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferStorage<T2>(uint buffer, int size, T2[,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferStorage<T2>(uint buffer, int size, T2[,,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.NamedBufferStorage(buffer, size, data, flags);
        }

        public void NamedBufferSubData(int buffer, IntPtr offset, int size, IntPtr data)
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedBufferSubData<T3>(int buffer, IntPtr offset, int size, T3[] data)
                where T3 : struct
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedBufferSubData<T3>(int buffer, IntPtr offset, int size, T3[,] data)
                where T3 : struct
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedBufferSubData<T3>(int buffer, IntPtr offset, int size, T3[,,] data)
                where T3 : struct
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedBufferSubData(uint buffer, IntPtr offset, int size, IntPtr data)
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedBufferSubData<T3>(uint buffer, IntPtr offset, int size, T3[] data)
                where T3 : struct
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedBufferSubData<T3>(uint buffer, IntPtr offset, int size, T3[,] data)
                where T3 : struct
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedBufferSubData<T3>(uint buffer, IntPtr offset, int size, T3[,,] data)
                where T3 : struct
        {
            GL.NamedBufferSubData(buffer, offset, size, data);
        }

        public void NamedFramebufferDrawBuffer(int framebuffer, DrawBufferMode buf)
        {
            GL.NamedFramebufferDrawBuffer(framebuffer, buf);
        }

        public void NamedFramebufferDrawBuffer(uint framebuffer, DrawBufferMode buf)
        {
            GL.NamedFramebufferDrawBuffer(framebuffer, buf);
        }

        public void NamedFramebufferDrawBuffers(int framebuffer, int n, DrawBuffersEnum[] bufs)
        {
            GL.NamedFramebufferDrawBuffers(framebuffer, n, bufs);
        }

        public void NamedFramebufferDrawBuffers(uint framebuffer, int n, DrawBuffersEnum[] bufs)
        {
            GL.NamedFramebufferDrawBuffers(framebuffer, n, bufs);
        }

        public void NamedFramebufferParameter(int framebuffer, FramebufferDefaultParameter pname, int param)
        {
            GL.NamedFramebufferParameter(framebuffer, pname, param);
        }

        public void NamedFramebufferParameter(uint framebuffer, FramebufferDefaultParameter pname, int param)
        {
            GL.NamedFramebufferParameter(framebuffer, pname, param);
        }

        public void NamedFramebufferReadBuffer(int framebuffer, ReadBufferMode src)
        {
            GL.NamedFramebufferReadBuffer(framebuffer, src);
        }

        public void NamedFramebufferReadBuffer(uint framebuffer, ReadBufferMode src)
        {
            GL.NamedFramebufferReadBuffer(framebuffer, src);
        }

        public void NamedFramebufferRenderbuffer(int framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer)
        {
            GL.NamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
        }

        public void NamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
        {
            GL.NamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
        }

        public void NamedFramebufferTexture(int framebuffer, FramebufferAttachment attachment, int texture, int level)
        {
            GL.NamedFramebufferTexture(framebuffer, attachment, texture, level);
        }

        public void NamedFramebufferTexture(uint framebuffer, FramebufferAttachment attachment, uint texture, int level)
        {
            GL.NamedFramebufferTexture(framebuffer, attachment, texture, level);
        }

        public void NamedFramebufferTextureLayer(int framebuffer, FramebufferAttachment attachment, int texture, int level, int layer)
        {
            GL.NamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
        }

        public void NamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer)
        {
            GL.NamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
        }

        public void NamedRenderbufferStorage(int renderbuffer, RenderbufferStorage internalformat, int width, int height)
        {
            GL.NamedRenderbufferStorage(renderbuffer, internalformat, width, height);
        }

        public void NamedRenderbufferStorage(uint renderbuffer, RenderbufferStorage internalformat, int width, int height)
        {
            GL.NamedRenderbufferStorage(renderbuffer, internalformat, width, height);
        }

        public void NamedRenderbufferStorageMultisample(int renderbuffer, int samples, RenderbufferStorage internalformat, int width, int height)
        {
            GL.NamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
        }

        public void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, RenderbufferStorage internalformat, int width, int height)
        {
            GL.NamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
        }

        public void NewList(int list, ListMode mode)
        {
            GL.NewList(list, mode);
        }

        public void NewList(uint list, ListMode mode)
        {
            GL.NewList(list, mode);
        }

        public void Normal3(byte nx, byte ny, byte nz)
        {
            GL.Normal3(nx, ny, nz);
        }

        public void Normal3(sbyte nx, sbyte ny, sbyte nz)
        {
            GL.Normal3(nx, ny, nz);
        }

        public void Normal3(Byte[] v)
        {
            GL.Normal3(v);
        }

        public void Normal3(SByte[] v)
        {
            GL.Normal3(v);
        }

        public void Normal3(double nx, double ny, double nz)
        {
            GL.Normal3(nx, ny, nz);
        }

        public void Normal3(Double[] v)
        {
            GL.Normal3(v);
        }

        public void Normal3(float nx, float ny, float nz)
        {
            GL.Normal3(nx, ny, nz);
        }

        public void Normal3(Single[] v)
        {
            GL.Normal3(v);
        }

        public void Normal3(int nx, int ny, int nz)
        {
            GL.Normal3(nx, ny, nz);
        }

        public void Normal3(Int32[] v)
        {
            GL.Normal3(v);
        }

        public void Normal3(short nx, short ny, short nz)
        {
            GL.Normal3(nx, ny, nz);
        }

        public void Normal3(Int16[] v)
        {
            GL.Normal3(v);
        }

        public void NormalP3(PackedPointerType type, int coords)
        {
            GL.NormalP3(type, coords);
        }

        public void NormalP3(PackedPointerType type, uint coords)
        {
            GL.NormalP3(type, coords);
        }

        public void NormalPointer(NormalPointerType type, int stride, IntPtr pointer)
        {
            GL.NormalPointer(type, stride, pointer);
        }

        public void NormalPointer<T2>(NormalPointerType type, int stride, T2[] pointer)
                where T2 : struct
        {
            GL.NormalPointer(type, stride, pointer);
        }

        public void NormalPointer<T2>(NormalPointerType type, int stride, T2[,] pointer)
                where T2 : struct
        {
            GL.NormalPointer(type, stride, pointer);
        }

        public void NormalPointer<T2>(NormalPointerType type, int stride, T2[,,] pointer)
                where T2 : struct
        {
            GL.NormalPointer(type, stride, pointer);
        }

        public void ObjectLabel(ObjectLabelIdentifier identifier, int name, int length, string label)
        {
            GL.ObjectLabel(identifier, name, length, label);
        }

        public void ObjectLabel(ObjectLabelIdentifier identifier, uint name, int length, string label)
        {
            GL.ObjectLabel(identifier, name, length, label);
        }

        public void ObjectPtrLabel(IntPtr ptr, int length, string label)
        {
            GL.ObjectPtrLabel(ptr, length, label);
        }

        public void MultiDrawElementsBaseVertex(PrimitiveType mode, Int32[] count, DrawElementsType type, IntPtr indices, int drawcount, Int32[] basevertex)
        {
            GL.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
        }

        public void MultiDrawElementsBaseVertex<T3>(PrimitiveType mode, Int32[] count, DrawElementsType type, T3[] indices, int drawcount, Int32[] basevertex)
                where T3 : struct
        {
            GL.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
        }

        public void MultiDrawElementsBaseVertex<T3>(PrimitiveType mode, Int32[] count, DrawElementsType type, T3[,] indices, int drawcount, Int32[] basevertex)
                where T3 : struct
        {
            GL.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
        }

        public void MultiDrawElementsBaseVertex<T3>(PrimitiveType mode, Int32[] count, DrawElementsType type, T3[,,] indices, int drawcount, Int32[] basevertex)
                where T3 : struct
        {
            GL.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
        }

        public void MultiDrawElementsIndirect(All mode, All type, IntPtr indirect, int drawcount, int stride)
        {
            GL.MultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
        }

        public void MultiDrawElementsIndirect<T2>(All mode, All type, T2[] indirect, int drawcount, int stride)
                where T2 : struct
        {
            GL.MultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
        }

        public void MultiDrawElementsIndirect<T2>(All mode, All type, T2[,] indirect, int drawcount, int stride)
                where T2 : struct
        {
            GL.MultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
        }

        public void MultiDrawElementsIndirect<T2>(All mode, All type, T2[,,] indirect, int drawcount, int stride)
                where T2 : struct
        {
            GL.MultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
        }

        public void MultiTexCoord1(TextureUnit target, double s)
        {
            GL.MultiTexCoord1(target, s);
        }

        public void MultiTexCoord1(TextureUnit target, float s)
        {
            GL.MultiTexCoord1(target, s);
        }

        public void MultiTexCoord1(TextureUnit target, int s)
        {
            GL.MultiTexCoord1(target, s);
        }

        public void MultiTexCoord1(TextureUnit target, short s)
        {
            GL.MultiTexCoord1(target, s);
        }

        public void MultiTexCoord2(TextureUnit target, double s, double t)
        {
            GL.MultiTexCoord2(target, s, t);
        }

        public void MultiTexCoord2(TextureUnit target, Double[] v)
        {
            GL.MultiTexCoord2(target, v);
        }

        public void MultiTexCoord2(TextureUnit target, float s, float t)
        {
            GL.MultiTexCoord2(target, s, t);
        }

        public void MultiTexCoord2(TextureUnit target, Single[] v)
        {
            GL.MultiTexCoord2(target, v);
        }

        public void MultiTexCoord2(TextureUnit target, int s, int t)
        {
            GL.MultiTexCoord2(target, s, t);
        }

        public void MultiTexCoord2(TextureUnit target, Int32[] v)
        {
            GL.MultiTexCoord2(target, v);
        }

        public void MultiTexCoord2(TextureUnit target, short s, short t)
        {
            GL.MultiTexCoord2(target, s, t);
        }

        public void MultiTexCoord2(TextureUnit target, Int16[] v)
        {
            GL.MultiTexCoord2(target, v);
        }

        public void MultiTexCoord3(TextureUnit target, double s, double t, double r)
        {
            GL.MultiTexCoord3(target, s, t, r);
        }

        public void MultiTexCoord3(TextureUnit target, Double[] v)
        {
            GL.MultiTexCoord3(target, v);
        }

        public void MultiTexCoord3(TextureUnit target, float s, float t, float r)
        {
            GL.MultiTexCoord3(target, s, t, r);
        }

        public void MultiTexCoord3(TextureUnit target, Single[] v)
        {
            GL.MultiTexCoord3(target, v);
        }

        public void MultiTexCoord3(TextureUnit target, int s, int t, int r)
        {
            GL.MultiTexCoord3(target, s, t, r);
        }

        public void MultiTexCoord3(TextureUnit target, Int32[] v)
        {
            GL.MultiTexCoord3(target, v);
        }

        public void MultiTexCoord3(TextureUnit target, short s, short t, short r)
        {
            GL.MultiTexCoord3(target, s, t, r);
        }

        public void MultiTexCoord3(TextureUnit target, Int16[] v)
        {
            GL.MultiTexCoord3(target, v);
        }

        public void MultiTexCoord4(TextureUnit target, double s, double t, double r, double q)
        {
            GL.MultiTexCoord4(target, s, t, r, q);
        }

        public void MultiTexCoord4(TextureUnit target, Double[] v)
        {
            GL.MultiTexCoord4(target, v);
        }

        public void MultiTexCoord4(TextureUnit target, float s, float t, float r, float q)
        {
            GL.MultiTexCoord4(target, s, t, r, q);
        }

        public void MultiTexCoord4(TextureUnit target, Single[] v)
        {
            GL.MultiTexCoord4(target, v);
        }

        public void MultiTexCoord4(TextureUnit target, int s, int t, int r, int q)
        {
            GL.MultiTexCoord4(target, s, t, r, q);
        }

        public void MultiTexCoord4(TextureUnit target, Int32[] v)
        {
            GL.MultiTexCoord4(target, v);
        }

        public void MultiTexCoord4(TextureUnit target, short s, short t, short r, short q)
        {
            GL.MultiTexCoord4(target, s, t, r, q);
        }

        public void MultiTexCoord4(TextureUnit target, Int16[] v)
        {
            GL.MultiTexCoord4(target, v);
        }

        public void MultiTexCoordP1(TextureUnit texture, PackedPointerType type, int coords)
        {
            GL.MultiTexCoordP1(texture, type, coords);
        }

        public void MultiTexCoordP1(TextureUnit texture, PackedPointerType type, uint coords)
        {
            GL.MultiTexCoordP1(texture, type, coords);
        }

        public void MultiTexCoordP2(TextureUnit texture, PackedPointerType type, int coords)
        {
            GL.MultiTexCoordP2(texture, type, coords);
        }

        public void MultiTexCoordP2(TextureUnit texture, PackedPointerType type, uint coords)
        {
            GL.MultiTexCoordP2(texture, type, coords);
        }

        public void MultiTexCoordP3(TextureUnit texture, PackedPointerType type, int coords)
        {
            GL.MultiTexCoordP3(texture, type, coords);
        }

        public void MultiTexCoordP3(TextureUnit texture, PackedPointerType type, uint coords)
        {
            GL.MultiTexCoordP3(texture, type, coords);
        }

        public void MultiTexCoordP4(TextureUnit texture, PackedPointerType type, int coords)
        {
            GL.MultiTexCoordP4(texture, type, coords);
        }

        public void MultiTexCoordP4(TextureUnit texture, PackedPointerType type, uint coords)
        {
            GL.MultiTexCoordP4(texture, type, coords);
        }

        public void MultMatrix(Double[] m)
        {
            GL.MultMatrix(m);
        }

        public void LoadMatrix(Single[] m)
        {
            GL.LoadMatrix(m);
        }

        public void LoadName(int name)
        {
            GL.LoadName(name);
        }

        public void LoadName(uint name)
        {
            GL.LoadName(name);
        }

        public void LoadTransposeMatrix(Double[] m)
        {
            GL.LoadTransposeMatrix(m);
        }

        public void LoadTransposeMatrix(Single[] m)
        {
            GL.LoadTransposeMatrix(m);
        }

        public void LogicOp(LogicOp opcode)
        {
            GL.LogicOp(opcode);
        }

        public void Map1(MapTarget target, double u1, double u2, int stride, int order, Double[] points)
        {
            GL.Map1(target, u1, u2, stride, order, points);
        }

        public void Map1(MapTarget target, float u1, float u2, int stride, int order, Single[] points)
        {
            GL.Map1(target, u1, u2, stride, order, points);
        }

        public void Map2(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, Double[] points)
        {
            GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }

        public void Map2(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, Single[] points)
        {
            GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }

        public IntPtr MapBuffer(BufferTarget target, BufferAccess access)
        {
            return GL.MapBuffer(target, access);
        }

        public IntPtr MapBufferRange(BufferTarget target, IntPtr offset, int length, BufferAccessMask access)
        {
            return GL.MapBufferRange(target, offset, length, access);
        }

        public IntPtr MapBufferRange(BufferTarget target, IntPtr offset, IntPtr length, BufferAccessMask access)
        {
            return GL.MapBufferRange(target, offset, length, access);
        }

        public void MapGrid1(int un, double u1, double u2)
        {
            GL.MapGrid1(un, u1, u2);
        }

        public void MapGrid1(int un, float u1, float u2)
        {
            GL.MapGrid1(un, u1, u2);
        }

        public void MapGrid2(int un, double u1, double u2, int vn, double v1, double v2)
        {
            GL.MapGrid2(un, u1, u2, vn, v1, v2);
        }

        public void MapGrid2(int un, float u1, float u2, int vn, float v1, float v2)
        {
            GL.MapGrid2(un, u1, u2, vn, v1, v2);
        }

        public IntPtr MapNamedBuffer(int buffer, BufferAccess access)
        {
            return GL.MapNamedBuffer(buffer, access);
        }

        public IntPtr MapNamedBuffer(uint buffer, BufferAccess access)
        {
            return GL.MapNamedBuffer(buffer, access);
        }

        public IntPtr MapNamedBufferRange(int buffer, IntPtr offset, int length, BufferAccessMask access)
        {
            return GL.MapNamedBufferRange(buffer, offset, length, access);
        }

        public IntPtr MapNamedBufferRange(uint buffer, IntPtr offset, int length, BufferAccessMask access)
        {
            return GL.MapNamedBufferRange(buffer, offset, length, access);
        }

        public void Material(MaterialFace face, MaterialParameter pname, float param)
        {
            GL.Material(face, pname, param);
        }

        public void Material(MaterialFace face, MaterialParameter pname, Single[] @params)
        {
            GL.Material(face, pname, @params);
        }

        public void Material(MaterialFace face, MaterialParameter pname, int param)
        {
            GL.Material(face, pname, param);
        }

        public void Material(MaterialFace face, MaterialParameter pname, Int32[] @params)
        {
            GL.Material(face, pname, @params);
        }

        public void MatrixMode(MatrixMode mode)
        {
            GL.MatrixMode(mode);
        }

        public void MemoryBarrier(MemoryBarrierFlags barriers)
        {
            GL.MemoryBarrier(barriers);
        }

        public void MemoryBarrierByRegion(MemoryBarrierRegionFlags barriers)
        {
            GL.MemoryBarrierByRegion(barriers);
        }

        public void Minmax(MinmaxTarget target, PixelInternalFormat internalformat, bool sink)
        {
            GL.Minmax(target, internalformat, sink);
        }

        public void MinSampleShading(float value)
        {
            GL.MinSampleShading(value);
        }

        public void MultiDrawArrays(PrimitiveType mode, Int32[] first, Int32[] count, int drawcount)
        {
            GL.MultiDrawArrays(mode, first, count, drawcount);
        }

        public void MultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, int drawcount, int stride)
        {
            GL.MultiDrawArraysIndirect(mode, indirect, drawcount, stride);
        }

        public void MultiDrawArraysIndirect<T1>(PrimitiveType mode, T1[] indirect, int drawcount, int stride)
                where T1 : struct
        {
            GL.MultiDrawArraysIndirect(mode, indirect, drawcount, stride);
        }

        public void MultiDrawArraysIndirect<T1>(PrimitiveType mode, T1[,] indirect, int drawcount, int stride)
                where T1 : struct
        {
            GL.MultiDrawArraysIndirect(mode, indirect, drawcount, stride);
        }

        public void MultiDrawArraysIndirect<T1>(PrimitiveType mode, T1[,,] indirect, int drawcount, int stride)
                where T1 : struct
        {
            GL.MultiDrawArraysIndirect(mode, indirect, drawcount, stride);
        }

        public void MultiDrawElements(PrimitiveType mode, Int32[] count, DrawElementsType type, IntPtr indices, int drawcount)
        {
            GL.MultiDrawElements(mode, count, type, indices, drawcount);
        }

        public void MultiDrawElements<T3>(PrimitiveType mode, Int32[] count, DrawElementsType type, T3[] indices, int drawcount)
                where T3 : struct
        {
            GL.MultiDrawElements(mode, count, type, indices, drawcount);
        }

        public void MultiDrawElements<T3>(PrimitiveType mode, Int32[] count, DrawElementsType type, T3[,] indices, int drawcount)
                where T3 : struct
        {
            GL.MultiDrawElements(mode, count, type, indices, drawcount);
        }

        public void MultiDrawElements<T3>(PrimitiveType mode, Int32[] count, DrawElementsType type, T3[,,] indices, int drawcount)
                where T3 : struct
        {
            GL.MultiDrawElements(mode, count, type, indices, drawcount);
        }

        public void GetVertexAttribPointer(int index, VertexAttribPointerParameter pname, IntPtr pointer)
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void GetVertexAttribPointer<T2>(int index, VertexAttribPointerParameter pname, T2[] pointer)
                where T2 : struct
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void GetVertexAttribPointer<T2>(int index, VertexAttribPointerParameter pname, T2[,] pointer)
                where T2 : struct
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void GetVertexAttribPointer<T2>(int index, VertexAttribPointerParameter pname, T2[,,] pointer)
                where T2 : struct
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void GetVertexAttribPointer(uint index, VertexAttribPointerParameter pname, IntPtr pointer)
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void GetVertexAttribPointer<T2>(uint index, VertexAttribPointerParameter pname, T2[] pointer)
                where T2 : struct
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void GetVertexAttribPointer<T2>(uint index, VertexAttribPointerParameter pname, T2[,] pointer)
                where T2 : struct
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void GetVertexAttribPointer<T2>(uint index, VertexAttribPointerParameter pname, T2[,,] pointer)
                where T2 : struct
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void Hint(HintTarget target, HintMode mode)
        {
            GL.Hint(target, mode);
        }

        public void Histogram(HistogramTarget target, int width, PixelInternalFormat internalformat, bool sink)
        {
            GL.Histogram(target, width, internalformat, sink);
        }

        public void Index(double c)
        {
            GL.Index(c);
        }

        public void Index(float c)
        {
            GL.Index(c);
        }

        public void Index(int c)
        {
            GL.Index(c);
        }

        public void IndexMask(int mask)
        {
            GL.IndexMask(mask);
        }

        public void IndexMask(uint mask)
        {
            GL.IndexMask(mask);
        }

        public void IndexPointer(IndexPointerType type, int stride, IntPtr pointer)
        {
            GL.IndexPointer(type, stride, pointer);
        }

        public void IndexPointer<T2>(IndexPointerType type, int stride, T2[] pointer)
                where T2 : struct
        {
            GL.IndexPointer(type, stride, pointer);
        }

        public void IndexPointer<T2>(IndexPointerType type, int stride, T2[,] pointer)
                where T2 : struct
        {
            GL.IndexPointer(type, stride, pointer);
        }

        public void IndexPointer<T2>(IndexPointerType type, int stride, T2[,,] pointer)
                where T2 : struct
        {
            GL.IndexPointer(type, stride, pointer);
        }

        public void Index(short c)
        {
            GL.Index(c);
        }

        public void Index(byte c)
        {
            GL.Index(c);
        }

        public void InitNames()
        {
            GL.InitNames();
        }

        public void InterleavedArrays(InterleavedArrayFormat format, int stride, IntPtr pointer)
        {
            GL.InterleavedArrays(format, stride, pointer);
        }

        public void InterleavedArrays<T2>(InterleavedArrayFormat format, int stride, T2[] pointer)
                where T2 : struct
        {
            GL.InterleavedArrays(format, stride, pointer);
        }

        public void InterleavedArrays<T2>(InterleavedArrayFormat format, int stride, T2[,] pointer)
                where T2 : struct
        {
            GL.InterleavedArrays(format, stride, pointer);
        }

        public void InterleavedArrays<T2>(InterleavedArrayFormat format, int stride, T2[,,] pointer)
                where T2 : struct
        {
            GL.InterleavedArrays(format, stride, pointer);
        }

        public void InvalidateBufferData(int buffer)
        {
            GL.InvalidateBufferData(buffer);
        }

        public void InvalidateBufferData(uint buffer)
        {
            GL.InvalidateBufferData(buffer);
        }

        public void InvalidateBufferSubData(int buffer, IntPtr offset, int length)
        {
            GL.InvalidateBufferSubData(buffer, offset, length);
        }

        public void InvalidateBufferSubData(int buffer, IntPtr offset, IntPtr length)
        {
            GL.InvalidateBufferSubData(buffer, offset, length);
        }

        public void InvalidateBufferSubData(uint buffer, IntPtr offset, int length)
        {
            GL.InvalidateBufferSubData(buffer, offset, length);
        }

        public void InvalidateBufferSubData(uint buffer, IntPtr offset, IntPtr length)
        {
            GL.InvalidateBufferSubData(buffer, offset, length);
        }

        public void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, FramebufferAttachment[] attachments)
        {
            GL.InvalidateFramebuffer(target, numAttachments, attachments);
        }

        public void InvalidateNamedFramebufferData(int framebuffer, int numAttachments, FramebufferAttachment[] attachments)
        {
            GL.InvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
        }

        public void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, FramebufferAttachment[] attachments)
        {
            GL.InvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
        }

        public void InvalidateNamedFramebufferSubData(int framebuffer, int numAttachments, FramebufferAttachment[] attachments, int x, int y, int width, int height)
        {
            GL.InvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
        }

        public void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, FramebufferAttachment[] attachments, int x, int y, int width, int height)
        {
            GL.InvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
        }

        public void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, FramebufferAttachment[] attachments, int x, int y, int width, int height)
        {
            GL.InvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
        }

        public void InvalidateTexImage(int texture, int level)
        {
            GL.InvalidateTexImage(texture, level);
        }

        public void InvalidateTexImage(uint texture, int level)
        {
            GL.InvalidateTexImage(texture, level);
        }

        public void InvalidateTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
        {
            GL.InvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
        }

        public void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
        {
            GL.InvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
        }

        public bool IsBuffer(int buffer)
        {
            return GL.IsBuffer(buffer);
        }

        public bool IsBuffer(uint buffer)
        {
            return GL.IsBuffer(buffer);
        }

        public bool IsEnabled(EnableCap cap)
        {
            return GL.IsEnabled(cap);
        }

        public bool IsEnabled(IndexedEnableCap target, int index)
        {
            return GL.IsEnabled(target, index);
        }

        public bool IsEnabled(IndexedEnableCap target, uint index)
        {
            return GL.IsEnabled(target, index);
        }

        public bool IsFramebuffer(int framebuffer)
        {
            return GL.IsFramebuffer(framebuffer);
        }

        public bool IsFramebuffer(uint framebuffer)
        {
            return GL.IsFramebuffer(framebuffer);
        }

        public bool IsList(int list)
        {
            return GL.IsList(list);
        }

        public bool IsList(uint list)
        {
            return GL.IsList(list);
        }

        public bool IsProgram(int program)
        {
            return GL.IsProgram(program);
        }

        public bool IsProgram(uint program)
        {
            return GL.IsProgram(program);
        }

        public bool IsProgramPipeline(int pipeline)
        {
            return GL.IsProgramPipeline(pipeline);
        }

        public bool IsProgramPipeline(uint pipeline)
        {
            return GL.IsProgramPipeline(pipeline);
        }

        public bool IsQuery(int id)
        {
            return GL.IsQuery(id);
        }

        public bool IsQuery(uint id)
        {
            return GL.IsQuery(id);
        }

        public bool IsRenderbuffer(int renderbuffer)
        {
            return GL.IsRenderbuffer(renderbuffer);
        }

        public bool IsRenderbuffer(uint renderbuffer)
        {
            return GL.IsRenderbuffer(renderbuffer);
        }

        public bool IsSampler(int sampler)
        {
            return GL.IsSampler(sampler);
        }

        public bool IsSampler(uint sampler)
        {
            return GL.IsSampler(sampler);
        }

        public bool IsShader(int shader)
        {
            return GL.IsShader(shader);
        }

        public bool IsShader(uint shader)
        {
            return GL.IsShader(shader);
        }

        public bool IsSync(IntPtr sync)
        {
            return GL.IsSync(sync);
        }

        public bool IsTexture(int texture)
        {
            return GL.IsTexture(texture);
        }

        public bool IsTexture(uint texture)
        {
            return GL.IsTexture(texture);
        }

        public bool IsTransformFeedback(int id)
        {
            return GL.IsTransformFeedback(id);
        }

        public bool IsTransformFeedback(uint id)
        {
            return GL.IsTransformFeedback(id);
        }

        public bool IsVertexArray(int array)
        {
            return GL.IsVertexArray(array);
        }

        public bool IsVertexArray(uint array)
        {
            return GL.IsVertexArray(array);
        }

        public void Light(LightName light, LightParameter pname, float param)
        {
            GL.Light(light, pname, param);
        }

        public void Light(LightName light, LightParameter pname, Single[] @params)
        {
            GL.Light(light, pname, @params);
        }

        public void Light(LightName light, LightParameter pname, int param)
        {
            GL.Light(light, pname, param);
        }

        public void Light(LightName light, LightParameter pname, Int32[] @params)
        {
            GL.Light(light, pname, @params);
        }

        public void LightModel(LightModelParameter pname, float param)
        {
            GL.LightModel(pname, param);
        }

        public void LightModel(LightModelParameter pname, Single[] @params)
        {
            GL.LightModel(pname, @params);
        }

        public void LightModel(LightModelParameter pname, int param)
        {
            GL.LightModel(pname, param);
        }

        public void LightModel(LightModelParameter pname, Int32[] @params)
        {
            GL.LightModel(pname, @params);
        }

        public void LineStipple(int factor, short pattern)
        {
            GL.LineStipple(factor, pattern);
        }

        public void LineStipple(int factor, ushort pattern)
        {
            GL.LineStipple(factor, pattern);
        }

        public void LineWidth(float width)
        {
            GL.LineWidth(width);
        }

        public void LinkProgram(int program)
        {
            GL.LinkProgram(program);
        }

        public void LinkProgram(uint program)
        {
            GL.LinkProgram(program);
        }

        public void ListBase(int @base)
        {
            GL.ListBase(@base);
        }

        public void ListBase(uint @base)
        {
            GL.ListBase(@base);
        }

        public void LoadIdentity()
        {
            GL.LoadIdentity();
        }

        public void LoadMatrix(Double[] m)
        {
            GL.LoadMatrix(m);
        }

        public void GetTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTextureSubImage<T11>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, T11[] pixels)
                where T11 : struct
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTextureSubImage<T11>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, T11[,] pixels)
                where T11 : struct
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTextureSubImage<T11>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, T11[,,] pixels)
                where T11 : struct
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTextureSubImage<T11>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, T11[] pixels)
                where T11 : struct
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTextureSubImage<T11>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, T11[,] pixels)
                where T11 : struct
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTextureSubImage<T11>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, T11[,,] pixels)
                where T11 : struct
        {
            GL.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public void GetTransformFeedback(int xfb, TransformFeedbackIndexedParameter pname, int index, Int32[] param)
        {
            GL.GetTransformFeedback(xfb, pname, index, param);
        }

        public void GetTransformFeedback(uint xfb, TransformFeedbackIndexedParameter pname, uint index, Int32[] param)
        {
            GL.GetTransformFeedback(xfb, pname, index, param);
        }

        public void GetTransformFeedbacki64_(int xfb, TransformFeedbackIndexedParameter pname, int index, Int64[] param)
        {
            GL.GetTransformFeedbacki64_(xfb, pname, index, param);
        }

        public void GetTransformFeedbacki64_(uint xfb, TransformFeedbackIndexedParameter pname, uint index, Int64[] param)
        {
            GL.GetTransformFeedbacki64_(xfb, pname, index, param);
        }

        public void GetTransformFeedback(int xfb, TransformFeedbackParameter pname, Int32[] param)
        {
            GL.GetTransformFeedback(xfb, pname, param);
        }

        public void GetTransformFeedback(uint xfb, TransformFeedbackParameter pname, Int32[] param)
        {
            GL.GetTransformFeedback(xfb, pname, param);
        }

        public int GetUniformBlockIndex(int program, string uniformBlockName)
        {
            return GL.GetUniformBlockIndex(program, uniformBlockName);
        }

        public int GetUniformBlockIndex(uint program, string uniformBlockName)
        {
            return GL.GetUniformBlockIndex(program, uniformBlockName);
        }

        public void GetUniform(int program, int location, Double[] @params)
        {
            GL.GetUniform(program, location, @params);
        }

        public void GetUniform(uint program, int location, Double[] @params)
        {
            GL.GetUniform(program, location, @params);
        }

        public void GetUniform(int program, int location, Single[] @params)
        {
            GL.GetUniform(program, location, @params);
        }

        public void GetUniform(uint program, int location, Single[] @params)
        {
            GL.GetUniform(program, location, @params);
        }

        public void GetUniformIndices(int program, int uniformCount, String[] uniformNames, Int32[] uniformIndices)
        {
            GL.GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
        }

        public void GetUniformIndices(uint program, int uniformCount, String[] uniformNames, UInt32[] uniformIndices)
        {
            GL.GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
        }

        public void GetUniform(int program, int location, Int32[] @params)
        {
            GL.GetUniform(program, location, @params);
        }

        public void GetUniform(uint program, int location, Int32[] @params)
        {
            GL.GetUniform(program, location, @params);
        }

        public int GetUniformLocation(int program, string name)
        {
            return GL.GetUniformLocation(program, name);
        }

        public int GetUniformLocation(uint program, string name)
        {
            return GL.GetUniformLocation(program, name);
        }

        public void GetUniform(uint program, int location, UInt32[] @params)
        {
            GL.GetUniform(program, location, @params);
        }

        public void GetVertexArrayIndexed64(int vaobj, int index, VertexArrayIndexed64Parameter pname, Int64[] param)
        {
            GL.GetVertexArrayIndexed64(vaobj, index, pname, param);
        }

        public void GetVertexArrayIndexed64(uint vaobj, uint index, VertexArrayIndexed64Parameter pname, Int64[] param)
        {
            GL.GetVertexArrayIndexed64(vaobj, index, pname, param);
        }

        public void GetVertexArrayIndexed(int vaobj, int index, VertexArrayIndexedParameter pname, Int32[] param)
        {
            GL.GetVertexArrayIndexed(vaobj, index, pname, param);
        }

        public void GetVertexArrayIndexed(uint vaobj, uint index, VertexArrayIndexedParameter pname, Int32[] param)
        {
            GL.GetVertexArrayIndexed(vaobj, index, pname, param);
        }

        public void GetVertexArray(int vaobj, VertexArrayParameter pname, Int32[] param)
        {
            GL.GetVertexArray(vaobj, pname, param);
        }

        public void GetVertexArray(uint vaobj, VertexArrayParameter pname, Int32[] param)
        {
            GL.GetVertexArray(vaobj, pname, param);
        }

        public void GetVertexAttrib(int index, VertexAttribParameter pname, Double[] @params)
        {
            GL.GetVertexAttrib(index, pname, @params);
        }

        public void GetVertexAttrib(uint index, VertexAttribParameter pname, Double[] @params)
        {
            GL.GetVertexAttrib(index, pname, @params);
        }

        public void GetVertexAttrib(int index, VertexAttribParameter pname, Single[] @params)
        {
            GL.GetVertexAttrib(index, pname, @params);
        }

        public void GetVertexAttrib(uint index, VertexAttribParameter pname, Single[] @params)
        {
            GL.GetVertexAttrib(index, pname, @params);
        }

        public void GetVertexAttrib(int index, VertexAttribParameter pname, Int32[] @params)
        {
            GL.GetVertexAttrib(index, pname, @params);
        }

        public void GetVertexAttrib(uint index, VertexAttribParameter pname, Int32[] @params)
        {
            GL.GetVertexAttrib(index, pname, @params);
        }

        public void GetVertexAttribL(int index, VertexAttribParameter pname, Double[] @params)
        {
            GL.GetVertexAttribL(index, pname, @params);
        }

        public void GetVertexAttribL(uint index, VertexAttribParameter pname, Double[] @params)
        {
            GL.GetVertexAttribL(index, pname, @params);
        }

        public void GetSeparableFilter<T3, T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, T3[,,] row, T4[,,] column, T5[,,] span)
                where T3 : struct
                where T4 : struct
                where T5 : struct
        {
            GL.GetSeparableFilter(target, format, type, row, column, span);
        }

        public void GetShader(int shader, ShaderParameter pname, Int32[] @params)
        {
            GL.GetShader(shader, pname, @params);
        }

        public void GetShader(uint shader, ShaderParameter pname, Int32[] @params)
        {
            GL.GetShader(shader, pname, @params);
        }

        public void GetShaderPrecisionFormat(ShaderType shadertype, ShaderPrecision precisiontype, Int32[] range, Int32[] precision)
        {
            GL.GetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
        }

        public string GetString(StringName name)
        {
            return GL.GetString(name);
        }

        public string GetString(StringNameIndexed name, int index)
        {
            return GL.GetString(name, index);
        }

        public string GetString(StringNameIndexed name, uint index)
        {
            return GL.GetString(name, index);
        }

        public int GetSubroutineIndex(int program, ShaderType shadertype, string name)
        {
            return GL.GetSubroutineIndex(program, shadertype, name);
        }

        public int GetSubroutineIndex(uint program, ShaderType shadertype, string name)
        {
            return GL.GetSubroutineIndex(program, shadertype, name);
        }

        public int GetSubroutineUniformLocation(int program, ShaderType shadertype, string name)
        {
            return GL.GetSubroutineUniformLocation(program, shadertype, name);
        }

        public int GetSubroutineUniformLocation(uint program, ShaderType shadertype, string name)
        {
            return GL.GetSubroutineUniformLocation(program, shadertype, name);
        }

        public void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, Single[] @params)
        {
            GL.GetTexEnv(target, pname, @params);
        }

        public void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
        {
            GL.GetTexEnv(target, pname, @params);
        }

        public void GetTexGen(TextureCoordName coord, TextureGenParameter pname, Double[] @params)
        {
            GL.GetTexGen(coord, pname, @params);
        }

        public void GetTexGen(TextureCoordName coord, TextureGenParameter pname, Single[] @params)
        {
            GL.GetTexGen(coord, pname, @params);
        }

        public void GetTexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
        {
            GL.GetTexGen(coord, pname, @params);
        }

        public void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.GetTexImage(target, level, format, type, pixels);
        }

        public void GetTexImage<T4>(TextureTarget target, int level, PixelFormat format, PixelType type, T4[] pixels)
                where T4 : struct
        {
            GL.GetTexImage(target, level, format, type, pixels);
        }

        public void GetTexImage<T4>(TextureTarget target, int level, PixelFormat format, PixelType type, T4[,] pixels)
                where T4 : struct
        {
            GL.GetTexImage(target, level, format, type, pixels);
        }

        public void GetTexImage<T4>(TextureTarget target, int level, PixelFormat format, PixelType type, T4[,,] pixels)
                where T4 : struct
        {
            GL.GetTexImage(target, level, format, type, pixels);
        }

        public void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, Single[] @params)
        {
            GL.GetTexLevelParameter(target, level, pname, @params);
        }

        public void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, Int32[] @params)
        {
            GL.GetTexLevelParameter(target, level, pname, @params);
        }

        public void GetTexParameter(TextureTarget target, GetTextureParameter pname, Single[] @params)
        {
            GL.GetTexParameter(target, pname, @params);
        }

        public void GetTexParameterI(TextureTarget target, GetTextureParameter pname, Int32[] @params)
        {
            GL.GetTexParameterI(target, pname, @params);
        }

        public void GetTexParameterI(TextureTarget target, GetTextureParameter pname, UInt32[] @params)
        {
            GL.GetTexParameterI(target, pname, @params);
        }

        public void GetTexParameter(TextureTarget target, GetTextureParameter pname, Int32[] @params)
        {
            GL.GetTexParameter(target, pname, @params);
        }

        public void GetTextureImage(int texture, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureImage<T5>(int texture, int level, PixelFormat format, PixelType type, int bufSize, T5[] pixels)
                where T5 : struct
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureImage<T5>(int texture, int level, PixelFormat format, PixelType type, int bufSize, T5[,] pixels)
                where T5 : struct
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureImage<T5>(int texture, int level, PixelFormat format, PixelType type, int bufSize, T5[,,] pixels)
                where T5 : struct
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureImage(uint texture, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureImage<T5>(uint texture, int level, PixelFormat format, PixelType type, int bufSize, T5[] pixels)
                where T5 : struct
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureImage<T5>(uint texture, int level, PixelFormat format, PixelType type, int bufSize, T5[,] pixels)
                where T5 : struct
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureImage<T5>(uint texture, int level, PixelFormat format, PixelType type, int bufSize, T5[,,] pixels)
                where T5 : struct
        {
            GL.GetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public void GetTextureLevelParameter(int texture, int level, GetTextureParameter pname, Single[] @params)
        {
            GL.GetTextureLevelParameter(texture, level, pname, @params);
        }

        public void GetTextureLevelParameter(uint texture, int level, GetTextureParameter pname, Single[] @params)
        {
            GL.GetTextureLevelParameter(texture, level, pname, @params);
        }

        public void GetTextureLevelParameter(int texture, int level, GetTextureParameter pname, Int32[] @params)
        {
            GL.GetTextureLevelParameter(texture, level, pname, @params);
        }

        public void GetTextureLevelParameter(uint texture, int level, GetTextureParameter pname, Int32[] @params)
        {
            GL.GetTextureLevelParameter(texture, level, pname, @params);
        }

        public void GetTextureParameter(int texture, GetTextureParameter pname, Single[] @params)
        {
            GL.GetTextureParameter(texture, pname, @params);
        }

        public void GetTextureParameter(uint texture, GetTextureParameter pname, Single[] @params)
        {
            GL.GetTextureParameter(texture, pname, @params);
        }

        public void GetTextureParameterI(int texture, All pname, Int32[] @params)
        {
            GL.GetTextureParameterI(texture, pname, @params);
        }

        public void GetTextureParameterI(uint texture, All pname, Int32[] @params)
        {
            GL.GetTextureParameterI(texture, pname, @params);
        }

        public void GetTextureParameterI(uint texture, All pname, UInt32[] @params)
        {
            GL.GetTextureParameterI(texture, pname, @params);
        }

        public void GetTextureParameter(int texture, GetTextureParameter pname, Int32[] @params)
        {
            GL.GetTextureParameter(texture, pname, @params);
        }

        public void GetTextureParameter(uint texture, GetTextureParameter pname, Int32[] @params)
        {
            GL.GetTextureParameter(texture, pname, @params);
        }

        public void GetProgramInterface(uint program, ProgramInterface programInterface, ProgramInterfaceParameter pname, Int32[] @params)
        {
            GL.GetProgramInterface(program, programInterface, pname, @params);
        }

        public void GetProgram(int program, GetProgramParameterName pname, Int32[] @params)
        {
            GL.GetProgram(program, pname, @params);
        }

        public void GetProgram(uint program, GetProgramParameterName pname, Int32[] @params)
        {
            GL.GetProgram(program, pname, @params);
        }

        public void GetProgramPipeline(int pipeline, ProgramPipelineParameter pname, Int32[] @params)
        {
            GL.GetProgramPipeline(pipeline, pname, @params);
        }

        public void GetProgramPipeline(uint pipeline, ProgramPipelineParameter pname, Int32[] @params)
        {
            GL.GetProgramPipeline(pipeline, pname, @params);
        }

        public int GetProgramResourceIndex(int program, ProgramInterface programInterface, string name)
        {
            return GL.GetProgramResourceIndex(program, programInterface, name);
        }

        public int GetProgramResourceIndex(uint program, ProgramInterface programInterface, string name)
        {
            return GL.GetProgramResourceIndex(program, programInterface, name);
        }

        public int GetProgramResourceLocation(int program, ProgramInterface programInterface, string name)
        {
            return GL.GetProgramResourceLocation(program, programInterface, name);
        }

        public int GetProgramResourceLocation(uint program, ProgramInterface programInterface, string name)
        {
            return GL.GetProgramResourceLocation(program, programInterface, name);
        }

        public int GetProgramResourceLocationIndex(int program, ProgramInterface programInterface, string name)
        {
            return GL.GetProgramResourceLocationIndex(program, programInterface, name);
        }

        public int GetProgramResourceLocationIndex(uint program, ProgramInterface programInterface, string name)
        {
            return GL.GetProgramResourceLocationIndex(program, programInterface, name);
        }

        public void GetQueryIndexed(QueryTarget target, int index, GetQueryParam pname, Int32[] @params)
        {
            GL.GetQueryIndexed(target, index, pname, @params);
        }

        public void GetQueryIndexed(QueryTarget target, uint index, GetQueryParam pname, Int32[] @params)
        {
            GL.GetQueryIndexed(target, index, pname, @params);
        }

        public void GetQuery(QueryTarget target, GetQueryParam pname, Int32[] @params)
        {
            GL.GetQuery(target, pname, @params);
        }

        public void GetQueryObject(int id, GetQueryObjectParam pname, Int64[] @params)
        {
            GL.GetQueryObject(id, pname, @params);
        }

        public void GetQueryObject(uint id, GetQueryObjectParam pname, Int64[] @params)
        {
            GL.GetQueryObject(id, pname, @params);
        }

        public void GetQueryObject(int id, GetQueryObjectParam pname, Int32[] @params)
        {
            GL.GetQueryObject(id, pname, @params);
        }

        public void GetQueryObject(uint id, GetQueryObjectParam pname, Int32[] @params)
        {
            GL.GetQueryObject(id, pname, @params);
        }

        public void GetQueryObject(uint id, GetQueryObjectParam pname, UInt64[] @params)
        {
            GL.GetQueryObject(id, pname, @params);
        }

        public void GetQueryObject(uint id, GetQueryObjectParam pname, UInt32[] @params)
        {
            GL.GetQueryObject(id, pname, @params);
        }

        public void GetRenderbufferParameter(RenderbufferTarget target, RenderbufferParameterName pname, Int32[] @params)
        {
            GL.GetRenderbufferParameter(target, pname, @params);
        }

        public void GetSamplerParameter(int sampler, SamplerParameterName pname, Single[] @params)
        {
            GL.GetSamplerParameter(sampler, pname, @params);
        }

        public void GetSamplerParameter(uint sampler, SamplerParameterName pname, Single[] @params)
        {
            GL.GetSamplerParameter(sampler, pname, @params);
        }

        public void GetSamplerParameterI(int sampler, All pname, Int32[] @params)
        {
            GL.GetSamplerParameterI(sampler, pname, @params);
        }

        public void GetSamplerParameterI(uint sampler, All pname, Int32[] @params)
        {
            GL.GetSamplerParameterI(sampler, pname, @params);
        }

        public void GetSamplerParameterI(uint sampler, All pname, UInt32[] @params)
        {
            GL.GetSamplerParameterI(sampler, pname, @params);
        }

        public void GetSamplerParameter(int sampler, SamplerParameterName pname, Int32[] @params)
        {
            GL.GetSamplerParameter(sampler, pname, @params);
        }

        public void GetSamplerParameter(uint sampler, SamplerParameterName pname, Int32[] @params)
        {
            GL.GetSamplerParameter(sampler, pname, @params);
        }

        public void GetSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
        {
            GL.GetSeparableFilter(target, format, type, row, column, span);
        }

        public void GetSeparableFilter<T3, T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, T3[] row, T4[] column, T5[] span)
                where T3 : struct
                where T4 : struct
                where T5 : struct
        {
            GL.GetSeparableFilter(target, format, type, row, column, span);
        }

        public void GetSeparableFilter<T3, T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, T3[,] row, T4[,] column, T5[,] span)
                where T3 : struct
                where T4 : struct
                where T5 : struct
        {
            GL.GetSeparableFilter(target, format, type, row, column, span);
        }

        public void GetnUniform(uint program, int location, int bufSize, Double[] @params)
        {
            GL.GetnUniform(program, location, bufSize, @params);
        }

        public void GetnUniform(int program, int location, int bufSize, Single[] @params)
        {
            GL.GetnUniform(program, location, bufSize, @params);
        }

        public void GetnUniform(uint program, int location, int bufSize, Single[] @params)
        {
            GL.GetnUniform(program, location, bufSize, @params);
        }

        public void GetnUniform(int program, int location, int bufSize, Int32[] @params)
        {
            GL.GetnUniform(program, location, bufSize, @params);
        }

        public void GetnUniform(uint program, int location, int bufSize, Int32[] @params)
        {
            GL.GetnUniform(program, location, bufSize, @params);
        }

        public void GetnUniform(uint program, int location, int bufSize, UInt32[] @params)
        {
            GL.GetnUniform(program, location, bufSize, @params);
        }

        public void GetObjectLabel(ObjectLabelIdentifier identifier, int name, int bufSize, Int32[] length, StringBuilder label)
        {
            GL.GetObjectLabel(identifier, name, bufSize, length, label);
        }

        public void GetObjectLabel(ObjectLabelIdentifier identifier, uint name, int bufSize, Int32[] length, StringBuilder label)
        {
            GL.GetObjectLabel(identifier, name, bufSize, length, label);
        }

        public float GetPixelMap(PixelMap map)
        {
            return GL.GetPixelMap(map);
        }

        public void GetPixelMap(PixelMap map, Single[] values)
        {
            GL.GetPixelMap(map, values);
        }

        public void GetPixelMap(PixelMap map, Int32[] values)
        {
            GL.GetPixelMap(map, values);
        }

        public void GetPixelMap(PixelMap map, UInt32[] values)
        {
            GL.GetPixelMap(map, values);
        }

        public void GetPixelMap(PixelMap map, Int16[] values)
        {
            GL.GetPixelMap(map, values);
        }

        public void GetPixelMap(PixelMap map, UInt16[] values)
        {
            GL.GetPixelMap(map, values);
        }

        public void GetPixelMapx(OesFixedPoint map, int size, Int32[] values)
        {
            GL.GetPixelMapx(map, size, values);
        }

        public void GetPointer(GetPointervPName pname, IntPtr @params)
        {
            GL.GetPointer(pname, @params);
        }

        public void GetPointer<T1>(GetPointervPName pname, T1[] @params)
                where T1 : struct
        {
            GL.GetPointer(pname, @params);
        }

        public void GetPointer<T1>(GetPointervPName pname, T1[,] @params)
                where T1 : struct
        {
            GL.GetPointer(pname, @params);
        }

        public void GetPointer<T1>(GetPointervPName pname, T1[,,] @params)
                where T1 : struct
        {
            GL.GetPointer(pname, @params);
        }

        public byte GetPolygonStipple()
        {
            return GL.GetPolygonStipple();
        }

        public void GetPolygonStipple(Byte[] mask)
        {
            GL.GetPolygonStipple(mask);
        }

        public void GetProgramInterface(int program, ProgramInterface programInterface, ProgramInterfaceParameter pname, Int32[] @params)
        {
            GL.GetProgramInterface(program, programInterface, pname, @params);
        }

        public void GetNamedBufferSubData(int buffer, IntPtr offset, int size, IntPtr data)
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedBufferSubData<T3>(int buffer, IntPtr offset, int size, T3[] data)
                where T3 : struct
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedBufferSubData<T3>(int buffer, IntPtr offset, int size, T3[,] data)
                where T3 : struct
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedBufferSubData<T3>(int buffer, IntPtr offset, int size, T3[,,] data)
                where T3 : struct
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedBufferSubData(uint buffer, IntPtr offset, int size, IntPtr data)
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedBufferSubData<T3>(uint buffer, IntPtr offset, int size, T3[] data)
                where T3 : struct
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedBufferSubData<T3>(uint buffer, IntPtr offset, int size, T3[,] data)
                where T3 : struct
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedBufferSubData<T3>(uint buffer, IntPtr offset, int size, T3[,,] data)
                where T3 : struct
        {
            GL.GetNamedBufferSubData(buffer, offset, size, data);
        }

        public void GetNamedFramebufferAttachmentParameter(int framebuffer, FramebufferAttachment attachment, FramebufferParameterName pname, Int32[] @params)
        {
            GL.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, @params);
        }

        public void GetNamedFramebufferAttachmentParameter(uint framebuffer, FramebufferAttachment attachment, FramebufferParameterName pname, Int32[] @params)
        {
            GL.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, @params);
        }

        public void GetNamedFramebufferParameter(int framebuffer, FramebufferDefaultParameter pname, Int32[] param)
        {
            GL.GetNamedFramebufferParameter(framebuffer, pname, param);
        }

        public void GetNamedFramebufferParameter(uint framebuffer, FramebufferDefaultParameter pname, Int32[] param)
        {
            GL.GetNamedFramebufferParameter(framebuffer, pname, param);
        }

        public void GetNamedRenderbufferParameter(int renderbuffer, RenderbufferParameterName pname, Int32[] @params)
        {
            GL.GetNamedRenderbufferParameter(renderbuffer, pname, @params);
        }

        public void GetNamedRenderbufferParameter(uint renderbuffer, RenderbufferParameterName pname, Int32[] @params)
        {
            GL.GetNamedRenderbufferParameter(renderbuffer, pname, @params);
        }

        public void GetnColorTable(Version45 target, Version45 format, Version45 type, int bufSize, IntPtr table)
        {
            GL.GetnColorTable(target, format, type, bufSize, table);
        }

        public void GetnColorTable<T4>(Version45 target, Version45 format, Version45 type, int bufSize, T4[] table)
                where T4 : struct
        {
            GL.GetnColorTable(target, format, type, bufSize, table);
        }

        public void GetnColorTable<T4>(Version45 target, Version45 format, Version45 type, int bufSize, T4[,] table)
                where T4 : struct
        {
            GL.GetnColorTable(target, format, type, bufSize, table);
        }

        public void GetnColorTable<T4>(Version45 target, Version45 format, Version45 type, int bufSize, T4[,,] table)
                where T4 : struct
        {
            GL.GetnColorTable(target, format, type, bufSize, table);
        }

        public void GetnCompressedTexImage(Version45 target, int lod, int bufSize, IntPtr pixels)
        {
            GL.GetnCompressedTexImage(target, lod, bufSize, pixels);
        }

        public void GetnCompressedTexImage<T3>(Version45 target, int lod, int bufSize, T3[] pixels)
                where T3 : struct
        {
            GL.GetnCompressedTexImage(target, lod, bufSize, pixels);
        }

        public void GetnCompressedTexImage<T3>(Version45 target, int lod, int bufSize, T3[,] pixels)
                where T3 : struct
        {
            GL.GetnCompressedTexImage(target, lod, bufSize, pixels);
        }

        public void GetnCompressedTexImage<T3>(Version45 target, int lod, int bufSize, T3[,,] pixels)
                where T3 : struct
        {
            GL.GetnCompressedTexImage(target, lod, bufSize, pixels);
        }

        public void GetnConvolutionFilter(Version45 target, Version45 format, Version45 type, int bufSize, IntPtr image)
        {
            GL.GetnConvolutionFilter(target, format, type, bufSize, image);
        }

        public void GetnConvolutionFilter<T4>(Version45 target, Version45 format, Version45 type, int bufSize, T4[] image)
                where T4 : struct
        {
            GL.GetnConvolutionFilter(target, format, type, bufSize, image);
        }

        public void GetnConvolutionFilter<T4>(Version45 target, Version45 format, Version45 type, int bufSize, T4[,] image)
                where T4 : struct
        {
            GL.GetnConvolutionFilter(target, format, type, bufSize, image);
        }

        public void GetnConvolutionFilter<T4>(Version45 target, Version45 format, Version45 type, int bufSize, T4[,,] image)
                where T4 : struct
        {
            GL.GetnConvolutionFilter(target, format, type, bufSize, image);
        }

        public void GetnHistogram(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, IntPtr values)
        {
            GL.GetnHistogram(target, reset, format, type, bufSize, values);
        }

        public void GetnHistogram<T5>(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, T5[] values)
                where T5 : struct
        {
            GL.GetnHistogram(target, reset, format, type, bufSize, values);
        }

        public void GetnHistogram<T5>(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, T5[,] values)
                where T5 : struct
        {
            GL.GetnHistogram(target, reset, format, type, bufSize, values);
        }

        public void GetnHistogram<T5>(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, T5[,,] values)
                where T5 : struct
        {
            GL.GetnHistogram(target, reset, format, type, bufSize, values);
        }

        public void GetnMap(Version45 target, Version45 query, int bufSize, Double[] v)
        {
            GL.GetnMap(target, query, bufSize, v);
        }

        public void GetnMap(Version45 target, Version45 query, int bufSize, Single[] v)
        {
            GL.GetnMap(target, query, bufSize, v);
        }

        public void GetnMap(Version45 target, Version45 query, int bufSize, Int32[] v)
        {
            GL.GetnMap(target, query, bufSize, v);
        }

        public void GetnMinmax(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, IntPtr values)
        {
            GL.GetnMinmax(target, reset, format, type, bufSize, values);
        }

        public void GetnMinmax<T5>(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, T5[] values)
                where T5 : struct
        {
            GL.GetnMinmax(target, reset, format, type, bufSize, values);
        }

        public void GetnMinmax<T5>(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, T5[,] values)
                where T5 : struct
        {
            GL.GetnMinmax(target, reset, format, type, bufSize, values);
        }

        public void GetnMinmax<T5>(Version45 target, bool reset, Version45 format, Version45 type, int bufSize, T5[,,] values)
                where T5 : struct
        {
            GL.GetnMinmax(target, reset, format, type, bufSize, values);
        }

        public void GetnPixelMap(Version45 map, int bufSize, Single[] values)
        {
            GL.GetnPixelMap(map, bufSize, values);
        }

        public void GetnPixelMap(Version45 map, int bufSize, Int32[] values)
        {
            GL.GetnPixelMap(map, bufSize, values);
        }

        public void GetnPixelMap(Version45 map, int bufSize, UInt32[] values)
        {
            GL.GetnPixelMap(map, bufSize, values);
        }

        public void GetnPixelMap(Version45 map, int bufSize, Int16[] values)
        {
            GL.GetnPixelMap(map, bufSize, values);
        }

        public void GetnPixelMap(Version45 map, int bufSize, UInt16[] values)
        {
            GL.GetnPixelMap(map, bufSize, values);
        }

        public byte GetnPolygonStipple()
        {
            return GL.GetnPolygonStipple();
        }

        public void GetnPolygonStipple(int bufSize, Byte[] pattern)
        {
            GL.GetnPolygonStipple(bufSize, pattern);
        }

        public void GetnSeparableFilter(Version45 target, Version45 format, Version45 type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span)
        {
            GL.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
        }

        public void GetnSeparableFilter<T4, T6, T7>(Version45 target, Version45 format, Version45 type, int rowBufSize, T4[] row, int columnBufSize, T6[] column, T7[] span)
                where T4 : struct
                where T6 : struct
                where T7 : struct
        {
            GL.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
        }

        public void GetnSeparableFilter<T4, T6, T7>(Version45 target, Version45 format, Version45 type, int rowBufSize, T4[,] row, int columnBufSize, T6[,] column, T7[,] span)
                where T4 : struct
                where T6 : struct
                where T7 : struct
        {
            GL.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
        }

        public void GetnSeparableFilter<T4, T6, T7>(Version45 target, Version45 format, Version45 type, int rowBufSize, T4[,,] row, int columnBufSize, T6[,,] column, T7[,,] span)
                where T4 : struct
                where T6 : struct
                where T7 : struct
        {
            GL.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
        }

        public void GetnTexImage(Version45 target, int level, Version45 format, Version45 type, int bufSize, IntPtr pixels)
        {
            GL.GetnTexImage(target, level, format, type, bufSize, pixels);
        }

        public void GetnTexImage<T5>(Version45 target, int level, Version45 format, Version45 type, int bufSize, T5[] pixels)
                where T5 : struct
        {
            GL.GetnTexImage(target, level, format, type, bufSize, pixels);
        }

        public void GetnTexImage<T5>(Version45 target, int level, Version45 format, Version45 type, int bufSize, T5[,] pixels)
                where T5 : struct
        {
            GL.GetnTexImage(target, level, format, type, bufSize, pixels);
        }

        public void GetnTexImage<T5>(Version45 target, int level, Version45 format, Version45 type, int bufSize, T5[,,] pixels)
                where T5 : struct
        {
            GL.GetnTexImage(target, level, format, type, bufSize, pixels);
        }

        public void GetnUniform(int program, int location, int bufSize, Double[] @params)
        {
            GL.GetnUniform(program, location, bufSize, @params);
        }

        public void GetFramebufferParameter(FramebufferTarget target, FramebufferDefaultParameter pname, Int32[] @params)
        {
            GL.GetFramebufferParameter(target, pname, @params);
        }

        public ResetStatus GetGraphicsResetStatus()
        {
            return GL.GetGraphicsResetStatus();
        }

        public void GetHistogram(HistogramTarget target, bool reset, PixelFormat format, PixelType type, IntPtr values)
        {
            GL.GetHistogram(target, reset, format, type, values);
        }

        public void GetHistogram<T4>(HistogramTarget target, bool reset, PixelFormat format, PixelType type, T4[] values)
                where T4 : struct
        {
            GL.GetHistogram(target, reset, format, type, values);
        }

        public void GetHistogram<T4>(HistogramTarget target, bool reset, PixelFormat format, PixelType type, T4[,] values)
                where T4 : struct
        {
            GL.GetHistogram(target, reset, format, type, values);
        }

        public void GetHistogram<T4>(HistogramTarget target, bool reset, PixelFormat format, PixelType type, T4[,,] values)
                where T4 : struct
        {
            GL.GetHistogram(target, reset, format, type, values);
        }

        public void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, Single[] @params)
        {
            GL.GetHistogramParameter(target, pname, @params);
        }

        public void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, Int32[] @params)
        {
            GL.GetHistogramParameter(target, pname, @params);
        }

        public void GetInteger64(GetIndexedPName target, int index, Int64[] data)
        {
            GL.GetInteger64(target, index, data);
        }

        public void GetInteger64(GetIndexedPName target, uint index, Int64[] data)
        {
            GL.GetInteger64(target, index, data);
        }

        public long GetInteger64(GetPName pname)
        {
            return GL.GetInteger64(pname);
        }

        public void GetInteger64(GetPName pname, Int64[] data)
        {
            GL.GetInteger64(pname, data);
        }

        public void GetInteger(GetIndexedPName target, int index, Int32[] data)
        {
            GL.GetInteger(target, index, data);
        }

        public void GetInteger(GetIndexedPName target, uint index, Int32[] data)
        {
            GL.GetInteger(target, index, data);
        }

        public int GetInteger(GetPName pname)
        {
            return GL.GetInteger(pname);
        }

        public void GetInteger(GetPName pname, Int32[] data)
        {
            GL.GetInteger(pname, data);
        }

        public void GetInternalformat(ImageTarget target, SizedInternalFormat internalformat, InternalFormatParameter pname, int bufSize, Int64[] @params)
        {
            GL.GetInternalformat(target, internalformat, pname, bufSize, @params);
        }

        public void GetInternalformat(ImageTarget target, SizedInternalFormat internalformat, InternalFormatParameter pname, int bufSize, Int32[] @params)
        {
            GL.GetInternalformat(target, internalformat, pname, bufSize, @params);
        }

        public void GetLight(LightName light, LightParameter pname, Single[] @params)
        {
            GL.GetLight(light, pname, @params);
        }

        public void GetLight(LightName light, LightParameter pname, Int32[] @params)
        {
            GL.GetLight(light, pname, @params);
        }

        public void GetMap(MapTarget target, GetMapQuery query, Double[] v)
        {
            GL.GetMap(target, query, v);
        }

        public void GetMap(MapTarget target, GetMapQuery query, Single[] v)
        {
            GL.GetMap(target, query, v);
        }

        public void GetMap(MapTarget target, GetMapQuery query, Int32[] v)
        {
            GL.GetMap(target, query, v);
        }

        public void GetMaterial(MaterialFace face, MaterialParameter pname, Single[] @params)
        {
            GL.GetMaterial(face, pname, @params);
        }

        public void GetMaterial(MaterialFace face, MaterialParameter pname, Int32[] @params)
        {
            GL.GetMaterial(face, pname, @params);
        }

        public void GetMinmax(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, IntPtr values)
        {
            GL.GetMinmax(target, reset, format, type, values);
        }

        public void GetMinmax<T4>(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, T4[] values)
                where T4 : struct
        {
            GL.GetMinmax(target, reset, format, type, values);
        }

        public void GetMinmax<T4>(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, T4[,] values)
                where T4 : struct
        {
            GL.GetMinmax(target, reset, format, type, values);
        }

        public void GetMinmax<T4>(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, T4[,,] values)
                where T4 : struct
        {
            GL.GetMinmax(target, reset, format, type, values);
        }

        public void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, Single[] @params)
        {
            GL.GetMinmaxParameter(target, pname, @params);
        }

        public void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, Int32[] @params)
        {
            GL.GetMinmaxParameter(target, pname, @params);
        }

        public void GetMultisample(GetMultisamplePName pname, int index, Single[] val)
        {
            GL.GetMultisample(pname, index, val);
        }

        public void GetMultisample(GetMultisamplePName pname, uint index, Single[] val)
        {
            GL.GetMultisample(pname, index, val);
        }

        public void GetNamedBufferParameter(int buffer, BufferParameterName pname, Int64[] @params)
        {
            GL.GetNamedBufferParameter(buffer, pname, @params);
        }

        public void GetNamedBufferParameter(uint buffer, BufferParameterName pname, Int64[] @params)
        {
            GL.GetNamedBufferParameter(buffer, pname, @params);
        }

        public void GetNamedBufferParameter(int buffer, BufferParameterName pname, Int32[] @params)
        {
            GL.GetNamedBufferParameter(buffer, pname, @params);
        }

        public void GetNamedBufferParameter(uint buffer, BufferParameterName pname, Int32[] @params)
        {
            GL.GetNamedBufferParameter(buffer, pname, @params);
        }

        public void GetNamedBufferPointer(int buffer, BufferPointer pname, IntPtr @params)
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetNamedBufferPointer<T2>(int buffer, BufferPointer pname, T2[] @params)
                where T2 : struct
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetNamedBufferPointer<T2>(int buffer, BufferPointer pname, T2[,] @params)
                where T2 : struct
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetNamedBufferPointer<T2>(int buffer, BufferPointer pname, T2[,,] @params)
                where T2 : struct
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetNamedBufferPointer(uint buffer, BufferPointer pname, IntPtr @params)
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetNamedBufferPointer<T2>(uint buffer, BufferPointer pname, T2[] @params)
                where T2 : struct
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetNamedBufferPointer<T2>(uint buffer, BufferPointer pname, T2[,] @params)
                where T2 : struct
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetNamedBufferPointer<T2>(uint buffer, BufferPointer pname, T2[,,] @params)
                where T2 : struct
        {
            GL.GetNamedBufferPointer(buffer, pname, @params);
        }

        public void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, int size, T3[] data)
                where T3 : struct
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, int size, T3[,] data)
                where T3 : struct
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, int size, T3[,,] data)
                where T3 : struct
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void GetBufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data)
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, T3[] data)
                where T3 : struct
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, T3[,] data)
                where T3 : struct
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, T3[,,] data)
                where T3 : struct
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void GetClipPlane(ClipPlaneName plane, Double[] equation)
        {
            GL.GetClipPlane(plane, equation);
        }

        public void GetColorTable(ColorTableTarget target, PixelFormat format, PixelType type, IntPtr table)
        {
            GL.GetColorTable(target, format, type, table);
        }

        public void GetColorTable<T3>(ColorTableTarget target, PixelFormat format, PixelType type, T3[] table)
                where T3 : struct
        {
            GL.GetColorTable(target, format, type, table);
        }

        public void GetColorTable<T3>(ColorTableTarget target, PixelFormat format, PixelType type, T3[,] table)
                where T3 : struct
        {
            GL.GetColorTable(target, format, type, table);
        }

        public void GetColorTable<T3>(ColorTableTarget target, PixelFormat format, PixelType type, T3[,,] table)
                where T3 : struct
        {
            GL.GetColorTable(target, format, type, table);
        }

        public void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, Single[] @params)
        {
            GL.GetColorTableParameter(target, pname, @params);
        }

        public void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, Int32[] @params)
        {
            GL.GetColorTableParameter(target, pname, @params);
        }

        public void GetCompressedTexImage(TextureTarget target, int level, IntPtr img)
        {
            GL.GetCompressedTexImage(target, level, img);
        }

        public void GetCompressedTexImage<T2>(TextureTarget target, int level, T2[] img)
                where T2 : struct
        {
            GL.GetCompressedTexImage(target, level, img);
        }

        public void GetCompressedTexImage<T2>(TextureTarget target, int level, T2[,] img)
                where T2 : struct
        {
            GL.GetCompressedTexImage(target, level, img);
        }

        public void GetCompressedTexImage<T2>(TextureTarget target, int level, T2[,,] img)
                where T2 : struct
        {
            GL.GetCompressedTexImage(target, level, img);
        }

        public void GetCompressedTextureImage(int texture, int level, int bufSize, IntPtr pixels)
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureImage<T3>(int texture, int level, int bufSize, T3[] pixels)
                where T3 : struct
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureImage<T3>(int texture, int level, int bufSize, T3[,] pixels)
                where T3 : struct
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureImage<T3>(int texture, int level, int bufSize, T3[,,] pixels)
                where T3 : struct
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels)
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureImage<T3>(uint texture, int level, int bufSize, T3[] pixels)
                where T3 : struct
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureImage<T3>(uint texture, int level, int bufSize, T3[,] pixels)
                where T3 : struct
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureImage<T3>(uint texture, int level, int bufSize, T3[,,] pixels)
                where T3 : struct
        {
            GL.GetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels)
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage<T9>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, T9[] pixels)
                where T9 : struct
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage<T9>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, T9[,] pixels)
                where T9 : struct
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage<T9>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, T9[,,] pixels)
                where T9 : struct
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels)
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage<T9>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, T9[] pixels)
                where T9 : struct
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage<T9>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, T9[,] pixels)
                where T9 : struct
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetCompressedTextureSubImage<T9>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, T9[,,] pixels)
                where T9 : struct
        {
            GL.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public void GetConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, IntPtr image)
        {
            GL.GetConvolutionFilter(target, format, type, image);
        }

        public void GetConvolutionFilter<T3>(ConvolutionTarget target, PixelFormat format, PixelType type, T3[] image)
                where T3 : struct
        {
            GL.GetConvolutionFilter(target, format, type, image);
        }

        public void GetConvolutionFilter<T3>(ConvolutionTarget target, PixelFormat format, PixelType type, T3[,] image)
                where T3 : struct
        {
            GL.GetConvolutionFilter(target, format, type, image);
        }

        public void GetConvolutionFilter<T3>(ConvolutionTarget target, PixelFormat format, PixelType type, T3[,,] image)
                where T3 : struct
        {
            GL.GetConvolutionFilter(target, format, type, image);
        }

        public void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, Single[] @params)
        {
            GL.GetConvolutionParameter(target, pname, @params);
        }

        public void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, Int32[] @params)
        {
            GL.GetConvolutionParameter(target, pname, @params);
        }

        public int GetDebugMessageLog(int count, int bufSize, DebugSource[] sources, DebugType[] types, Int32[] ids, DebugSeverity[] severities, Int32[] lengths, StringBuilder messageLog)
        {
            return GL.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
        }

        public int GetDebugMessageLog(uint count, int bufSize, DebugSource[] sources, DebugType[] types, UInt32[] ids, DebugSeverity[] severities, Int32[] lengths, StringBuilder messageLog)
        {
            return GL.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
        }

        public void GetDouble(GetIndexedPName target, int index, Double[] data)
        {
            GL.GetDouble(target, index, data);
        }

        public void GetDouble(GetIndexedPName target, uint index, Double[] data)
        {
            GL.GetDouble(target, index, data);
        }

        public double GetDouble(GetPName pname)
        {
            return GL.GetDouble(pname);
        }

        public void GetDouble(GetPName pname, Double[] data)
        {
            GL.GetDouble(pname, data);
        }

        public ErrorCode GetError()
        {
            return GL.GetError();
        }

        public void GetFloat(GetIndexedPName target, int index, Single[] data)
        {
            GL.GetFloat(target, index, data);
        }

        public void GetFloat(GetIndexedPName target, uint index, Single[] data)
        {
            GL.GetFloat(target, index, data);
        }

        public float GetFloat(GetPName pname)
        {
            return GL.GetFloat(pname);
        }

        public void GetFloat(GetPName pname, Single[] data)
        {
            GL.GetFloat(pname, data);
        }

        public int GetFragDataIndex(int program, string name)
        {
            return GL.GetFragDataIndex(program, name);
        }

        public int GetFragDataIndex(uint program, string name)
        {
            return GL.GetFragDataIndex(program, name);
        }

        public int GetFragDataLocation(int program, string name)
        {
            return GL.GetFragDataLocation(program, name);
        }

        public int GetFragDataLocation(uint program, string name)
        {
            return GL.GetFragDataLocation(program, name);
        }

        public void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferAttachment attachment, FramebufferParameterName pname, Int32[] @params)
        {
            GL.GetFramebufferAttachmentParameter(target, attachment, pname, @params);
        }

        public void GenProgramPipelines(int n, UInt32[] pipelines)
        {
            GL.GenProgramPipelines(n, pipelines);
        }

        public int GenQuery()
        {
            return GL.GenQuery();
        }

        public void GenQueries(int n, Int32[] ids)
        {
            GL.GenQueries(n, ids);
        }

        public void GenQueries(int n, UInt32[] ids)
        {
            GL.GenQueries(n, ids);
        }

        public int GenRenderbuffer()
        {
            return GL.GenRenderbuffer();
        }

        public void GenRenderbuffers(int n, Int32[] renderbuffers)
        {
            GL.GenRenderbuffers(n, renderbuffers);
        }

        public void GenRenderbuffers(int n, UInt32[] renderbuffers)
        {
            GL.GenRenderbuffers(n, renderbuffers);
        }

        public int GenSampler()
        {
            return GL.GenSampler();
        }

        public void GenSamplers(int count, Int32[] samplers)
        {
            GL.GenSamplers(count, samplers);
        }

        public void GenSamplers(int count, UInt32[] samplers)
        {
            GL.GenSamplers(count, samplers);
        }

        public int GenTexture()
        {
            return GL.GenTexture();
        }

        public void GenTextures(int n, Int32[] textures)
        {
            GL.GenTextures(n, textures);
        }

        public void GenTextures(int n, UInt32[] textures)
        {
            GL.GenTextures(n, textures);
        }

        public int GenTransformFeedback()
        {
            return GL.GenTransformFeedback();
        }

        public void GenTransformFeedbacks(int n, Int32[] ids)
        {
            GL.GenTransformFeedbacks(n, ids);
        }

        public void GenTransformFeedbacks(int n, UInt32[] ids)
        {
            GL.GenTransformFeedbacks(n, ids);
        }

        public int GenVertexArray()
        {
            return GL.GenVertexArray();
        }

        public void GenVertexArrays(int n, Int32[] arrays)
        {
            GL.GenVertexArrays(n, arrays);
        }

        public void GenVertexArrays(int n, UInt32[] arrays)
        {
            GL.GenVertexArrays(n, arrays);
        }

        public void GetActiveAtomicCounterBuffer(int program, int bufferIndex, AtomicCounterBufferParameter pname, Int32[] @params)
        {
            GL.GetActiveAtomicCounterBuffer(program, bufferIndex, pname, @params);
        }

        public void GetActiveAtomicCounterBuffer(uint program, uint bufferIndex, AtomicCounterBufferParameter pname, Int32[] @params)
        {
            GL.GetActiveAtomicCounterBuffer(program, bufferIndex, pname, @params);
        }

        public void GetActiveSubroutineUniform(int program, ShaderType shadertype, int index, ActiveSubroutineUniformParameter pname, Int32[] values)
        {
            GL.GetActiveSubroutineUniform(program, shadertype, index, pname, values);
        }

        public void GetActiveSubroutineUniform(uint program, ShaderType shadertype, uint index, ActiveSubroutineUniformParameter pname, Int32[] values)
        {
            GL.GetActiveSubroutineUniform(program, shadertype, index, pname, values);
        }

        public void GetActiveUniformBlock(int program, int uniformBlockIndex, ActiveUniformBlockParameter pname, Int32[] @params)
        {
            GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, @params);
        }

        public void GetActiveUniformBlock(uint program, uint uniformBlockIndex, ActiveUniformBlockParameter pname, Int32[] @params)
        {
            GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, @params);
        }

        public void GetActiveUniforms(int program, int uniformCount, Int32[] uniformIndices, ActiveUniformParameter pname, Int32[] @params)
        {
            GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
        }

        public void GetActiveUniforms(uint program, int uniformCount, UInt32[] uniformIndices, ActiveUniformParameter pname, Int32[] @params)
        {
            GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
        }

        public int GetAttribLocation(int program, string name)
        {
            return GL.GetAttribLocation(program, name);
        }

        public int GetAttribLocation(uint program, string name)
        {
            return GL.GetAttribLocation(program, name);
        }

        public void GetBoolean(GetIndexedPName target, int index, bool[] data)
        {
            GL.GetBoolean(target, index, data);
        }

        public void GetBoolean(GetIndexedPName target, uint index, bool[] data)
        {
            GL.GetBoolean(target, index, data);
        }

        public bool GetBoolean(GetPName pname)
        {
            return GL.GetBoolean(pname);
        }

        public void GetBoolean(GetPName pname, bool[] data)
        {
            GL.GetBoolean(pname, data);
        }

        public void GetBufferParameter(BufferTarget target, BufferParameterName pname, Int64[] @params)
        {
            GL.GetBufferParameter(target, pname, @params);
        }

        public void GetBufferParameter(BufferTarget target, BufferParameterName pname, Int32[] @params)
        {
            GL.GetBufferParameter(target, pname, @params);
        }

        public void GetBufferPointer(BufferTarget target, BufferPointer pname, IntPtr @params)
        {
            GL.GetBufferPointer(target, pname, @params);
        }

        public void GetBufferPointer<T2>(BufferTarget target, BufferPointer pname, T2[] @params)
                where T2 : struct
        {
            GL.GetBufferPointer(target, pname, @params);
        }

        public void GetBufferPointer<T2>(BufferTarget target, BufferPointer pname, T2[,] @params)
                where T2 : struct
        {
            GL.GetBufferPointer(target, pname, @params);
        }

        public void GetBufferPointer<T2>(BufferTarget target, BufferPointer pname, T2[,,] @params)
                where T2 : struct
        {
            GL.GetBufferPointer(target, pname, @params);
        }

        public void GetBufferSubData(BufferTarget target, IntPtr offset, int size, IntPtr data)
        {
            GL.GetBufferSubData(target, offset, size, data);
        }

        public void DrawRangeElementsBaseVertex<T5>(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, T5[,] indices, int basevertex)
                where T5 : struct
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DrawRangeElementsBaseVertex<T5>(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, T5[,,] indices, int basevertex)
                where T5 : struct
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DrawTransformFeedback(PrimitiveType mode, int id)
        {
            GL.DrawTransformFeedback(mode, id);
        }

        public void DrawTransformFeedback(PrimitiveType mode, uint id)
        {
            GL.DrawTransformFeedback(mode, id);
        }

        public void DrawTransformFeedbackInstanced(PrimitiveType mode, int id, int instancecount)
        {
            GL.DrawTransformFeedbackInstanced(mode, id, instancecount);
        }

        public void DrawTransformFeedbackInstanced(PrimitiveType mode, uint id, int instancecount)
        {
            GL.DrawTransformFeedbackInstanced(mode, id, instancecount);
        }

        public void DrawTransformFeedbackStream(PrimitiveType mode, int id, int stream)
        {
            GL.DrawTransformFeedbackStream(mode, id, stream);
        }

        public void DrawTransformFeedbackStream(PrimitiveType mode, uint id, uint stream)
        {
            GL.DrawTransformFeedbackStream(mode, id, stream);
        }

        public void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, int id, int stream, int instancecount)
        {
            GL.DrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
        }

        public void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, uint id, uint stream, int instancecount)
        {
            GL.DrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
        }

        public void EdgeFlag(bool flag)
        {
            GL.EdgeFlag(flag);
        }

        public void EdgeFlagPointer(int stride, IntPtr pointer)
        {
            GL.EdgeFlagPointer(stride, pointer);
        }

        public void EdgeFlagPointer<T1>(int stride, T1[] pointer)
                where T1 : struct
        {
            GL.EdgeFlagPointer(stride, pointer);
        }

        public void EdgeFlagPointer<T1>(int stride, T1[,] pointer)
                where T1 : struct
        {
            GL.EdgeFlagPointer(stride, pointer);
        }

        public void EdgeFlagPointer<T1>(int stride, T1[,,] pointer)
                where T1 : struct
        {
            GL.EdgeFlagPointer(stride, pointer);
        }

        public void Enable(EnableCap cap)
        {
            GL.Enable(cap);
        }

        public void EnableClientState(ArrayCap array)
        {
            GL.EnableClientState(array);
        }

        public void Enable(IndexedEnableCap target, int index)
        {
            GL.Enable(target, index);
        }

        public void Enable(IndexedEnableCap target, uint index)
        {
            GL.Enable(target, index);
        }

        public void EnableVertexArrayAttrib(int vaobj, int index)
        {
            GL.EnableVertexArrayAttrib(vaobj, index);
        }

        public void EnableVertexArrayAttrib(uint vaobj, uint index)
        {
            GL.EnableVertexArrayAttrib(vaobj, index);
        }

        public void EnableVertexAttribArray(int index)
        {
            GL.EnableVertexAttribArray(index);
        }

        public void EnableVertexAttribArray(uint index)
        {
            GL.EnableVertexAttribArray(index);
        }

        public void End()
        {
            GL.End();
        }

        public void EndConditionalRender()
        {
            GL.EndConditionalRender();
        }

        public void EndList()
        {
            GL.EndList();
        }

        public void EndQuery(QueryTarget target)
        {
            GL.EndQuery(target);
        }

        public void EndQueryIndexed(QueryTarget target, int index)
        {
            GL.EndQueryIndexed(target, index);
        }

        public void EndQueryIndexed(QueryTarget target, uint index)
        {
            GL.EndQueryIndexed(target, index);
        }

        public void EndTransformFeedback()
        {
            GL.EndTransformFeedback();
        }

        public void EvalCoord1(double u)
        {
            GL.EvalCoord1(u);
        }

        public void EvalCoord1(float u)
        {
            GL.EvalCoord1(u);
        }

        public void EvalCoord2(double u, double v)
        {
            GL.EvalCoord2(u, v);
        }

        public void EvalCoord2(Double[] u)
        {
            GL.EvalCoord2(u);
        }

        public void EvalCoord2(float u, float v)
        {
            GL.EvalCoord2(u, v);
        }

        public void EvalCoord2(Single[] u)
        {
            GL.EvalCoord2(u);
        }

        public void EvalMesh1(MeshMode1 mode, int i1, int i2)
        {
            GL.EvalMesh1(mode, i1, i2);
        }

        public void EvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2)
        {
            GL.EvalMesh2(mode, i1, i2, j1, j2);
        }

        public void EvalPoint1(int i)
        {
            GL.EvalPoint1(i);
        }

        public void EvalPoint2(int i, int j)
        {
            GL.EvalPoint2(i, j);
        }

        public void FeedbackBuffer(int size, FeedbackType type, Single[] buffer)
        {
            GL.FeedbackBuffer(size, type, buffer);
        }

        public IntPtr FenceSync(SyncCondition condition, WaitSyncFlags flags)
        {
            return GL.FenceSync(condition, flags);
        }

        public void Finish()
        {
            GL.Finish();
        }

        public void Flush()
        {
            GL.Flush();
        }

        public void FlushMappedBufferRange(BufferTarget target, IntPtr offset, int length)
        {
            GL.FlushMappedBufferRange(target, offset, length);
        }

        public void FlushMappedBufferRange(BufferTarget target, IntPtr offset, IntPtr length)
        {
            GL.FlushMappedBufferRange(target, offset, length);
        }

        public void FlushMappedNamedBufferRange(int buffer, IntPtr offset, int length)
        {
            GL.FlushMappedNamedBufferRange(buffer, offset, length);
        }

        public void FlushMappedNamedBufferRange(uint buffer, IntPtr offset, int length)
        {
            GL.FlushMappedNamedBufferRange(buffer, offset, length);
        }

        public void FogCoord(double coord)
        {
            GL.FogCoord(coord);
        }

        public void FogCoord(float coord)
        {
            GL.FogCoord(coord);
        }

        public void FogCoordPointer(FogPointerType type, int stride, IntPtr pointer)
        {
            GL.FogCoordPointer(type, stride, pointer);
        }

        public void FogCoordPointer<T2>(FogPointerType type, int stride, T2[] pointer)
                where T2 : struct
        {
            GL.FogCoordPointer(type, stride, pointer);
        }

        public void FogCoordPointer<T2>(FogPointerType type, int stride, T2[,] pointer)
                where T2 : struct
        {
            GL.FogCoordPointer(type, stride, pointer);
        }

        public void FogCoordPointer<T2>(FogPointerType type, int stride, T2[,,] pointer)
                where T2 : struct
        {
            GL.FogCoordPointer(type, stride, pointer);
        }

        public void Fog(FogParameter pname, float param)
        {
            GL.Fog(pname, param);
        }

        public void Fog(FogParameter pname, Single[] @params)
        {
            GL.Fog(pname, @params);
        }

        public void Fog(FogParameter pname, int param)
        {
            GL.Fog(pname, param);
        }

        public void Fog(FogParameter pname, Int32[] @params)
        {
            GL.Fog(pname, @params);
        }

        public void FramebufferParameter(FramebufferTarget target, FramebufferDefaultParameter pname, int param)
        {
            GL.FramebufferParameter(target, pname, param);
        }

        public void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer)
        {
            GL.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        }

        public void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
        {
            GL.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        }

        public void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level)
        {
            GL.FramebufferTexture(target, attachment, texture, level);
        }

        public void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
        {
            GL.FramebufferTexture(target, attachment, texture, level);
        }

        public void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level)
        {
            GL.FramebufferTexture1D(target, attachment, textarget, texture, level);
        }

        public void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
        {
            GL.FramebufferTexture1D(target, attachment, textarget, texture, level);
        }

        public void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level)
        {
            GL.FramebufferTexture2D(target, attachment, textarget, texture, level);
        }

        public void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
        {
            GL.FramebufferTexture2D(target, attachment, textarget, texture, level);
        }

        public void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset)
        {
            GL.FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
        }

        public void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset)
        {
            GL.FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
        }

        public void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer)
        {
            GL.FramebufferTextureLayer(target, attachment, texture, level, layer);
        }

        public void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
        {
            GL.FramebufferTextureLayer(target, attachment, texture, level, layer);
        }

        public void FrontFace(FrontFaceDirection mode)
        {
            GL.FrontFace(mode);
        }

        public void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
        {
            GL.Frustum(left, right, bottom, top, zNear, zFar);
        }

        public int GenBuffer()
        {
            return GL.GenBuffer();
        }

        public void GenBuffers(int n, Int32[] buffers)
        {
            GL.GenBuffers(n, buffers);
        }

        public void GenBuffers(int n, UInt32[] buffers)
        {
            GL.GenBuffers(n, buffers);
        }

        public void GenerateMipmap(GenerateMipmapTarget target)
        {
            GL.GenerateMipmap(target);
        }

        public void GenerateTextureMipmap(int texture)
        {
            GL.GenerateTextureMipmap(texture);
        }

        public void GenerateTextureMipmap(uint texture)
        {
            GL.GenerateTextureMipmap(texture);
        }

        public int GenFramebuffer()
        {
            return GL.GenFramebuffer();
        }

        public void GenFramebuffers(int n, Int32[] framebuffers)
        {
            GL.GenFramebuffers(n, framebuffers);
        }

        public void GenFramebuffers(int n, UInt32[] framebuffers)
        {
            GL.GenFramebuffers(n, framebuffers);
        }

        public int GenLists(int range)
        {
            return GL.GenLists(range);
        }

        public int GenProgramPipeline()
        {
            return GL.GenProgramPipeline();
        }

        public void GenProgramPipelines(int n, Int32[] pipelines)
        {
            GL.GenProgramPipelines(n, pipelines);
        }

        public void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, uint baseinstance)
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void DrawElementsInstancedBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices, int instancecount, int baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void DrawElementsInstancedBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices, int instancecount, uint baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void DrawElementsInstancedBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices, int instancecount, int baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void DrawElementsInstancedBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices, int instancecount, uint baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void DrawElementsInstancedBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices, int instancecount, int baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void DrawElementsInstancedBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices, int instancecount, uint baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex)
        {
            GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
        }

        public void DrawElementsInstancedBaseVertex<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices, int instancecount, int basevertex)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
        }

        public void DrawElementsInstancedBaseVertex<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices, int instancecount, int basevertex)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
        }

        public void DrawElementsInstancedBaseVertex<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices, int instancecount, int basevertex)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex, int baseinstance)
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex, uint baseinstance)
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices, int instancecount, int basevertex, int baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices, int instancecount, int basevertex, uint baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices, int instancecount, int basevertex, int baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices, int instancecount, int basevertex, uint baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices, int instancecount, int basevertex, int baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawElementsInstancedBaseVertexBaseInstance<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices, int instancecount, int basevertex, uint baseinstance)
                where T3 : struct
        {
            GL.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        }

        public void DrawPixels(int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            GL.DrawPixels(width, height, format, type, pixels);
        }

        public void DrawPixels<T4>(int width, int height, PixelFormat format, PixelType type, T4[] pixels)
                where T4 : struct
        {
            GL.DrawPixels(width, height, format, type, pixels);
        }

        public void DrawPixels<T4>(int width, int height, PixelFormat format, PixelType type, T4[,] pixels)
                where T4 : struct
        {
            GL.DrawPixels(width, height, format, type, pixels);
        }

        public void DrawPixels<T4>(int width, int height, PixelFormat format, PixelType type, T4[,,] pixels)
                where T4 : struct
        {
            GL.DrawPixels(width, height, format, type, pixels);
        }

        public void DrawRangeElements(PrimitiveType mode, int start, int end, int count, DrawElementsType type, IntPtr indices)
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElements<T5>(PrimitiveType mode, int start, int end, int count, DrawElementsType type, T5[] indices)
                where T5 : struct
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElements<T5>(PrimitiveType mode, int start, int end, int count, DrawElementsType type, T5[,] indices)
                where T5 : struct
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElements<T5>(PrimitiveType mode, int start, int end, int count, DrawElementsType type, T5[,,] indices)
                where T5 : struct
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElements<T5>(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, T5[] indices)
                where T5 : struct
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElements<T5>(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, T5[,] indices)
                where T5 : struct
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElements<T5>(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, T5[,,] indices)
                where T5 : struct
        {
            GL.DrawRangeElements(mode, start, end, count, type, indices);
        }

        public void DrawRangeElementsBaseVertex(PrimitiveType mode, int start, int end, int count, DrawElementsType type, IntPtr indices, int basevertex)
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DrawRangeElementsBaseVertex<T5>(PrimitiveType mode, int start, int end, int count, DrawElementsType type, T5[] indices, int basevertex)
                where T5 : struct
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DrawRangeElementsBaseVertex<T5>(PrimitiveType mode, int start, int end, int count, DrawElementsType type, T5[,] indices, int basevertex)
                where T5 : struct
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DrawRangeElementsBaseVertex<T5>(PrimitiveType mode, int start, int end, int count, DrawElementsType type, T5[,,] indices, int basevertex)
                where T5 : struct
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex)
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DrawRangeElementsBaseVertex<T5>(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, T5[] indices, int basevertex)
                where T5 : struct
        {
            GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public void DepthFunc(DepthFunction func)
        {
            GL.DepthFunc(func);
        }

        public void DepthMask(bool flag)
        {
            GL.DepthMask(flag);
        }

        public void DepthRange(double near, double far)
        {
            GL.DepthRange(near, far);
        }

        public void DepthRangeArray(int first, int count, Double[] v)
        {
            GL.DepthRangeArray(first, count, v);
        }

        public void DepthRangeArray(uint first, int count, Double[] v)
        {
            GL.DepthRangeArray(first, count, v);
        }

        public void DepthRange(float n, float f)
        {
            GL.DepthRange(n, f);
        }

        public void DepthRangeIndexed(int index, double n, double f)
        {
            GL.DepthRangeIndexed(index, n, f);
        }

        public void DepthRangeIndexed(uint index, double n, double f)
        {
            GL.DepthRangeIndexed(index, n, f);
        }

        public void DetachShader(int program, int shader)
        {
            GL.DetachShader(program, shader);
        }

        public void DetachShader(uint program, uint shader)
        {
            GL.DetachShader(program, shader);
        }

        public void Disable(EnableCap cap)
        {
            GL.Disable(cap);
        }

        public void DisableClientState(ArrayCap array)
        {
            GL.DisableClientState(array);
        }

        public void Disable(IndexedEnableCap target, int index)
        {
            GL.Disable(target, index);
        }

        public void Disable(IndexedEnableCap target, uint index)
        {
            GL.Disable(target, index);
        }

        public void DisableVertexArrayAttrib(int vaobj, int index)
        {
            GL.DisableVertexArrayAttrib(vaobj, index);
        }

        public void DisableVertexArrayAttrib(uint vaobj, uint index)
        {
            GL.DisableVertexArrayAttrib(vaobj, index);
        }

        public void DisableVertexAttribArray(int index)
        {
            GL.DisableVertexAttribArray(index);
        }

        public void DisableVertexAttribArray(uint index)
        {
            GL.DisableVertexAttribArray(index);
        }

        public void DispatchCompute(int num_groups_x, int num_groups_y, int num_groups_z)
        {
            GL.DispatchCompute(num_groups_x, num_groups_y, num_groups_z);
        }

        public void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
        {
            GL.DispatchCompute(num_groups_x, num_groups_y, num_groups_z);
        }

        public void DispatchComputeIndirect(IntPtr indirect)
        {
            GL.DispatchComputeIndirect(indirect);
        }

        public void DrawArrays(PrimitiveType mode, int first, int count)
        {
            GL.DrawArrays(mode, first, count);
        }

        public void DrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
        {
            GL.DrawArraysIndirect(mode, indirect);
        }

        public void DrawArraysIndirect<T1>(PrimitiveType mode, T1[] indirect)
                where T1 : struct
        {
            GL.DrawArraysIndirect(mode, indirect);
        }

        public void DrawArraysIndirect<T1>(PrimitiveType mode, T1[,] indirect)
                where T1 : struct
        {
            GL.DrawArraysIndirect(mode, indirect);
        }

        public void DrawArraysIndirect<T1>(PrimitiveType mode, T1[,,] indirect)
                where T1 : struct
        {
            GL.DrawArraysIndirect(mode, indirect);
        }

        public void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount)
        {
            GL.DrawArraysInstanced(mode, first, count, instancecount);
        }

        public void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, int baseinstance)
        {
            GL.DrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
        }

        public void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
        {
            GL.DrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
        }

        public void DrawBuffer(DrawBufferMode buf)
        {
            GL.DrawBuffer(buf);
        }

        public void DrawBuffers(int n, DrawBuffersEnum[] bufs)
        {
            GL.DrawBuffers(n, bufs);
        }

        public void DrawElements(BeginMode mode, int count, DrawElementsType type, int indices)
        {
            GL.DrawElements(mode, count, type, indices);
        }

        public void DrawElements(PrimitiveType mode, int count, DrawElementsType type, int indices)
        {
            GL.DrawElements(mode, count, type, indices);
        }

        public void DrawElements(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices)
        {
            GL.DrawElements(mode, count, type, indices);
        }

        public void DrawElements<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices)
                where T3 : struct
        {
            GL.DrawElements(mode, count, type, indices);
        }

        public void DrawElements<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices)
                where T3 : struct
        {
            GL.DrawElements(mode, count, type, indices);
        }

        public void DrawElements<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices)
                where T3 : struct
        {
            GL.DrawElements(mode, count, type, indices);
        }

        public void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex)
        {
            GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }

        public void DrawElementsBaseVertex<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices, int basevertex)
                where T3 : struct
        {
            GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }

        public void DrawElementsBaseVertex<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices, int basevertex)
                where T3 : struct
        {
            GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }

        public void DrawElementsBaseVertex<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices, int basevertex)
                where T3 : struct
        {
            GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }

        public void DrawElementsIndirect(PrimitiveType mode, All type, IntPtr indirect)
        {
            GL.DrawElementsIndirect(mode, type, indirect);
        }

        public void DrawElementsIndirect<T2>(PrimitiveType mode, All type, T2[] indirect)
                where T2 : struct
        {
            GL.DrawElementsIndirect(mode, type, indirect);
        }

        public void DrawElementsIndirect<T2>(PrimitiveType mode, All type, T2[,] indirect)
                where T2 : struct
        {
            GL.DrawElementsIndirect(mode, type, indirect);
        }

        public void DrawElementsIndirect<T2>(PrimitiveType mode, All type, T2[,,] indirect)
                where T2 : struct
        {
            GL.DrawElementsIndirect(mode, type, indirect);
        }

        public void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount)
        {
            GL.DrawElementsInstanced(mode, count, type, indices, instancecount);
        }

        public void DrawElementsInstanced<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[] indices, int instancecount)
                where T3 : struct
        {
            GL.DrawElementsInstanced(mode, count, type, indices, instancecount);
        }

        public void DrawElementsInstanced<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,] indices, int instancecount)
                where T3 : struct
        {
            GL.DrawElementsInstanced(mode, count, type, indices, instancecount);
        }

        public void DrawElementsInstanced<T3>(PrimitiveType mode, int count, DrawElementsType type, T3[,,] indices, int instancecount)
                where T3 : struct
        {
            GL.DrawElementsInstanced(mode, count, type, indices, instancecount);
        }

        public void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int baseinstance)
        {
            GL.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        }

        public void CreateRenderbuffers(int n, UInt32[] renderbuffers)
        {
            GL.CreateRenderbuffers(n, renderbuffers);
        }

        public void CreateSamplers(int n, Int32[] samplers)
        {
            GL.CreateSamplers(n, samplers);
        }

        public void CreateSamplers(int n, UInt32[] samplers)
        {
            GL.CreateSamplers(n, samplers);
        }

        public int CreateShader(ShaderType type)
        {
            return GL.CreateShader(type);
        }

        public int CreateShaderProgram(ShaderType type, int count, String[] strings)
        {
            return GL.CreateShaderProgram(type, count, strings);
        }

        public void CreateTextures(TextureTarget target, int n, Int32[] textures)
        {
            GL.CreateTextures(target, n, textures);
        }

        public void CreateTextures(TextureTarget target, int n, UInt32[] textures)
        {
            GL.CreateTextures(target, n, textures);
        }

        public void CreateTransformFeedbacks(int n, Int32[] ids)
        {
            GL.CreateTransformFeedbacks(n, ids);
        }

        public void CreateTransformFeedbacks(int n, UInt32[] ids)
        {
            GL.CreateTransformFeedbacks(n, ids);
        }

        public void CreateVertexArrays(int n, Int32[] arrays)
        {
            GL.CreateVertexArrays(n, arrays);
        }

        public void CreateVertexArrays(int n, UInt32[] arrays)
        {
            GL.CreateVertexArrays(n, arrays);
        }

        public void CullFace(CullFaceMode mode)
        {
            GL.CullFace(mode);
        }

        public void DebugMessageCallback(DebugProc callback, IntPtr userParam)
        {
            GL.DebugMessageCallback(callback, userParam);
        }

        public void DebugMessageCallback<T1>(DebugProc callback, T1[] userParam)
                where T1 : struct
        {
            GL.DebugMessageCallback(callback, userParam);
        }

        public void DebugMessageCallback<T1>(DebugProc callback, T1[,] userParam)
                where T1 : struct
        {
            GL.DebugMessageCallback(callback, userParam);
        }

        public void DebugMessageCallback<T1>(DebugProc callback, T1[,,] userParam)
                where T1 : struct
        {
            GL.DebugMessageCallback(callback, userParam);
        }

        public void DebugMessageControl(DebugSourceControl source, DebugTypeControl type, DebugSeverityControl severity, int count, Int32[] ids, bool enabled)
        {
            GL.DebugMessageControl(source, type, severity, count, ids, enabled);
        }

        public void DebugMessageControl(DebugSourceControl source, DebugTypeControl type, DebugSeverityControl severity, int count, UInt32[] ids, bool enabled)
        {
            GL.DebugMessageControl(source, type, severity, count, ids, enabled);
        }

        public void DebugMessageInsert(DebugSourceExternal source, DebugType type, int id, DebugSeverity severity, int length, string buf)
        {
            GL.DebugMessageInsert(source, type, id, severity, length, buf);
        }

        public void DebugMessageInsert(DebugSourceExternal source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
        {
            GL.DebugMessageInsert(source, type, id, severity, length, buf);
        }

        public void DeleteBuffer(int buffers)
        {
            GL.DeleteBuffer(buffers);
        }

        public void DeleteBuffer(uint buffers)
        {
            GL.DeleteBuffer(buffers);
        }

        public void DeleteBuffers(int n, Int32[] buffers)
        {
            GL.DeleteBuffers(n, buffers);
        }

        public void DeleteBuffers(int n, UInt32[] buffers)
        {
            GL.DeleteBuffers(n, buffers);
        }

        public void DeleteFramebuffer(int framebuffers)
        {
            GL.DeleteFramebuffer(framebuffers);
        }

        public void DeleteFramebuffer(uint framebuffers)
        {
            GL.DeleteFramebuffer(framebuffers);
        }

        public void DeleteFramebuffers(int n, Int32[] framebuffers)
        {
            GL.DeleteFramebuffers(n, framebuffers);
        }

        public void DeleteFramebuffers(int n, UInt32[] framebuffers)
        {
            GL.DeleteFramebuffers(n, framebuffers);
        }

        public void DeleteLists(int list, int range)
        {
            GL.DeleteLists(list, range);
        }

        public void DeleteLists(uint list, int range)
        {
            GL.DeleteLists(list, range);
        }

        public void DeleteProgram(int program)
        {
            GL.DeleteProgram(program);
        }

        public void DeleteProgram(uint program)
        {
            GL.DeleteProgram(program);
        }

        public void DeleteProgramPipeline(int pipelines)
        {
            GL.DeleteProgramPipeline(pipelines);
        }

        public void DeleteProgramPipeline(uint pipelines)
        {
            GL.DeleteProgramPipeline(pipelines);
        }

        public void DeleteProgramPipelines(int n, Int32[] pipelines)
        {
            GL.DeleteProgramPipelines(n, pipelines);
        }

        public void DeleteProgramPipelines(int n, UInt32[] pipelines)
        {
            GL.DeleteProgramPipelines(n, pipelines);
        }

        public void DeleteQuery(int ids)
        {
            GL.DeleteQuery(ids);
        }

        public void DeleteQuery(uint ids)
        {
            GL.DeleteQuery(ids);
        }

        public void DeleteQueries(int n, Int32[] ids)
        {
            GL.DeleteQueries(n, ids);
        }

        public void DeleteQueries(int n, UInt32[] ids)
        {
            GL.DeleteQueries(n, ids);
        }

        public void DeleteRenderbuffer(int renderbuffers)
        {
            GL.DeleteRenderbuffer(renderbuffers);
        }

        public void DeleteRenderbuffer(uint renderbuffers)
        {
            GL.DeleteRenderbuffer(renderbuffers);
        }

        public void DeleteRenderbuffers(int n, Int32[] renderbuffers)
        {
            GL.DeleteRenderbuffers(n, renderbuffers);
        }

        public void DeleteRenderbuffers(int n, UInt32[] renderbuffers)
        {
            GL.DeleteRenderbuffers(n, renderbuffers);
        }

        public void DeleteSampler(int samplers)
        {
            GL.DeleteSampler(samplers);
        }

        public void DeleteSampler(uint samplers)
        {
            GL.DeleteSampler(samplers);
        }

        public void DeleteSamplers(int count, Int32[] samplers)
        {
            GL.DeleteSamplers(count, samplers);
        }

        public void DeleteSamplers(int count, UInt32[] samplers)
        {
            GL.DeleteSamplers(count, samplers);
        }

        public void DeleteShader(int shader)
        {
            GL.DeleteShader(shader);
        }

        public void DeleteShader(uint shader)
        {
            GL.DeleteShader(shader);
        }

        public void DeleteSync(IntPtr sync)
        {
            GL.DeleteSync(sync);
        }

        public void DeleteTexture(int textures)
        {
            GL.DeleteTexture(textures);
        }

        public void DeleteTexture(uint textures)
        {
            GL.DeleteTexture(textures);
        }

        public void DeleteTextures(int n, Int32[] textures)
        {
            GL.DeleteTextures(n, textures);
        }

        public void DeleteTextures(int n, UInt32[] textures)
        {
            GL.DeleteTextures(n, textures);
        }

        public void DeleteTransformFeedback(int ids)
        {
            GL.DeleteTransformFeedback(ids);
        }

        public void DeleteTransformFeedback(uint ids)
        {
            GL.DeleteTransformFeedback(ids);
        }

        public void DeleteTransformFeedbacks(int n, Int32[] ids)
        {
            GL.DeleteTransformFeedbacks(n, ids);
        }

        public void DeleteTransformFeedbacks(int n, UInt32[] ids)
        {
            GL.DeleteTransformFeedbacks(n, ids);
        }

        public void DeleteVertexArray(int arrays)
        {
            GL.DeleteVertexArray(arrays);
        }

        public void DeleteVertexArray(uint arrays)
        {
            GL.DeleteVertexArray(arrays);
        }

        public void DeleteVertexArrays(int n, Int32[] arrays)
        {
            GL.DeleteVertexArrays(n, arrays);
        }

        public void DeleteVertexArrays(int n, UInt32[] arrays)
        {
            GL.DeleteVertexArrays(n, arrays);
        }

        public void CompressedTextureSubImage1D(int texture, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage1D<T6>(int texture, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[] data)
                where T6 : struct
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage1D<T6>(int texture, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[,] data)
                where T6 : struct
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage1D<T6>(int texture, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[,,] data)
                where T6 : struct
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage1D<T6>(uint texture, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[] data)
                where T6 : struct
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage1D<T6>(uint texture, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[,] data)
                where T6 : struct
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage1D<T6>(uint texture, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[,,] data)
                where T6 : struct
        {
            GL.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D<T8>(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[] data)
                where T8 : struct
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D<T8>(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[,] data)
                where T8 : struct
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D<T8>(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[,,] data)
                where T8 : struct
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D<T8>(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[] data)
                where T8 : struct
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D<T8>(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[,] data)
                where T8 : struct
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage2D<T8>(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[,,] data)
                where T8 : struct
        {
            GL.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[] data)
                where T10 : struct
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[,] data)
                where T10 : struct
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[,,] data)
                where T10 : struct
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[] data)
                where T10 : struct
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[,] data)
                where T10 : struct
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTextureSubImage3D<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[,,] data)
                where T10 : struct
        {
            GL.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void ConvolutionFilter1D(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr image)
        {
            GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
        }

        public void ConvolutionFilter1D<T5>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, T5[] image)
                where T5 : struct
        {
            GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
        }

        public void ConvolutionFilter1D<T5>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, T5[,] image)
                where T5 : struct
        {
            GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
        }

        public void ConvolutionFilter1D<T5>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, T5[,,] image)
                where T5 : struct
        {
            GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
        }

        public void ConvolutionFilter2D(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr image)
        {
            GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
        }

        public void ConvolutionFilter2D<T6>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, T6[] image)
                where T6 : struct
        {
            GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
        }

        public void ConvolutionFilter2D<T6>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, T6[,] image)
                where T6 : struct
        {
            GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
        }

        public void ConvolutionFilter2D<T6>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, T6[,,] image)
                where T6 : struct
        {
            GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
        }

        public void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, float @params)
        {
            GL.ConvolutionParameter(target, pname, @params);
        }

        public void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, Single[] @params)
        {
            GL.ConvolutionParameter(target, pname, @params);
        }

        public void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, int @params)
        {
            GL.ConvolutionParameter(target, pname, @params);
        }

        public void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, Int32[] @params)
        {
            GL.ConvolutionParameter(target, pname, @params);
        }

        public void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, int size)
        {
            GL.CopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
        }

        public void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
        {
            GL.CopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
        }

        public void CopyColorSubTable(ColorTableTarget target, int start, int x, int y, int width)
        {
            GL.CopyColorSubTable(target, start, x, y, width);
        }

        public void CopyColorTable(ColorTableTarget target, PixelInternalFormat internalformat, int x, int y, int width)
        {
            GL.CopyColorTable(target, internalformat, x, y, width);
        }

        public void CopyConvolutionFilter1D(ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width)
        {
            GL.CopyConvolutionFilter1D(target, internalformat, x, y, width);
        }

        public void CopyConvolutionFilter2D(ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width, int height)
        {
            GL.CopyConvolutionFilter2D(target, internalformat, x, y, width, height);
        }

        public void CopyImageSubData(int srcName, ImageTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, int dstName, ImageTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
        {
            GL.CopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        }

        public void CopyImageSubData(uint srcName, ImageTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, ImageTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
        {
            GL.CopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        }

        public void CopyNamedBufferSubData(int readBuffer, int writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size)
        {
            GL.CopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
        }

        public void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size)
        {
            GL.CopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
        }

        public void CopyPixels(int x, int y, int width, int height, PixelCopyType type)
        {
            GL.CopyPixels(x, y, width, height, type);
        }

        public void CopyTexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border)
        {
            GL.CopyTexImage1D(target, level, internalformat, x, y, width, border);
        }

        public void CopyTexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border)
        {
            GL.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        }

        public void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width)
        {
            GL.CopyTexSubImage1D(target, level, xoffset, x, y, width);
        }

        public void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            GL.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }

        public void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            GL.CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }

        public void CopyTextureSubImage1D(int texture, int level, int xoffset, int x, int y, int width)
        {
            GL.CopyTextureSubImage1D(texture, level, xoffset, x, y, width);
        }

        public void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
        {
            GL.CopyTextureSubImage1D(texture, level, xoffset, x, y, width);
        }

        public void CopyTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            GL.CopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
        }

        public void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            GL.CopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
        }

        public void CopyTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            GL.CopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
        }

        public void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            GL.CopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
        }

        public void CreateBuffers(int n, Int32[] buffers)
        {
            GL.CreateBuffers(n, buffers);
        }

        public void CreateBuffers(int n, UInt32[] buffers)
        {
            GL.CreateBuffers(n, buffers);
        }

        public void CreateFramebuffers(int n, Int32[] framebuffers)
        {
            GL.CreateFramebuffers(n, framebuffers);
        }

        public void CreateFramebuffers(int n, UInt32[] framebuffers)
        {
            GL.CreateFramebuffers(n, framebuffers);
        }

        public int CreateProgram()
        {
            return GL.CreateProgram();
        }

        public void CreateProgramPipelines(int n, Int32[] pipelines)
        {
            GL.CreateProgramPipelines(n, pipelines);
        }

        public void CreateProgramPipelines(int n, UInt32[] pipelines)
        {
            GL.CreateProgramPipelines(n, pipelines);
        }

        public void CreateQueries(QueryTarget target, int n, Int32[] ids)
        {
            GL.CreateQueries(target, n, ids);
        }

        public void CreateQueries(QueryTarget target, int n, UInt32[] ids)
        {
            GL.CreateQueries(target, n, ids);
        }

        public void CreateRenderbuffers(int n, Int32[] renderbuffers)
        {
            GL.CreateRenderbuffers(n, renderbuffers);
        }

        public void Color4(double red, double green, double blue, double alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(Double[] v)
        {
            GL.Color4(v);
        }

        public void Color4(float red, float green, float blue, float alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(Single[] v)
        {
            GL.Color4(v);
        }

        public void Color4(int red, int green, int blue, int alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(Int32[] v)
        {
            GL.Color4(v);
        }

        public void Color4(short red, short green, short blue, short alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(Int16[] v)
        {
            GL.Color4(v);
        }

        public void Color4(byte red, byte green, byte blue, byte alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(Byte[] v)
        {
            GL.Color4(v);
        }

        public void Color4(uint red, uint green, uint blue, uint alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(UInt32[] v)
        {
            GL.Color4(v);
        }

        public void Color4(ushort red, ushort green, ushort blue, ushort alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(UInt16[] v)
        {
            GL.Color4(v);
        }

        public void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            GL.ColorMask(red, green, blue, alpha);
        }

        public void ColorMask(int index, bool r, bool g, bool b, bool a)
        {
            GL.ColorMask(index, r, g, b, a);
        }

        public void ColorMask(uint index, bool r, bool g, bool b, bool a)
        {
            GL.ColorMask(index, r, g, b, a);
        }

        public void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
        {
            GL.ColorMaterial(face, mode);
        }

        public void ColorP3(PackedPointerType type, int color)
        {
            GL.ColorP3(type, color);
        }

        public void ColorP3(PackedPointerType type, uint color)
        {
            GL.ColorP3(type, color);
        }

        public void ColorP4(PackedPointerType type, int color)
        {
            GL.ColorP4(type, color);
        }

        public void ColorP4(PackedPointerType type, uint color)
        {
            GL.ColorP4(type, color);
        }

        public void ColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
        {
            GL.ColorPointer(size, type, stride, pointer);
        }

        public void ColorPointer<T3>(int size, ColorPointerType type, int stride, T3[] pointer)
                where T3 : struct
        {
            GL.ColorPointer(size, type, stride, pointer);
        }

        public void ColorPointer<T3>(int size, ColorPointerType type, int stride, T3[,] pointer)
                where T3 : struct
        {
            GL.ColorPointer(size, type, stride, pointer);
        }

        public void ColorPointer<T3>(int size, ColorPointerType type, int stride, T3[,,] pointer)
                where T3 : struct
        {
            GL.ColorPointer(size, type, stride, pointer);
        }

        public void ColorSubTable(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, IntPtr data)
        {
            GL.ColorSubTable(target, start, count, format, type, data);
        }

        public void ColorSubTable<T5>(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, T5[] data)
                where T5 : struct
        {
            GL.ColorSubTable(target, start, count, format, type, data);
        }

        public void ColorSubTable<T5>(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, T5[,] data)
                where T5 : struct
        {
            GL.ColorSubTable(target, start, count, format, type, data);
        }

        public void ColorSubTable<T5>(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, T5[,,] data)
                where T5 : struct
        {
            GL.ColorSubTable(target, start, count, format, type, data);
        }

        public void ColorTable(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr table)
        {
            GL.ColorTable(target, internalformat, width, format, type, table);
        }

        public void ColorTable<T5>(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, T5[] table)
                where T5 : struct
        {
            GL.ColorTable(target, internalformat, width, format, type, table);
        }

        public void ColorTable<T5>(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, T5[,] table)
                where T5 : struct
        {
            GL.ColorTable(target, internalformat, width, format, type, table);
        }

        public void ColorTable<T5>(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, T5[,,] table)
                where T5 : struct
        {
            GL.ColorTable(target, internalformat, width, format, type, table);
        }

        public void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, Single[] @params)
        {
            GL.ColorTableParameter(target, pname, @params);
        }

        public void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, Int32[] @params)
        {
            GL.ColorTableParameter(target, pname, @params);
        }

        public void CompileShader(int shader)
        {
            GL.CompileShader(shader);
        }

        public void CompileShader(uint shader)
        {
            GL.CompileShader(shader);
        }

        public void CompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, IntPtr data)
        {
            GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
        }

        public void CompressedTexImage1D<T6>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, T6[] data)
                where T6 : struct
        {
            GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
        }

        public void CompressedTexImage1D<T6>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, T6[,] data)
                where T6 : struct
        {
            GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
        }

        public void CompressedTexImage1D<T6>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, T6[,,] data)
                where T6 : struct
        {
            GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
        }

        public void CompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }

        public void CompressedTexImage2D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, T7[] data)
                where T7 : struct
        {
            GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }

        public void CompressedTexImage2D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, T7[,] data)
                where T7 : struct
        {
            GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }

        public void CompressedTexImage2D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, T7[,,] data)
                where T7 : struct
        {
            GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }

        public void CompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        }

        public void CompressedTexImage3D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, T8[] data)
                where T8 : struct
        {
            GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        }

        public void CompressedTexImage3D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, T8[,] data)
                where T8 : struct
        {
            GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        }

        public void CompressedTexImage3D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, T8[,,] data)
                where T8 : struct
        {
            GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        }

        public void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[] data)
                where T6 : struct
        {
            GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[,] data)
                where T6 : struct
        {
            GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, T6[,,] data)
                where T6 : struct
        {
            GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }

        public void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[] data)
                where T8 : struct
        {
            GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[,] data)
                where T8 : struct
        {
            GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, T8[,,] data)
                where T8 : struct
        {
            GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
        {
            GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[] data)
                where T10 : struct
        {
            GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[,] data)
                where T10 : struct
        {
            GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void CompressedTexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, T10[,,] data)
                where T10 : struct
        {
            GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void ClearNamedBufferData(uint buffer, PixelInternalFormat internalformat, PixelFormat format, All type, IntPtr data)
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void ClearNamedBufferData<T4>(uint buffer, PixelInternalFormat internalformat, PixelFormat format, All type, T4[] data)
                where T4 : struct
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void ClearNamedBufferData<T4>(uint buffer, PixelInternalFormat internalformat, PixelFormat format, All type, T4[,] data)
                where T4 : struct
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void ClearNamedBufferData<T4>(uint buffer, PixelInternalFormat internalformat, PixelFormat format, All type, T4[,,] data)
                where T4 : struct
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void ClearNamedBufferSubData(int buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, IntPtr data)
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedBufferSubData<T6>(int buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[] data)
                where T6 : struct
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedBufferSubData<T6>(int buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[,] data)
                where T6 : struct
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedBufferSubData<T6>(int buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[,,] data)
                where T6 : struct
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedBufferSubData(uint buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, IntPtr data)
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedBufferSubData<T6>(uint buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[] data)
                where T6 : struct
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedBufferSubData<T6>(uint buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[,] data)
                where T6 : struct
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedBufferSubData<T6>(uint buffer, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[,,] data)
                where T6 : struct
        {
            GL.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        }

        public void ClearNamedFramebuffer(int framebuffer, ClearBufferCombined buffer, float depth, int stencil)
        {
            GL.ClearNamedFramebuffer(framebuffer, buffer, depth, stencil);
        }

        public void ClearNamedFramebuffer(uint framebuffer, ClearBufferCombined buffer, float depth, int stencil)
        {
            GL.ClearNamedFramebuffer(framebuffer, buffer, depth, stencil);
        }

        public void ClearNamedFramebuffer(int framebuffer, ClearBuffer buffer, int drawbuffer, Single[] value)
        {
            GL.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);
        }

        public void ClearNamedFramebuffer(uint framebuffer, ClearBuffer buffer, int drawbuffer, Single[] value)
        {
            GL.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);
        }

        public void ClearNamedFramebuffer(int framebuffer, ClearBuffer buffer, int drawbuffer, Int32[] value)
        {
            GL.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);
        }

        public void ClearNamedFramebuffer(uint framebuffer, ClearBuffer buffer, int drawbuffer, Int32[] value)
        {
            GL.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);
        }

        public void ClearNamedFramebuffer(uint framebuffer, ClearBuffer buffer, int drawbuffer, UInt32[] value)
        {
            GL.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);
        }

        public void ClearStencil(int s)
        {
            GL.ClearStencil(s);
        }

        public void ClearTexImage(int texture, int level, PixelFormat format, PixelType type, IntPtr data)
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexImage<T4>(int texture, int level, PixelFormat format, PixelType type, T4[] data)
                where T4 : struct
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexImage<T4>(int texture, int level, PixelFormat format, PixelType type, T4[,] data)
                where T4 : struct
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexImage<T4>(int texture, int level, PixelFormat format, PixelType type, T4[,,] data)
                where T4 : struct
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexImage(uint texture, int level, PixelFormat format, PixelType type, IntPtr data)
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexImage<T4>(uint texture, int level, PixelFormat format, PixelType type, T4[] data)
                where T4 : struct
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexImage<T4>(uint texture, int level, PixelFormat format, PixelType type, T4[,] data)
                where T4 : struct
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexImage<T4>(uint texture, int level, PixelFormat format, PixelType type, T4[,,] data)
                where T4 : struct
        {
            GL.ClearTexImage(texture, level, format, type, data);
        }

        public void ClearTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data)
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClearTexSubImage<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[] data)
                where T10 : struct
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClearTexSubImage<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,] data)
                where T10 : struct
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClearTexSubImage<T10>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,,] data)
                where T10 : struct
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data)
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClearTexSubImage<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[] data)
                where T10 : struct
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClearTexSubImage<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,] data)
                where T10 : struct
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClearTexSubImage<T10>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T10[,,] data)
                where T10 : struct
        {
            GL.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public void ClientActiveTexture(TextureUnit texture)
        {
            GL.ClientActiveTexture(texture);
        }

        public WaitSyncStatus ClientWaitSync(IntPtr sync, ClientWaitSyncFlags flags, long timeout)
        {
            return GL.ClientWaitSync(sync, flags, timeout);
        }

        public WaitSyncStatus ClientWaitSync(IntPtr sync, ClientWaitSyncFlags flags, ulong timeout)
        {
            return GL.ClientWaitSync(sync, flags, timeout);
        }

        public void ClipControl(ClipOrigin origin, ClipDepthMode depth)
        {
            GL.ClipControl(origin, depth);
        }

        public void ClipPlane(ClipPlaneName plane, Double[] equation)
        {
            GL.ClipPlane(plane, equation);
        }

        public void Color3(sbyte red, sbyte green, sbyte blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(SByte[] v)
        {
            GL.Color3(v);
        }

        public void Color3(double red, double green, double blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(Double[] v)
        {
            GL.Color3(v);
        }

        public void Color3(float red, float green, float blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(Single[] v)
        {
            GL.Color3(v);
        }

        public void Color3(int red, int green, int blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(Int32[] v)
        {
            GL.Color3(v);
        }

        public void Color3(short red, short green, short blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(Int16[] v)
        {
            GL.Color3(v);
        }

        public void Color3(byte red, byte green, byte blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(Byte[] v)
        {
            GL.Color3(v);
        }

        public void Color3(uint red, uint green, uint blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(UInt32[] v)
        {
            GL.Color3(v);
        }

        public void Color3(ushort red, ushort green, ushort blue)
        {
            GL.Color3(red, green, blue);
        }

        public void Color3(UInt16[] v)
        {
            GL.Color3(v);
        }

        public void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha)
        {
            GL.Color4(red, green, blue, alpha);
        }

        public void Color4(SByte[] v)
        {
            GL.Color4(v);
        }

        public void BlendFuncSeparate(int buf, BlendingFactorSrc srcRGB, BlendingFactorDest dstRGB, BlendingFactorSrc srcAlpha, BlendingFactorDest dstAlpha)
        {
            GL.BlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        }

        public void BlendFuncSeparate(uint buf, BlendingFactorSrc srcRGB, BlendingFactorDest dstRGB, BlendingFactorSrc srcAlpha, BlendingFactorDest dstAlpha)
        {
            GL.BlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        }

        public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            GL.BlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

        public void BlitNamedFramebuffer(int readFramebuffer, int drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            GL.BlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

        public void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            GL.BlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

        public void BufferData(BufferTarget target, int size, IntPtr data, BufferUsageHint usage)
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferData<T2>(BufferTarget target, int size, T2[] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferData<T2>(BufferTarget target, int size, T2[,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferData<T2>(BufferTarget target, int size, T2[,,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsageHint usage)
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferData<T2>(BufferTarget target, IntPtr size, T2[] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferData<T2>(BufferTarget target, IntPtr size, T2[,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferData<T2>(BufferTarget target, IntPtr size, T2[,,] data, BufferUsageHint usage)
                where T2 : struct
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferStorage(BufferTarget target, int size, IntPtr data, BufferStorageFlags flags)
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferStorage<T2>(BufferTarget target, int size, T2[] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferStorage<T2>(BufferTarget target, int size, T2[,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferStorage<T2>(BufferTarget target, int size, T2[,,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferStorage(BufferTarget target, IntPtr size, IntPtr data, BufferStorageFlags flags)
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferStorage<T2>(BufferTarget target, IntPtr size, T2[] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferStorage<T2>(BufferTarget target, IntPtr size, T2[,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferStorage<T2>(BufferTarget target, IntPtr size, T2[,,] data, BufferStorageFlags flags)
                where T2 : struct
        {
            GL.BufferStorage(target, size, data, flags);
        }

        public void BufferSubData(BufferTarget target, IntPtr offset, int size, IntPtr data)
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void BufferSubData<T3>(BufferTarget target, IntPtr offset, int size, T3[] data)
                where T3 : struct
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void BufferSubData<T3>(BufferTarget target, IntPtr offset, int size, T3[,] data)
                where T3 : struct
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void BufferSubData<T3>(BufferTarget target, IntPtr offset, int size, T3[,,] data)
                where T3 : struct
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void BufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data)
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, T3[] data)
                where T3 : struct
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, T3[,] data)
                where T3 : struct
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, T3[,,] data)
                where T3 : struct
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public void CallList(int list)
        {
            GL.CallList(list);
        }

        public void CallList(uint list)
        {
            GL.CallList(list);
        }

        public void CallLists(int n, ListNameType type, IntPtr lists)
        {
            GL.CallLists(n, type, lists);
        }

        public void CallLists<T2>(int n, ListNameType type, T2[] lists)
                where T2 : struct
        {
            GL.CallLists(n, type, lists);
        }

        public void CallLists<T2>(int n, ListNameType type, T2[,] lists)
                where T2 : struct
        {
            GL.CallLists(n, type, lists);
        }

        public void CallLists<T2>(int n, ListNameType type, T2[,,] lists)
                where T2 : struct
        {
            GL.CallLists(n, type, lists);
        }

        public FramebufferErrorCode CheckFramebufferStatus(FramebufferTarget target)
        {
            return GL.CheckFramebufferStatus(target);
        }

        public All CheckNamedFramebufferStatus(int framebuffer, FramebufferTarget target)
        {
            return GL.CheckNamedFramebufferStatus(framebuffer, target);
        }

        public All CheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target)
        {
            return GL.CheckNamedFramebufferStatus(framebuffer, target);
        }

        public void ClampColor(ClampColorTarget target, ClampColorMode clamp)
        {
            GL.ClampColor(target, clamp);
        }

        public void Clear(ClearBufferMask mask)
        {
            GL.Clear(mask);
        }

        public void ClearAccum(float red, float green, float blue, float alpha)
        {
            GL.ClearAccum(red, green, blue, alpha);
        }

        public void ClearBufferData(BufferTarget target, PixelInternalFormat internalformat, PixelFormat format, All type, IntPtr data)
        {
            GL.ClearBufferData(target, internalformat, format, type, data);
        }

        public void ClearBufferData<T4>(BufferTarget target, PixelInternalFormat internalformat, PixelFormat format, All type, T4[] data)
                where T4 : struct
        {
            GL.ClearBufferData(target, internalformat, format, type, data);
        }

        public void ClearBufferData<T4>(BufferTarget target, PixelInternalFormat internalformat, PixelFormat format, All type, T4[,] data)
                where T4 : struct
        {
            GL.ClearBufferData(target, internalformat, format, type, data);
        }

        public void ClearBufferData<T4>(BufferTarget target, PixelInternalFormat internalformat, PixelFormat format, All type, T4[,,] data)
                where T4 : struct
        {
            GL.ClearBufferData(target, internalformat, format, type, data);
        }

        public void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, float depth, int stencil)
        {
            GL.ClearBuffer(buffer, drawbuffer, depth, stencil);
        }

        public void ClearBuffer(ClearBuffer buffer, int drawbuffer, Single[] value)
        {
            GL.ClearBuffer(buffer, drawbuffer, value);
        }

        public void ClearBuffer(ClearBuffer buffer, int drawbuffer, Int32[] value)
        {
            GL.ClearBuffer(buffer, drawbuffer, value);
        }

        public void ClearBufferSubData(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, IntPtr data)
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBufferSubData<T6>(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[] data)
                where T6 : struct
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBufferSubData<T6>(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[,] data)
                where T6 : struct
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBufferSubData<T6>(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, int size, PixelFormat format, All type, T6[,,] data)
                where T6 : struct
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBufferSubData(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, All type, IntPtr data)
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBufferSubData<T6>(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, All type, T6[] data)
                where T6 : struct
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBufferSubData<T6>(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, All type, T6[,] data)
                where T6 : struct
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBufferSubData<T6>(BufferTarget target, PixelInternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, All type, T6[,,] data)
                where T6 : struct
        {
            GL.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
        }

        public void ClearBuffer(ClearBuffer buffer, int drawbuffer, UInt32[] value)
        {
            GL.ClearBuffer(buffer, drawbuffer, value);
        }

        public void ClearColor(float red, float green, float blue, float alpha)
        {
            GL.ClearColor(red, green, blue, alpha);
        }

        public void ClearDepth(double depth)
        {
            GL.ClearDepth(depth);
        }

        public void ClearDepth(float d)
        {
            GL.ClearDepth(d);
        }

        public void ClearIndex(float c)
        {
            GL.ClearIndex(c);
        }

        public void ClearNamedBufferData(int buffer, PixelInternalFormat internalformat, PixelFormat format, All type, IntPtr data)
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void ClearNamedBufferData<T4>(int buffer, PixelInternalFormat internalformat, PixelFormat format, All type, T4[] data)
                where T4 : struct
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void ClearNamedBufferData<T4>(int buffer, PixelInternalFormat internalformat, PixelFormat format, All type, T4[,] data)
                where T4 : struct
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void ClearNamedBufferData<T4>(int buffer, PixelInternalFormat internalformat, PixelFormat format, All type, T4[,,] data)
                where T4 : struct
        {
            GL.ClearNamedBufferData(buffer, internalformat, format, type, data);
        }

        public void Accum(AccumOp op, float value)
        {
            GL.Accum(op, value);
        }

        public void ActiveShaderProgram(int pipeline, int program)
        {
            GL.ActiveShaderProgram(pipeline, program);
        }

        public void ActiveShaderProgram(uint pipeline, uint program)
        {
            GL.ActiveShaderProgram(pipeline, program);
        }

        public void ActiveTexture(TextureUnit texture)
        {
            GL.ActiveTexture(texture);
        }

        public void AlphaFunc(AlphaFunction func, float @ref)
        {
            GL.AlphaFunc(func, @ref);
        }

        public bool AreTexturesResident(int n, Int32[] textures, bool[] residences)
        {
            return GL.AreTexturesResident(n, textures, residences);
        }

        public bool AreTexturesResident(int n, UInt32[] textures, bool[] residences)
        {
            return GL.AreTexturesResident(n, textures, residences);
        }

        public void ArrayElement(int i)
        {
            GL.ArrayElement(i);
        }

        public void AttachShader(int program, int shader)
        {
            GL.AttachShader(program, shader);
        }

        public void AttachShader(uint program, uint shader)
        {
            GL.AttachShader(program, shader);
        }

        public void Begin(PrimitiveType mode)
        {
            GL.Begin(mode);
        }

        public void BeginConditionalRender(int id, ConditionalRenderType mode)
        {
            GL.BeginConditionalRender(id, mode);
        }

        public void BeginConditionalRender(uint id, ConditionalRenderType mode)
        {
            GL.BeginConditionalRender(id, mode);
        }

        public void BeginQuery(QueryTarget target, int id)
        {
            GL.BeginQuery(target, id);
        }

        public void BeginQuery(QueryTarget target, uint id)
        {
            GL.BeginQuery(target, id);
        }

        public void BeginQueryIndexed(QueryTarget target, int index, int id)
        {
            GL.BeginQueryIndexed(target, index, id);
        }

        public void BeginQueryIndexed(QueryTarget target, uint index, uint id)
        {
            GL.BeginQueryIndexed(target, index, id);
        }

        public void BeginTransformFeedback(TransformFeedbackPrimitiveType primitiveMode)
        {
            GL.BeginTransformFeedback(primitiveMode);
        }

        public void BindAttribLocation(int program, int index, string name)
        {
            GL.BindAttribLocation(program, index, name);
        }

        public void BindAttribLocation(uint program, uint index, string name)
        {
            GL.BindAttribLocation(program, index, name);
        }

        public void BindBuffer(BufferTarget target, int buffer)
        {
            GL.BindBuffer(target, buffer);
        }

        public void BindBuffer(BufferTarget target, uint buffer)
        {
            GL.BindBuffer(target, buffer);
        }

        public void BindBufferBase(BufferRangeTarget target, int index, int buffer)
        {
            GL.BindBufferBase(target, index, buffer);
        }

        public void BindBufferBase(BufferRangeTarget target, uint index, uint buffer)
        {
            GL.BindBufferBase(target, index, buffer);
        }

        public void BindBufferRange(BufferRangeTarget target, int index, int buffer, IntPtr offset, int size)
        {
            GL.BindBufferRange(target, index, buffer, offset, size);
        }

        public void BindBufferRange(BufferRangeTarget target, int index, int buffer, IntPtr offset, IntPtr size)
        {
            GL.BindBufferRange(target, index, buffer, offset, size);
        }

        public void BindBufferRange(BufferRangeTarget target, uint index, uint buffer, IntPtr offset, int size)
        {
            GL.BindBufferRange(target, index, buffer, offset, size);
        }

        public void BindBufferRange(BufferRangeTarget target, uint index, uint buffer, IntPtr offset, IntPtr size)
        {
            GL.BindBufferRange(target, index, buffer, offset, size);
        }

        public void BindBuffersBase(BufferRangeTarget target, int first, int count, Int32[] buffers)
        {
            GL.BindBuffersBase(target, first, count, buffers);
        }

        public void BindBuffersBase(BufferRangeTarget target, uint first, int count, UInt32[] buffers)
        {
            GL.BindBuffersBase(target, first, count, buffers);
        }

        public void BindBuffersRange(BufferRangeTarget target, int first, int count, Int32[] buffers, IntPtr[] offsets, IntPtr[] sizes)
        {
            GL.BindBuffersRange(target, first, count, buffers, offsets, sizes);
        }

        public void BindBuffersRange(BufferRangeTarget target, uint first, int count, UInt32[] buffers, IntPtr[] offsets, IntPtr[] sizes)
        {
            GL.BindBuffersRange(target, first, count, buffers, offsets, sizes);
        }

        public void BindFragDataLocation(int program, int color, string name)
        {
            GL.BindFragDataLocation(program, color, name);
        }

        public void BindFragDataLocation(uint program, uint color, string name)
        {
            GL.BindFragDataLocation(program, color, name);
        }

        public void BindFragDataLocationIndexed(int program, int colorNumber, int index, string name)
        {
            GL.BindFragDataLocationIndexed(program, colorNumber, index, name);
        }

        public void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
        {
            GL.BindFragDataLocationIndexed(program, colorNumber, index, name);
        }

        public void BindFramebuffer(FramebufferTarget target, int framebuffer)
        {
            GL.BindFramebuffer(target, framebuffer);
        }

        public void BindFramebuffer(FramebufferTarget target, uint framebuffer)
        {
            GL.BindFramebuffer(target, framebuffer);
        }

        public void BindImageTexture(int unit, int texture, int level, bool layered, int layer, TextureAccess access, SizedInternalFormat format)
        {
            GL.BindImageTexture(unit, texture, level, layered, layer, access, format);
        }

        public void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, TextureAccess access, SizedInternalFormat format)
        {
            GL.BindImageTexture(unit, texture, level, layered, layer, access, format);
        }

        public void BindImageTextures(int first, int count, Int32[] textures)
        {
            GL.BindImageTextures(first, count, textures);
        }

        public void BindImageTextures(uint first, int count, UInt32[] textures)
        {
            GL.BindImageTextures(first, count, textures);
        }

        public void BindProgramPipeline(int pipeline)
        {
            GL.BindProgramPipeline(pipeline);
        }

        public void BindProgramPipeline(uint pipeline)
        {
            GL.BindProgramPipeline(pipeline);
        }

        public void BindRenderbuffer(RenderbufferTarget target, int renderbuffer)
        {
            GL.BindRenderbuffer(target, renderbuffer);
        }

        public void BindRenderbuffer(RenderbufferTarget target, uint renderbuffer)
        {
            GL.BindRenderbuffer(target, renderbuffer);
        }

        public void BindSampler(int unit, int sampler)
        {
            GL.BindSampler(unit, sampler);
        }

        public void BindSampler(uint unit, uint sampler)
        {
            GL.BindSampler(unit, sampler);
        }

        public void BindSamplers(int first, int count, Int32[] samplers)
        {
            GL.BindSamplers(first, count, samplers);
        }

        public void BindSamplers(uint first, int count, UInt32[] samplers)
        {
            GL.BindSamplers(first, count, samplers);
        }

        public void BindTexture(TextureTarget target, int texture)
        {
            GL.BindTexture(target, texture);
        }

        public void BindTexture(TextureTarget target, uint texture)
        {
            GL.BindTexture(target, texture);
        }

        public void BindTextures(int first, int count, Int32[] textures)
        {
            GL.BindTextures(first, count, textures);
        }

        public void BindTextures(uint first, int count, UInt32[] textures)
        {
            GL.BindTextures(first, count, textures);
        }

        public void BindTextureUnit(int unit, int texture)
        {
            GL.BindTextureUnit(unit, texture);
        }

        public void BindTextureUnit(uint unit, uint texture)
        {
            GL.BindTextureUnit(unit, texture);
        }

        public void BindTransformFeedback(TransformFeedbackTarget target, int id)
        {
            GL.BindTransformFeedback(target, id);
        }

        public void BindTransformFeedback(TransformFeedbackTarget target, uint id)
        {
            GL.BindTransformFeedback(target, id);
        }

        public void BindVertexArray(int array)
        {
            GL.BindVertexArray(array);
        }

        public void BindVertexArray(uint array)
        {
            GL.BindVertexArray(array);
        }

        public void BindVertexBuffer(int bindingindex, int buffer, IntPtr offset, int stride)
        {
            GL.BindVertexBuffer(bindingindex, buffer, offset, stride);
        }

        public void BindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride)
        {
            GL.BindVertexBuffer(bindingindex, buffer, offset, stride);
        }

        public void BindVertexBuffers(int first, int count, Int32[] buffers, IntPtr[] offsets, Int32[] strides)
        {
            GL.BindVertexBuffers(first, count, buffers, offsets, strides);
        }

        public void BindVertexBuffers(uint first, int count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
        {
            GL.BindVertexBuffers(first, count, buffers, offsets, strides);
        }

        public void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, Byte[] bitmap)
        {
            GL.Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
        }

        public void BlendColor(float red, float green, float blue, float alpha)
        {
            GL.BlendColor(red, green, blue, alpha);
        }

        public void BlendEquation(BlendEquationMode mode)
        {
            GL.BlendEquation(mode);
        }

        public void BlendEquation(int buf, BlendEquationMode mode)
        {
            GL.BlendEquation(buf, mode);
        }

        public void BlendEquation(uint buf, BlendEquationMode mode)
        {
            GL.BlendEquation(buf, mode);
        }

        public void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
        {
            GL.BlendEquationSeparate(modeRGB, modeAlpha);
        }

        public void BlendEquationSeparate(int buf, BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
        {
            GL.BlendEquationSeparate(buf, modeRGB, modeAlpha);
        }

        public void BlendEquationSeparate(uint buf, BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
        {
            GL.BlendEquationSeparate(buf, modeRGB, modeAlpha);
        }

        public void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
        {
            GL.BlendFunc(sfactor, dfactor);
        }

        public void BlendFunc(int buf, BlendingFactorSrc src, BlendingFactorDest dst)
        {
            GL.BlendFunc(buf, src, dst);
        }

        public void BlendFunc(uint buf, BlendingFactorSrc src, BlendingFactorDest dst)
        {
            GL.BlendFunc(buf, src, dst);
        }

        public void BlendFuncSeparate(BlendingFactorSrc sfactorRGB, BlendingFactorDest dfactorRGB, BlendingFactorSrc sfactorAlpha, BlendingFactorDest dfactorAlpha)
        {
            GL.BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }

    }
}
