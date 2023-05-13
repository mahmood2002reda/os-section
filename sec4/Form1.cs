using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sec4
{
    public partial class Form1 : Form
    {
        enum position {right, left,up,down};
        private int x;
        private int y;
        position objposition;

        public Form1()
        {

            InitializeComponent();
            x = 10;
            y = 10;
           // objposition= position.down;
           this.Width = 500;
            this.Height = 500;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Brush mybrsh = new SolidBrush(Color.BlueViolet);
            g.FillRectangle(mybrsh, x, y, 200, 250);
            /*Graphics g = e.Graphics;
            Pen  mypen= new Pen(Color.Black);
            Brush mybrsh = new SolidBrush(Color.Blue);
            g.DrawLine(mypen, 2, 2, 200, 200);
            g.DrawRectangle(mypen, 10, 10, 200, 250);
           // g.FillRectangle(mybrsh, 10, 10, 200, 250);
          //  g.DrawEllipse(mypen, 10, 10, 200, 250);
            g.DrawArc(mypen, 10, 10, 200, 250, 0, -90);
            string dr = "mahmood";
            Font df = new Font("Arial", 20);
            PointF dp = new PointF(150, 150);
            g.DrawString(dr, df, mybrsh, dp);*/
        }

        

        private void tmrmoving(object sender, EventArgs e)
        {
            if (objposition == position.right)
            {
                x = x + 10;
            }
            else if (objposition == position.left)
            {
                x = x - 10;
            }
            else if (objposition == position.up)
            {
                y = y- 10;
            }
            else if (objposition == position.down)
                {
                    y = y + 10;
                }
            

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Right)
            {
                objposition = position.right;
            }
            else if (e.KeyCode == Keys.Left)
            {
                objposition = position.left;
            }
            else if (e.KeyCode == Keys.Up)
            {
                objposition = position.up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                objposition = position.down;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd')
            {
                objposition = position.right;
            }
            else if (e.KeyChar == 'a')
            {
                objposition = position.left;
            }
            else if (e.KeyChar == 'w')
            {
                objposition = position.up;
            }
            else if (e.KeyChar == 's')
            {
                objposition = position.down;
            }
        }
    }
}
