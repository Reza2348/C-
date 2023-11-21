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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            label3.BackColor = Color.Green;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            label4.BackColor = Color.Gold;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            label5.BackColor = Color.Brown;
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

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label3.BackColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label4.BackColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            label5.BackColor = Color.White;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip a=new ToolTip();
            a.SetToolTip(label1, "27,524");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label2, "31,704");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label3, "37,839");
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label4, "4,017");
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label5, "303");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            label6.BackColor = Color.Cyan;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            label6.BackColor = Color.White;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label6, "2,420");
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            label7.BackColor = Color.Pink;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            label7.BackColor = Color.White;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label7, "15,000");
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            label8.BackColor = Color.BlueViolet;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            label8.BackColor = Color.White;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label8, "7,612");
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            label9.BackColor = Color.Crimson;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            label9.BackColor = Color.White;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(label9, "20,100");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ایا مایل هستید از برنامه خارج شوید", "eror", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            Application.Exit();
        }
    }
}
