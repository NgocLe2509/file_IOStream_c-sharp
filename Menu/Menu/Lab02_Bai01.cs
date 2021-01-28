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

namespace Menu
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName.ToString() != "")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                richTextBox.Text = sr.ReadToEnd();
                fs.Close();
            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, true);
                string[] lines = richTextBox.Text.Split('\n');
                string result = "";
                foreach (string line in lines)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Trim() != "")
                        {
                            if (word[0] != '0' && word[0] != '1' && word[0] != '2' && word[0] != '3' && word[0] != '4' &&
                                word[0] != '5' && word[0] != '6' && word[0] != '7' && word[0] != '8' && word[0] != '9')
                            {
                                if (word.Length > 1)
                                {
                                    result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                                }
                                else result += word.ToUpper() + " ";
                            }
                            else result += word.Trim();
                        }
                    }
                    result += "\r\n";
                }
                tbUp.Text = result;
                sw.WriteLine(result);
                sw.Close();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
