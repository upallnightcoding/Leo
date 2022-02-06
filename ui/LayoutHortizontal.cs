using Leo.entity;
using System;
using System.Collections.Generic;

namespace Leo.ui
{
    public class LayoutHortizontal : Layout
    {
        public LayoutHortizontal()
        {
            SetPadding(10, 10);
        }

        public override void Calculate(Window parent, List<Window> windowList)
        {
            int x = xPadding;
            int y = yPadding;
            int maxY = 0;

            foreach (Window window in windowList)
            {
                window.Calculate();

                window.SetPos(x, y);

                x += window.GetW() + xPadding;

                maxY = Math.Max(maxY, window.GetH());
            }

            maxY += 2 * yPadding;

            parent.SetSize(x, maxY);
        }
    }
}
