using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideUpLoginForm
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string password;

        public void texting(string text)
        {
            password = text;
        }

        int panel1_y = 211; int waiter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 50)
            {
                panel1_y -= 6;
                panel1.Size = new Size(panel1.Size.Width,panel1_y);
                if (panel1_y < 1)
                {
                    panel1.Hide();
                    texting("john123");
                    timer1.Enabled = false;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == "John")
                {
                    textBox1.Enabled = false;
                    timer2.Enabled = true;
                }
                else textBox1.Clear();
            }
        }

        int panel2_y = 211;
        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2_y -= 6;
            panel2.Size = new Size(panel2.Size.Width, panel2_y);
            if (panel2_y < 1)
            {
                panel2.Hide();
                timer2.Enabled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox2.Text == password)
                {
                    timer3.Enabled = true;
                    label4.Text = "Welcome back " + textBox1.Text;
                    label4.Location = new Point((panel4.Size.Width / 2 - (label4.Size.Width / 2)), (panel4.Size.Height / 2 - (label4.Size.Height / 2)));
                }
                else textBox2.Clear();
            }
        }

        int panel3_y = 211;
        private void timer3_Tick(object sender, EventArgs e)
        {
            panel3_y -= 6;
            panel3.Size = new Size(panel3.Size.Width, panel3_y);
            if (panel3_y < 1)
            {
                panel3.Hide();
                timer3.Enabled = false;
            }
        }
    }
}
