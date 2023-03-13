using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatRubik
{
    public partial class ball : UserControl
    {
        public ball()
        {
            InitializeComponent();
        }

        public void setPosition(Point pp) { this.Left = pp.X; this.Top = pp.Y; }
        public Point getPosition() { return new Point(this.Left, this.Top); }
        public void setColor(Color c) { this.BackColor = c; }
        public Color getColor() { return this.BackColor;}
        public int ismousedown = 0;

        
        private void ball_Load(object sender, EventArgs e)
        {

        }

        private void ball_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = 1;
        }

        private void ball_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void ball_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = 0;
        }
    }
}
