using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Textures;

namespace Leo.entity
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Window : IEntity
    {
        private int x = 0;
        private int y = 0;
        private int w = 0;
        private int h = 0;

        // Abstract Function(s) ...

        public abstract void Calculate();
        public abstract void Show(Graphics graphics);

        // Constructor(s) ...

        public Window()
        {

        }

        // Public Functions ...

        public Window(int w, int h)
        {
            SetSize(w, h);
        }

        public void SetPos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetSize(int w, int h)
        {
            this.w = w;
            this.h = h;
        }

        public int GetW()
        {
            return (w);
        }

        public int GetH()
        {
            return (h);
        }

        public int GetX()
        {
            return (x);
        }

        public int GetY()
        {
            return (y);
        }

        // Protected Functions

        protected override Texture CreateEntityTexture()
        {
            return (CreateWindowTexture());
        }

        // Private Functions
        //------------------

        private Texture CreateWindowTexture()
        {
            Bitmap image = new Bitmap(w, h);

            Graphics graphics = Graphics.FromImage(image);

            Show(graphics);

            return (new Texture(image));
        }
    }
}
