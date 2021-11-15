using OpenTK.Graphics.OpenGL4;
using Textures;

namespace Leo.entity
{
    class Sprite : IEntity
    {
        protected override string LoadTexture()
        {
            return ("D:/Projects/c#/OpenTkDemo/images/container.png");
        }
    }
}
