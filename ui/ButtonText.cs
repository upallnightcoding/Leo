using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.ui
{
    public class ButtonText : Component
    {
        private string text = null;

        public ButtonText(int w, int h) : base(w, h)
        {

        }

        public override void Calculate()
        {
            SetPos(0, 0);
        }
    }
}
