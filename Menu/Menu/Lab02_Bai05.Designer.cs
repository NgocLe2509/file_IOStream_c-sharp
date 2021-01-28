namespace Menu
{
    partial class Lab02_Bai05
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
            this.lvShow = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lbPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clSize,
            this.clLast,
            this.ClDate});
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(1, 50);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(871, 465);
            this.lvShow.TabIndex = 4;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "Tên File";
            this.clName.Width = 229;
            // 
            // clSize
            // 
            this.clSize.Text = "Kích Thước";
            this.clSize.Width = 122;
            // 
            // clLast
            // 
            this.clLast.Text = "Đuôi Mở Rộng";
            this.clLast.Width = 113;
            // 
            // ClDate
            // 
            this.ClDate.Text = "Ngày Tạo";
            this.ClDate.Width = 189;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.Location = new System.Drawing.Point(298, 17);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(50, 22);
            this.lbPath.TabIndex = 7;
            this.lbPath.Text = "Path:";
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(354, 17);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(509, 22);
            this.tbPath.TabIndex = 6;
            // 
            // btChoose
            // 
            this.btChoose.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoose.Location = new System.Drawing.Point(13, 6);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(167, 38);
            this.btChoose.TabIndex = 5;
            this.btChoose.Text = "Chọn Folder";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // Lab02_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(874, 516);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btChoose);
            this.Name = "Lab02_Bai05";
            this.Text = "Lab02_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clSize;
        private System.Windows.Forms.ColumnHeader clLast;
        private System.Windows.Forms.ColumnHeader ClDate;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btChoose;
    }
}