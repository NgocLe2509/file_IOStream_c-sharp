namespace Menu
{
    partial class Lab02_Bai02
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
            this.lbPath = new System.Windows.Forms.Label();
            this.lbLineNumber = new System.Windows.Forms.Label();
            this.lbWordNumber = new System.Windows.Forms.Label();
            this.lbCharacterNumber = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbLineNumber = new System.Windows.Forms.TextBox();
            this.tbWordNumber = new System.Windows.Forms.TextBox();
            this.tbCharacterNumber = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(668, 332);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(107, 37);
            this.btExit.TabIndex = 25;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.Location = new System.Drawing.Point(11, 138);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(47, 22);
            this.lbPath.TabIndex = 24;
            this.lbPath.Text = "URL";
            // 
            // lbLineNumber
            // 
            this.lbLineNumber.AutoSize = true;
            this.lbLineNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineNumber.Location = new System.Drawing.Point(11, 185);
            this.lbLineNumber.Name = "lbLineNumber";
            this.lbLineNumber.Size = new System.Drawing.Size(78, 22);
            this.lbLineNumber.TabIndex = 23;
            this.lbLineNumber.Text = "Số Dòng";
            // 
            // lbWordNumber
            // 
            this.lbWordNumber.AutoSize = true;
            this.lbWordNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordNumber.Location = new System.Drawing.Point(11, 244);
            this.lbWordNumber.Name = "lbWordNumber";
            this.lbWordNumber.Size = new System.Drawing.Size(59, 22);
            this.lbWordNumber.TabIndex = 22;
            this.lbWordNumber.Text = "Số Từ";
            // 
            // lbCharacterNumber
            // 
            this.lbCharacterNumber.AutoSize = true;
            this.lbCharacterNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharacterNumber.Location = new System.Drawing.Point(11, 298);
            this.lbCharacterNumber.Name = "lbCharacterNumber";
            this.lbCharacterNumber.Size = new System.Drawing.Size(84, 22);
            this.lbCharacterNumber.TabIndex = 21;
            this.lbCharacterNumber.Text = "Số Kí Tự";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(11, 87);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(77, 22);
            this.lbFileName.TabIndex = 20;
            this.lbFileName.Text = "Tên File";
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(108, 135);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(156, 30);
            this.tbPath.TabIndex = 19;
            // 
            // tbLineNumber
            // 
            this.tbLineNumber.Enabled = false;
            this.tbLineNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLineNumber.Location = new System.Drawing.Point(108, 182);
            this.tbLineNumber.Name = "tbLineNumber";
            this.tbLineNumber.Size = new System.Drawing.Size(156, 30);
            this.tbLineNumber.TabIndex = 18;
            // 
            // tbWordNumber
            // 
            this.tbWordNumber.Enabled = false;
            this.tbWordNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWordNumber.Location = new System.Drawing.Point(108, 241);
            this.tbWordNumber.Name = "tbWordNumber";
            this.tbWordNumber.Size = new System.Drawing.Size(156, 30);
            this.tbWordNumber.TabIndex = 17;
            // 
            // tbCharacterNumber
            // 
            this.tbCharacterNumber.Enabled = false;
            this.tbCharacterNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCharacterNumber.Location = new System.Drawing.Point(108, 295);
            this.tbCharacterNumber.Name = "tbCharacterNumber";
            this.tbCharacterNumber.Size = new System.Drawing.Size(156, 30);
            this.tbCharacterNumber.TabIndex = 16;
            // 
            // tbFileName
            // 
            this.tbFileName.Enabled = false;
            this.tbFileName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileName.Location = new System.Drawing.Point(108, 84);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(156, 30);
            this.tbFileName.TabIndex = 15;
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(15, 12);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(249, 42);
            this.btRead.TabIndex = 14;
            this.btRead.Text = "Đọc File";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox.Location = new System.Drawing.Point(298, 12);
            this.RichTextBox.Multiline = true;
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(477, 305);
            this.RichTextBox.TabIndex = 13;
            // 
            // Lab02_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 377);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbLineNumber);
            this.Controls.Add(this.lbWordNumber);
            this.Controls.Add(this.lbCharacterNumber);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbLineNumber);
            this.Controls.Add(this.tbWordNumber);
            this.Controls.Add(this.tbCharacterNumber);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.RichTextBox);
            this.Name = "Lab02_Bai02";
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbLineNumber;
        private System.Windows.Forms.Label lbWordNumber;
        private System.Windows.Forms.Label lbCharacterNumber;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbLineNumber;
        private System.Windows.Forms.TextBox tbWordNumber;
        private System.Windows.Forms.TextBox tbCharacterNumber;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.TextBox RichTextBox;
    }
}