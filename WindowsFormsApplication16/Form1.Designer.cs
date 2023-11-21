namespace WindowsFormsApplication16
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پسزمینهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آبیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قرمزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.زردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سفیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشکیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فونتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رنگفونتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بنفشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نارجیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طلاییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بستنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سیوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازکردنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پرینتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.سیوToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.بازکردنToolStripMenuItem,
            this.پرینتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1203, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پسزمینهToolStripMenuItem,
            this.فونتToolStripMenuItem,
            this.رنگفونتToolStripMenuItem,
            this.بستنToolStripMenuItem});
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // پسزمینهToolStripMenuItem
            // 
            this.پسزمینهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آبیToolStripMenuItem,
            this.قرمزToolStripMenuItem,
            this.زردToolStripMenuItem,
            this.سفیدToolStripMenuItem,
            this.مشکیToolStripMenuItem});
            this.پسزمینهToolStripMenuItem.Name = "پسزمینهToolStripMenuItem";
            this.پسزمینهToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.پسزمینهToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.پسزمینهToolStripMenuItem.Text = "پس زمینه";
            // 
            // آبیToolStripMenuItem
            // 
            this.آبیToolStripMenuItem.Name = "آبیToolStripMenuItem";
            this.آبیToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.آبیToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.آبیToolStripMenuItem.Text = "آبی";
            this.آبیToolStripMenuItem.Click += new System.EventHandler(this.آبیToolStripMenuItem_Click);
            // 
            // قرمزToolStripMenuItem
            // 
            this.قرمزToolStripMenuItem.Name = "قرمزToolStripMenuItem";
            this.قرمزToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.قرمزToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.قرمزToolStripMenuItem.Text = "قرمز";
            this.قرمزToolStripMenuItem.Click += new System.EventHandler(this.قرمزToolStripMenuItem_Click);
            // 
            // زردToolStripMenuItem
            // 
            this.زردToolStripMenuItem.Name = "زردToolStripMenuItem";
            this.زردToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.زردToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.زردToolStripMenuItem.Text = "زرد";
            this.زردToolStripMenuItem.Click += new System.EventHandler(this.زردToolStripMenuItem_Click);
            // 
            // سفیدToolStripMenuItem
            // 
            this.سفیدToolStripMenuItem.Name = "سفیدToolStripMenuItem";
            this.سفیدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.سفیدToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.سفیدToolStripMenuItem.Text = "سفید";
            this.سفیدToolStripMenuItem.Click += new System.EventHandler(this.سفیدToolStripMenuItem_Click);
            // 
            // مشکیToolStripMenuItem
            // 
            this.مشکیToolStripMenuItem.Name = "مشکیToolStripMenuItem";
            this.مشکیToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.مشکیToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.مشکیToolStripMenuItem.Text = "مشکی";
            this.مشکیToolStripMenuItem.Click += new System.EventHandler(this.مشکیToolStripMenuItem_Click);
            // 
            // فونتToolStripMenuItem
            // 
            this.فونتToolStripMenuItem.Name = "فونتToolStripMenuItem";
            this.فونتToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.فونتToolStripMenuItem.Text = "فونت";
            this.فونتToolStripMenuItem.Click += new System.EventHandler(this.فونتToolStripMenuItem_Click);
            // 
            // رنگفونتToolStripMenuItem
            // 
            this.رنگفونتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بنفشToolStripMenuItem,
            this.نارجیToolStripMenuItem,
            this.طلاییToolStripMenuItem});
            this.رنگفونتToolStripMenuItem.Name = "رنگفونتToolStripMenuItem";
            this.رنگفونتToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.رنگفونتToolStripMenuItem.Text = "رنگ فونت";
            // 
            // بنفشToolStripMenuItem
            // 
            this.بنفشToolStripMenuItem.Name = "بنفشToolStripMenuItem";
            this.بنفشToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.بنفشToolStripMenuItem.Text = "بنفش";
            this.بنفشToolStripMenuItem.Click += new System.EventHandler(this.بنفشToolStripMenuItem_Click);
            // 
            // نارجیToolStripMenuItem
            // 
            this.نارجیToolStripMenuItem.Name = "نارجیToolStripMenuItem";
            this.نارجیToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.نارجیToolStripMenuItem.Text = "سبز";
            this.نارجیToolStripMenuItem.Click += new System.EventHandler(this.نارجیToolStripMenuItem_Click);
            // 
            // طلاییToolStripMenuItem
            // 
            this.طلاییToolStripMenuItem.Name = "طلاییToolStripMenuItem";
            this.طلاییToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.طلاییToolStripMenuItem.Text = "طلایی";
            this.طلاییToolStripMenuItem.Click += new System.EventHandler(this.طلاییToolStripMenuItem_Click);
            // 
            // بستنToolStripMenuItem
            // 
            this.بستنToolStripMenuItem.Name = "بستنToolStripMenuItem";
            this.بستنToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.بستنToolStripMenuItem.Text = "بستن";
            this.بستنToolStripMenuItem.Click += new System.EventHandler(this.بستنToolStripMenuItem_Click);
            // 
            // سیوToolStripMenuItem
            // 
            this.سیوToolStripMenuItem.Name = "سیوToolStripMenuItem";
            this.سیوToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.سیوToolStripMenuItem.Text = "save as";
            this.سیوToolStripMenuItem.Click += new System.EventHandler(this.سیوToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // بازکردنToolStripMenuItem
            // 
            this.بازکردنToolStripMenuItem.Name = "بازکردنToolStripMenuItem";
            this.بازکردنToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.بازکردنToolStripMenuItem.Text = "باز کردن ";
            this.بازکردنToolStripMenuItem.Click += new System.EventHandler(this.بازکردنToolStripMenuItem_Click);
            // 
            // پرینتToolStripMenuItem
            // 
            this.پرینتToolStripMenuItem.Name = "پرینتToolStripMenuItem";
            this.پرینتToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.پرینتToolStripMenuItem.Text = "پرینت";
            this.پرینتToolStripMenuItem.Click += new System.EventHandler(this.پرینتToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(1203, 483);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 526);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Notepad برنامه";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پسزمینهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آبیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قرمزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem زردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سفیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشکیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رنگفونتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بنفشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نارجیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فونتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بستنToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem طلاییToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem سیوToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem بازکردنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پرینتToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

