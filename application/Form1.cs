using Leo.render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_FrameWork(object sender, EventArgs e)
        {
            renderWindow.SetUp();

            //renderWindow.Renderer = new RenderCube();
            renderWindow.Renderer = new RenderD2Scene();
        }
    }
}
