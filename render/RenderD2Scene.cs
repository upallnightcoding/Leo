using Leo.entity;
using Leo.ui;
using OpenTK.Graphics.OpenGL4;
using Textures;

namespace Leo.render
{
    public class RenderD2Scene : IRender
    {
        //private IEntity entity = new Sprite();

        private IEntity entity = null;

        public RenderD2Scene()
        {
            ButtonText bt1 = new ButtonText(40, 20);
            ButtonText bt2 = new ButtonText(20, 20);
            ButtonText bt3 = new ButtonText(20, 20);

            Portal p1 = new Portal(new LayoutVertical());
            p1.Add(bt1);
            p1.Add(bt2);
            p1.Add(bt3);

            ButtonText bt4 = new ButtonText(45, 30);
            ButtonText bt5 = new ButtonText(25, 30);
            ButtonText bt6 = new ButtonText(35, 30);

            Portal p2 = new Portal(new LayoutHortizontal());
            p2.Add(bt4);
            p2.Add(bt5);
            p2.Add(bt6);

            Portal p3 = new Portal(new LayoutVertical());
            p3.Add(p1);
            p3.Add(p2);

            p1.Calculate();

            entity = p1;
            //entity = new Sprite();
        }

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
