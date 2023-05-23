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

namespace Siege_Account_Switcher
{
    public partial class Form2 : Form
    {
        FolderBrowserDialog fileDialog = new FolderBrowserDialog();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (wizardControl1.SelectedPage == wizardPage6)
            {
                Properties.Settings.Default.Setup = 1;
                Properties.Settings.Default.Save();
            }
            if (wizardControl1.SelectedPage == wizardPage5)
            {
                wizardPage5.NextPage = wizardPage6;
            }
            if (wizardControl1.SelectedPage == wizardPage3)
            {
                Properties.Settings.Default.Save();
                string WD = Properties.Settings.Default.Directory;
                File.WriteAllBytes(WD + "/defaultargs.dll", Properties.Resources.udefaultargs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            fileDialog.Description = "选择R6 Steam版本的安装路径";
            fileDialog.ShowNewFolderButton = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Folder.Text = fileDialog.SelectedPath;
                warning.Visible = true;
                Properties.Settings.Default.Directory = fileDialog.SelectedPath;
                wizardPage2.NextPage = wizardPage3;
                wizardPage2.AllowNext = true;
            }
        }

    }
}
