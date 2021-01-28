namespace Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bài01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài05ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài01ToolStripMenuItem,
            this.bài02ToolStripMenuItem,
            this.bài03ToolStripMenuItem,
            this.bài04ToolStripMenuItem,
            this.bài05ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bài01ToolStripMenuItem
            // 
            this.bài01ToolStripMenuItem.Name = "bài01ToolStripMenuItem";
            this.bài01ToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.bài01ToolStripMenuItem.Text = "Bài 01";
            this.bài01ToolStripMenuItem.Click += new System.EventHandler(this.bài01ToolStripMenuItem_Click);
            // 
            // bài02ToolStripMenuItem
            // 
            this.bài02ToolStripMenuItem.Name = "bài02ToolStripMenuItem";
            this.bài02ToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.bài02ToolStripMenuItem.Text = "Bài 02";
            this.bài02ToolStripMenuItem.Click += new System.EventHandler(this.bài02ToolStripMenuItem_Click);
            // 
            // bài03ToolStripMenuItem
            // 
            this.bài03ToolStripMenuItem.Name = "bài03ToolStripMenuItem";
            this.bài03ToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.bài03ToolStripMenuItem.Text = "Bài 03";
            this.bài03ToolStripMenuItem.Click += new System.EventHandler(this.bài03ToolStripMenuItem_Click);
            // 
            // bài04ToolStripMenuItem
            // 
            this.bài04ToolStripMenuItem.Name = "bài04ToolStripMenuItem";
            this.bài04ToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.bài04ToolStripMenuItem.Text = "Bài 04";
            this.bài04ToolStripMenuItem.Click += new System.EventHandler(this.bài04ToolStripMenuItem_Click);
            // 
            // bài05ToolStripMenuItem
            // 
            this.bài05ToolStripMenuItem.Name = "bài05ToolStripMenuItem";
            this.bài05ToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.bài05ToolStripMenuItem.Text = "Bài 05";
            this.bài05ToolStripMenuItem.Click += new System.EventHandler(this.bài05ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 748);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu_LAB02";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bài01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài03ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài04ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài05ToolStripMenuItem;
    }
}

