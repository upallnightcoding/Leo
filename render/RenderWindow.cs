using System;
using System.Drawing;
using System.Windows.Forms;
using Leo.render;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Leo
{
    class RenderWindow : OpenTK.GLControl
    {
        private bool firstRender = true;

        public IRender Renderer 
        {
            set;
            get;
        }

        public void SetUp()
        {
            Resize += new EventHandler(GlControl_Resize);
            Paint += new PaintEventHandler(GlControl_Paint);
            Application.Idle += Application_Idle;

            GL.Enable(EnableCap.DepthTest);

            VSync = true;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            while (IsIdle)
            {
                Display();
            }
        }

        private void GlControl_Resize(object sender, EventArgs e)
        {
            
            OpenTK.GLControl glControl = sender as OpenTK.GLControl;

            if (glControl.ClientSize.Height == 0)
            {
                glControl.ClientSize = new System.Drawing.Size(glControl.ClientSize.Width, 1);
            }

            GL.Viewport(0, 0, glControl.ClientSize.Width, glControl.ClientSize.Height);
            

            /*
            float aspectRatio = (float)Width / (float)Height;
            OpenTK.Matrix4 perpective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspectRatio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perpective);
            */
        }

        private void GlControl_Paint(object sender, PaintEventArgs e)
        {
            Display();
        }

        private void Display()
        {
            if (firstRender)
            {
                Renderer.Initialize();
                firstRender = false;
            }

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Renderer.Display();

            SwapBuffers();
        }
    }
}
