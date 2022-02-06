using Leo.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.ui
{
    public class LayoutVertical : Layout
    {
        public LayoutVertical()
        {
            SetPadding(10, 10);
        }

        public override void Calculate(Window parent, List<Window> windowList)
        {
            int maxX = 0;
            int x = xPadding;
            int y = yPadding;

            foreach(Window window in windowList)
            {
                window.Calculate();

                window.SetPos(x, y);

                maxX = Math.Max(maxX, window.GetW());

                y += window.GetH() + yPadding;
            }

            maxX += 2 * xPadding;

            parent.SetSize(maxX, y);
        }
    }
}
