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
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath.ToString();
            if (path != "")
            {
                tbPath.Text = path.ToString();
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] fis = di.GetFiles();
                lvShow.Items.Clear();
                foreach (FileInfo fi in fis)
                {
                    string[] arr = new string[4];
                    arr[0] = Path.GetFileName(fi.Name);
                    arr[1] = fi.Length.ToString();
                    arr[2] = Path.GetExtension(fi.Name);
                    arr[3] = fi.CreationTime.ToString();
                    ListViewItem lvi = new ListViewItem(arr);
                    lvShow.Items.Add(lvi);
                }
            }
        }
    }
}
