using Leo.entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.ui
{
    public class Portal : Window
    {
        private Layout layout = null;

        private List<Window> windowList = null;

        // Constructor(s) ...

        public Portal(Layout layout)
        {
            this.windowList = new List<Window>();
            this.layout = layout;
        }

        public override void Calculate()
        {
            layout.Calculate(this, windowList);
        }

        public void Add(Window window)
        {
            windowList.Add(window);
        }

        public override void Show(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(GetX(), GetY(), GetW(), GetH());
            graphics.FillRectangle(Brushes.Green, rectangle);

            foreach (Window window in windowList)
            {
                window.Show(graphics);
            }
        }
    }
}
