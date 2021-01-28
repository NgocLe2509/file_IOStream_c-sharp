namespace Menu
{
    partial class Lab02_Bai01
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
            this.btExit = new System.Windows.Forms.Button();
            this.tbUp = new System.Windows.Forms.TextBox();
            this.btWrite = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(514, 364);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 35);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbUp
            // 
            this.tbUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUp.Location = new System.Drawing.Point(311, 58);
            this.tbUp.Multiline = true;
            this.tbUp.Name = "tbUp";
            this.tbUp.Size = new System.Drawing.Size(281, 300);
            this.tbUp.TabIndex = 12;
            // 
            // btWrite
            // 
            this.btWrite.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWrite.Location = new System.Drawing.Point(311, 8);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(106, 37);
            this.btWrite.TabIndex = 11;
            this.btWrite.Text = "Ghi File";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(6, 58);
            this.richTextBox.Multiline = true;
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(281, 300);
            this.richTextBox.TabIndex = 10;
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(6, 8);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(106, 37);
            this.btRead.TabIndex = 9;
            this.btRead.Text = "Đọc File";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // Lab02_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 407);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbUp);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btRead);
            this.Name = "Lab02_Bai01";
            this.Text = "Lab02_Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbUp;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.TextBox richTextBox;
        private System.Windows.Forms.Button btRead;
    }
}