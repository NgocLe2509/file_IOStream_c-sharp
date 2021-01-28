namespace Menu
{
    partial class Lab02_Bai03
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
            this.tbPrintResult = new System.Windows.Forms.TextBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(830, 412);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 36);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbPrintResult
            // 
            this.tbPrintResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrintResult.Location = new System.Drawing.Point(480, 12);
            this.tbPrintResult.Multiline = true;
            this.tbPrintResult.Name = "tbPrintResult";
            this.tbPrintResult.Size = new System.Drawing.Size(439, 378);
            this.tbPrintResult.TabIndex = 10;
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(643, 412);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(139, 34);
            this.btPrint.TabIndex = 9;
            this.btPrint.Text = "In file kết quả";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btWrite
            // 
            this.btWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWrite.Location = new System.Drawing.Point(342, 413);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(214, 35);
            this.btWrite.TabIndex = 8;
            this.btWrite.Text = "Lưu file và tính toán";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(91, 412);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(139, 34);
            this.btRead.TabIndex = 7;
            this.btRead.Text = "Đọc file";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox.Location = new System.Drawing.Point(12, 12);
            this.RichTextBox.Multiline = true;
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(439, 378);
            this.RichTextBox.TabIndex = 6;
            // 
            // Lab02_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 460);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbPrintResult);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.RichTextBox);
            this.Name = "Lab02_Bai03";
            this.Text = "Lab02_Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbPrintResult;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.TextBox RichTextBox;
    }
}