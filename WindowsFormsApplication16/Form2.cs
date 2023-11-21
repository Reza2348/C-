using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text + "\n";
            File.AppendAllText(@"E:\New folder (5)/file1.txt", str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = File.ReadAllText(@"E:\New folder (5)/File1.TXT");
            textBox5.Text = a;
            string[]b=File.ReadAllLines("");
        }
    }
}
