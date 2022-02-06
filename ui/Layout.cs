using Leo.entity;
using System.Collections.Generic;

namespace Leo.ui
{
    public abstract class Layout
    {
        protected int xPadding = 0;
        protected int yPadding = 0;

        public abstract void Calculate(Window parent, List<Window> text);

        protected void SetPadding(int xPadding, int yPadding)
        {
            this.xPadding = xPadding;
            this.yPadding = yPadding;
        }
    }
}
