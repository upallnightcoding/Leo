using OpenTK.Graphics.OpenGL4;
using Textures;

namespace Leo.entity
{
    class Sprite : IEntity
    {
        private string TEST_IMAGE = 
            "D:/Projects/c#/OpenTkDemo/images/container.png";

        protected override Texture CreateEntityTexture()
        {
            return (new Texture(TEST_IMAGE));
        }
    }
}
