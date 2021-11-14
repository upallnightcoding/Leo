using OpenTK.Graphics.OpenGL4;
using Textures;

namespace Leo.entity
{
    class Sprite : IEntity
    {
        private readonly float[] _vertices =
        {
            // Position         Texture coordinates
             0.5f,  0.5f, 0.0f, 1.0f, 1.0f, // top right
             0.5f, -0.5f, 0.0f, 1.0f, 0.0f, // bottom right
            -0.5f, -0.5f, 0.0f, 0.0f, 0.0f, // bottom left
            -0.5f,  0.5f, 0.0f, 0.0f, 1.0f  // top left
        };

        private readonly uint[] _indices =
        {
            0, 1, 3,
            1, 2, 3
        };

        private int _elementBufferObject;

        private int _vertexBufferObject;

        private int _vertexArrayObject;

        private Shader shader;

        private Texture texture;

        private VAO vao;

        public override void Display()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            vao.Use();

            texture.Use(TextureUnit.Texture0);

            shader.Use();

            GL.DrawElements(PrimitiveType.Triangles, _indices.Length, DrawElementsType.UnsignedInt, 0);
        }

        public override void Initialize()
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            vao = new VAO();

            shader = new Shader();

            texture = Texture.LoadFromFile("D:/Projects/c#/OpenTkDemo/images/container.png");
            //texture.Use(TextureUnit.Texture0);
        }
    }
}
