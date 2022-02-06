using OpenTK.Graphics.OpenGL4;
using Textures;

namespace Leo
{
    public abstract class IEntity
    {
        protected Shader shader = null;

        protected Texture texture = null;

        protected VAO vao = null;

        // Abstract Functions
        //-------------------
        protected abstract Texture CreateEntityTexture();

        public void Display()
        {
            vao.Use();

            texture.Use(TextureUnit.Texture0);

            shader.Use();

            vao.Display();
        }

        public void Initialize()
        {
            vao = new VAO();

            shader = new Shader();

            //texture = Texture.LoadFromFile(LoadTexture());
            //texture = new Texture(LoadTexture());
            texture = CreateEntityTexture();
        }
    }
}
