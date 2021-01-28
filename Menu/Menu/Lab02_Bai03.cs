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
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        public static int check_character(string temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' &&
                    temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9' &&
                    temp[i] != '+' && temp[i] != '-' && temp[i] != '*' && temp[i] != '/' && temp[i] != ' ')
                    return 0;
            }
            return 1;
        }
        public static string calculator(string temp)
        {
            int flag = 0;
            string result = temp + "=";
            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (temp[i] == '+')
                {
                    flag = 1;
                    break;
                }
                if (temp[i] == '-')
                {
                    flag = 2;
                    break;
                }
                if (temp[i] == '*')
                {
                    flag = 3;
                    break;
                }
                if (temp[i] == '/')
                {
                    flag = 4;
                    break;
                }
            }
            string[] number = temp.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            int num1 = int.Parse(number[0].ToString());
            int num2 = int.Parse(number[1].ToString());
            switch (flag)
            {
                case 1:
                    result += (num1 + num2).ToString();
                    break;
                case 2:
                    result += (num1 - num2).ToString();
                    break;
                case 3:
                    result += (num1 * num2).ToString();
                    break;
                case 4:
                    result += ((float)num1 / num2).ToString();
                    break;
                default:
                    break;
            }
            return result;
        }
        public static string calculatorLine(string temp)
        {
            string result = "";
            string[] lines = temp.Split('\n');
            foreach (string line in lines)
            {
                if (check_character(line.Trim()) == 1)
                    result += calculator(line.Trim()) + "\r\n";
                else result += line.Trim() + " Error: Phép tính có kí tự đặc biệt\r\n";
            }
            return result;
        }
        private void btRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                RichTextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, true);
                string content = "";
                if (RichTextBox.Text == "")
                {
                    content = "";
                }
                else
                {
                        content = calculatorLine(RichTextBox.Text);
                }
                sw.WriteLine(content);
                sw.Close();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (RichTextBox.Text != "")
            {
                string content = calculatorLine(RichTextBox.Text);
                tbPrintResult.Text = content;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
