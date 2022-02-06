using Leo.entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.ui
{
    public abstract class Component : Window
    {
        public Component(int w, int h) : base(w, h)
        {

        }

        public override void Show(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(GetX(), GetY(), GetW(), GetH());
            graphics.FillRectangle(Brushes.White, rectangle);
        }

        public abstract override void Calculate();
    }
}
