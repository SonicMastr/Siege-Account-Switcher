using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

// I am aware this code is redundant as fuck. It works and is pretty simple so I don't feel like refactoring just for the sake of it. lol

namespace Siege_Account_Switcher
{
    public partial class Form1 : Form
    {
        string WD = Properties.Settings.Default.Directory;
        public Form1()
        {
            InitializeComponent();
            byte Setup = Properties.Settings.Default.Setup;
            //Checks if it's the first run. If so, runs setup
            if (Setup == 0)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            //Just incase something screws up. Most likely this will never run.
            else if (WD == null)
            {
                MessageBox.Show("There isn't a set game directory \r\n I recommend removing the user.config file from the %appdata%/local/Siege-Account-Switcher directory and restarting.");
            }
        }


        private void Uplay_Click(object sender, EventArgs e)
        {
            KillUplay();
            //Copies Uplay DLL to Steam Folder
            File.WriteAllBytes(WD + "/defaultargs.dll", Properties.Resources.udefaultargs);
            done.Visible = true;
            MessageBoxManager.Yes = "DX11";
            MessageBoxManager.No = "Vulkan";
            MessageBoxManager.Cancel = "Close";
            DialogResult dRu = MessageBox.Show("Rainbow Six Siege is now the Uplay Version!\r\n\r\nDo you want to use DirectX 11 or Vulkan?", "Uplay", MessageBoxButtons.YesNoCancel);
            if (dRu == DialogResult.Yes)    
            {
                //Start DX11
                try
                {
                    //Start Siege and then Exit
                    Process.Start(WD + "/RainbowSix.exe");
                    Application.Exit();
                }

                //If Siege can't start
                catch (Exception)
                {
                    DialogResult eresult = MessageBox.Show("An error Occured. Did you set the correct directory?","Error Starting Siege", MessageBoxButtons.OK);
                    if (eresult == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }

            }
            else if (dRu == DialogResult.No)
            {
                //Start Vulkan
                try
                {
                    //Start Siege and then Exit
                    Process.Start(WD + "/RainbowSix_Vulkan.exe");
                    Application.Exit();
                }

                //If Siege can't start
                catch (Exception)
                {
                    DialogResult eresult = MessageBox.Show("An error Occured. Did you set the correct directory?", "Error Starting Siege", MessageBoxButtons.OK);
                    if (eresult == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            } else if (dRu == DialogResult.Cancel)
            {
                //Close App
                Application.Exit();
            }
        }

        private void Steam_Click(object sender, EventArgs e)
        {
            KillUplay();
            //Copies Steam DLL to Steam Folder
            File.WriteAllBytes(WD + "/defaultargs.dll", Properties.Resources.sdefaultargs);
            done.Visible = true;
            MessageBoxManager.Yes = "DX11";
            MessageBoxManager.No = "Vulkan";
            MessageBoxManager.Cancel = "Close";
            DialogResult dR = MessageBox.Show("Rainbow Six Siege is now the Steam Version!\r\n\r\nDo you want to use DirectX 11 or Vulkan?", "Steam", MessageBoxButtons.YesNoCancel);
            if (dR == DialogResult.Yes)
            {
                //Start DX11
                try
                {
                    //Start Siege and then Exit
                    Process.Start(WD + "/RainbowSix.exe");
                    Application.Exit();
                }

                //If Siege can't start
                catch (Exception)
                {
                    DialogResult eresult = MessageBox.Show("An error Occured. Did you set the correct directory?", "Error Starting Siege", MessageBoxButtons.OK);
                    if (eresult == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }

            }
            else if (dR == DialogResult.No)
            {
                //Start Vulkan
                try
                {
                    //Start Siege and then Exit
                    Process.Start(WD + "/RainbowSix_Vulkan.exe");
                    Application.Exit();
                }

                //If Siege can't start
                catch (Exception)
                {
                    DialogResult eresult = MessageBox.Show("An error Occured. Did you set the correct directory?", "Error Starting Siege", MessageBoxButtons.OK);
                    if (eresult == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            else if (dR == DialogResult.Cancel)
            {
                //Close App
                Application.Exit();
            }
        }



        //Hover over Uplay Button
        private void Uplay_MouseEnter(object sender, EventArgs e)
        {
            Uplay.BackColor = Color.FromArgb(50, 35, 251, 255);
        }

        private void Uplay_MouseLeave(object sender, EventArgs e)
        {
            Uplay.BackColor = Color.Transparent;
        }

        //Hover over Steam Button
        private void Steam_MouseEnter(object sender, EventArgs e)
        {
            Steam.BackColor = Color.FromArgb(50, 35, 251, 255);
        }

        private void Steam_MouseLeave(object sender, EventArgs e)
        {
            Steam.BackColor = Color.Transparent;
        }




        //To Restart installation to fix wrong Game Folder
        private void Reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            folderBrowserDialog1.SelectedPath = WD;
            folderBrowserDialog1.ShowNewFolderButton = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.Directory = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                WD = Properties.Settings.Default.Directory;
            }
            MessageBox.Show("New Directory:\r\n\n" + WD, "Changed Directory", MessageBoxButtons.OK);
        }



        private void KillUplay()
        {
            //Terminates Uplay Process to ensure auto-login
            foreach (var process in Process.GetProcessesByName("upc"))
            {
                process.Kill();
                process.WaitForExit();
            }
            uplayc.Visible = true;
            //Terminates Siege Process to ensure successful copy
            foreach (var process in Process.GetProcessesByName("RainbowSix"))
            {
                process.Kill();
                process.WaitForExit();
            }
            foreach (var process in Process.GetProcessesByName("RainbowSix_Vulkan"))
            {
                process.Kill();
                process.WaitForExit();
            }
            siegec.Visible = true;
        }
    }
}
