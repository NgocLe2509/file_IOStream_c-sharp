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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
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
                string content = sr.ReadToEnd();
                RichTextBox.Text = content;
                // Lay duong dan
                tbPath.Text = ofd.FileName;
                // Lay ten file
                tbFileName.Text = ofd.SafeFileName.ToString(); ;
                // Dem so dong
                int lineCount = 0;
                content = content.Replace("\r\n", "\r");
                lineCount = RichTextBox.Lines.Count();
                content = content.Replace('\r', ' ');
                tbLineNumber.Text = lineCount.ToString();
                // Dem so tu
                int wordCount = 0;
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';',
                ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount = source.Count();
                tbWordNumber.Text = wordCount.ToString();
                // Dem so ki tu
                tbCharacterNumber.Text = content.Length.ToString();
                sr.Close();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
