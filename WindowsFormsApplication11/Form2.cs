using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label1, "15,438,000.00");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible =true;
            label1.BackColor = Color.Blue;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label2.BackColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label2, "8,300,000.00");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label2.BackColor = Color.White;
        }
    }
}
