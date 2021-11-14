using Leo.entity;
using OpenTK.Graphics.OpenGL4;
using Textures;

namespace Leo.render
{
    class RenderD2Scene : IRender
    {
        private IEntity entity = new Sprite();

        public void Display()
        {
            entity.Display();
        }

        public void Initialize()
        {
            entity.Initialize();
        }
    }
}
