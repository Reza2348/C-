using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        int c = 1;
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void آبیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void قرمزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }

        private void زردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Yellow;
        }

        private void سفیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void مشکیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void بنفشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Purple;
        }

        private void نارجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Green;
        }

        private void طلاییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Gold;
        }

        private void فونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void سیوToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    str = saveFileDialog1.FileName;
                    File.WriteAllText(str, richTextBox1.Text);
                }
                c++;
                if (c > 1)
                {
                    File.AppendAllText(str, richTextBox1.Text);
                }
                DateTime a = DateTime.Now;
                string x = string.Format("{0}/{1}/{2}/ {3}:{4:D2}:{5:D2}",
                a.Year, a.Month, a.Day, a.Hour, a.Minute, a.Second);
                File.WriteAllText(str, richTextBox1.Text + "\n" + x);
            }
        }

        private void بازکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(str);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "picture Files (*.docx)(*.pdf)(*.tex)|*.docx||*.pdf|*.tex||All files (*.*)|*.*";
            printDocument1.DocumentName = "picture";
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            printDialog1.AllowCurrentPage = false;
            printDialog1.AllowPrintToFile = false;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;
        }

        private void پرینتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                    printDocument1.Print();
                }
            }


        }

        private void بستنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ایا مایل هستید از برنامه خارج شوید ", "EROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            Application.Exit();
        }
    }
}
