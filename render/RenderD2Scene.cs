using Leo.entity;
using Leo.ui;
using OpenTK.Graphics.OpenGL4;
using Textures;

namespace Leo.render
{
    class RenderD2Scene : IRender
    {
        //private IEntity entity = new Sprite();
        private IEntity entity = new Portal();

        public void Display()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            entity.Display();
        }

        public void Initialize()
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            entity.Initialize();
        }
    }
}
