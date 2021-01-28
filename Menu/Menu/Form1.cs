using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bài01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Lab02_Bai01))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }

            if (!_IsActive)
            {
                Lab02_Bai01 PreTest = new Lab02_Bai01();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void bài02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Lab02_Bai02))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }

            if (!_IsActive)
            {
                Lab02_Bai02 PreTest = new Lab02_Bai02();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void bài03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Lab02_Bai03))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }

            if (!_IsActive)
            {
                Lab02_Bai03 PreTest = new Lab02_Bai03();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void bài04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Lab02_Bai04))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }

            if (!_IsActive)
            {
                Lab02_Bai04 PreTest = new Lab02_Bai04();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void bài05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Lab02_Bai05))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }

            if (!_IsActive)
            {
                Lab02_Bai05 PreTest = new Lab02_Bai05();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }
    }
}
