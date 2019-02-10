using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            fileDialog.Description = "Select the Location of your Rainbow Six Siege Steam Installation Folder";
            fileDialog.ShowNewFolderButton = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Folder.Text = fileDialog.SelectedPath;
                warning.Visible = true;
                Properties.Settings.Default.Directory = fileDialog.SelectedPath;
                wizardPage2.AllowNext = true;
            }
        }

        private void wizardPage1_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {

        }

        private void wizardPage3_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {

        }
    }
}
