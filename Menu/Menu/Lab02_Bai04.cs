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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Menu
{
    public partial class Lab02_Bai04 : Form
    {
        public Lab02_Bai04()
        {
            InitializeComponent();
        }
        [Serializable()]
        public class infoStudent
        {
            public string MSSV;
            public string Name;
            public string NumberPhone;
            public float Math;
            public float Literature;
            public float DTB;
        }

        public static int check(string MSSV, string Name, string numberPhone, string Math, string Literature)
        {
            if (Name == "")
            {
                MessageBox.Show("Chưa nhập Họ Tên!");
                return 0;
            }
            else if(MSSV == "")
            {
                MessageBox.Show("Chưa nhập MSSV!");
                return 0;
            }
            else if (numberPhone == "")
            {
                MessageBox.Show("Chưa nhập Số Điện Thoại!");
                return 0;
            }
            else if (Math == "")
            {
                MessageBox.Show("Chưa nhập điểm Toán!");
                return 0;
            }
            else if (Math != "0" && Math != "1" && Math != "2" && Math != "3" && Math != "4" && Math != "5" &&
                    Math != "6" && Math != "7" && Math != "8" && Math != "9" && Math != "10")
            {
                MessageBox.Show("Nhập điểm Toán chưa đúng!");
                return 0;
            }
            else if (Literature == "")
            {
                MessageBox.Show("Chưa nhập điểm Văn!");
                return 0;
            }
            else if (Literature != "0" && Literature != "1" && Literature != "2" && Literature != "3" &&
                Literature != "4" && Literature != "5" && Literature != "6" && Literature != "7" && Literature != "8" 
                && Literature != "9" && Literature != "10")
            {
                MessageBox.Show("Nhập điểm Văn chưa đúng!");
                return 0;
            }
            return 1;
        }
        //
        //
        private void btRead_Click(object sender, EventArgs e)
        {
            if (check(tbMSSV.Text, tbName.Text, tbnumberPhone.Text, tbMath.Text, tbLiterature.Text) == 1)
            {
                infoStudent info = new infoStudent();
                info.MSSV = tbMSSV.Text;
                info.Name = tbName.Text;
                info.NumberPhone = tbnumberPhone.Text;
                info.Math = float.Parse(tbMath.Text);
                info.Literature = float.Parse(tbLiterature.Text);
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.ShowDialog();
                    if (sfd.FileName != "")
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Append);
                        bf.Serialize(fs, info);
                        fs.Close();
                        MessageBox.Show("Thêm Học Viên Thành Công");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm Học Viên Không Thành Công");
                }
            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            infoStudent info = new infoStudent();
            BinaryFormatter bf = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                tbPath.Text = ofd.FileName;
                string content = "";
                while (fs.Position != fs.Length)
                {
                    info = (infoStudent)bf.Deserialize(fs);
                    content += "\r\nMSSV: " + info.MSSV + "\r\nHọ Tên: " + info.Name +
                    "\r\nSố Điện thoại: " + info.NumberPhone + "\r\nToán: " + info.Math + "\r\nVăn: " + info.Literature + "\r\n";
                }
                RichTextBox.Text = content;
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                FileStream _fs = new FileStream(sfd.FileName, FileMode.Create);
                infoStudent info = new infoStudent();
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(tbPath.Text, FileMode.OpenOrCreate);
                string content = "";
                while (fs.Position != fs.Length)
                {
                    info = (infoStudent)bf.Deserialize(fs);
                    info.DTB = (float)(info.Math + info.Literature) / 2;
                    bf.Serialize(_fs, info);
                    content += "\r\nMSSV: " + info.MSSV + "\r\nHọ Tên: " + info.Name +
                    "\r\nSố Điện thoại: " + info.NumberPhone + "\r\nToán: " + info.Math + "\r\nVăn: " + info.Literature
                    + "\r\nĐiểm Trung Bình: " + info.DTB + "\r\n";
                }
                tbWrite.Text = content;
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void btDelData_Click(object sender, EventArgs e)
        {
            tbMSSV.Text = "";
            tbName.Text = "";
            tbnumberPhone.Text = "";
            tbMath.Text = "";
            tbLiterature.Text = "";
        }
    }
}
