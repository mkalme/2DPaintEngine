using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DPaintEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();

            int x = 400;
            int y = 220;
            int radius = 200;

            for (int b = 0; b < 30; b++) {
                PointF[] shape = new PointF[4 + b];

                for (int i = 0; i < shape.Length; i++)
                {
                    shape[i] = new PointF(
                    x + radius * (float)Math.Cos(i * (360.0 / (double)shape.Length) * Math.PI / 180f),
                    y + radius * (float)Math.Sin(i * (360.0 / (double)shape.Length) * Math.PI / 180f));
                }

                g.DrawPolygon(Pens.Black, shape);
            }

            g.DrawEllipse(Pens.Black, x - radius, y - radius, radius * 2, radius * 2);
        }
    }
}
