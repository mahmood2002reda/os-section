using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace sec5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// work1();
            // work2();
            Thread th1 = new Thread(work1);
            button1.Enabled = false;
          //  Thread th2 = new Thread(work2);
            th1.Start();
           // th2.Start();
        }
        void work1()
        {

            for (int i = 1; i <= 10; i++)
            {
                // richTextBox1.Text += "work1::" + i + "\n";
                  richTextBox1.Invoke(new delprint(print), i);
                Thread.Sleep(500);
            }
            button1.Invoke(new delenable(enable));
        }
        void work2()
        {

            for (int i = 1; i <= 10; i++)
            {
                richTextBox1.Invoke(new delprint(print2), i);
                Thread.Sleep(500);
                
            }
           
        }
        private delegate void delprint(int i);
        private void print(int i)
        {
            richTextBox1.Text += "work1::" + i + "\n";
        }
        private void print2(int i)
        {
            richTextBox1.Text += "work2::" + i + "\n";
        }

        delegate void delenable();
        void enable()
        {
            button1.Enabled = true;
        }
    }
}