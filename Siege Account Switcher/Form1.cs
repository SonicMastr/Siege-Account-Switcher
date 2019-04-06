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

namespace Siege_Account_Switcher
{
    public partial class Form1 : Form
    {
        string WD = Properties.Settings.Default.Directory;
        public Form1()
        {
            InitializeComponent();
            byte Setup = Properties.Settings.Default.Setup;
            //Checks if it's the first run
            //If so, runs setup
            if (Setup == 0)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            //Just incase something screws up. Most likely this won't ever run.
            else if (WD == null)
            {
                MessageBox.Show("There isn't a set game directory \r\n I recommend removing the user.config file from the %appdata%/local/Siege-Account-Switcher directory and restarting.");
            }
        }

        private void Uplay_Click(object sender, EventArgs e)
        {
            //Terminates Uplay Process to ensure auto-login
            foreach (var process in Process.GetProcessesByName("upc"))
            {
                process.Kill();
            }
            uplayc.Visible = true;
            //Terminates Siege Process to ensure successful copy
            foreach (var process in Process.GetProcessesByName("RainbowSix"))
            {
                process.Kill();
            }
            siegec.Visible = true;
            System.Threading.Thread.Sleep(1500);
            //Copies Uplay DLL to Steam Folder
            File.WriteAllBytes(WD + "/defaultargs.dll", Properties.Resources.udefaultargs);
            done.Visible = true;
            DialogResult dRu = MessageBox.Show("Rainbow Six Siege is now the Uplay Version!\r\nDo you want to Start the game now?", "Successful", MessageBoxButtons.YesNo);
            if (dRu == DialogResult.Yes)    
            {
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
                //Close App
                Application.Exit();
            }
        }

        private void Steam_Click(object sender, EventArgs e)
        {
            //Terminates Uplay Process to ensure auto-login
            foreach (var process in Process.GetProcessesByName("upc"))
            {
                process.Kill();
            }
            uplayc.Visible = true;
            //Terminates Siege Process to ensure successful copy
            foreach (var process in Process.GetProcessesByName("RainbowSix"))
            {
                process.Kill();
            }
            siegec.Visible = true;
            System.Threading.Thread.Sleep(1500);
            //Copies Steam DLL to Steam Folder
            File.WriteAllBytes(WD + "/defaultargs.dll", Properties.Resources.sdefaultargs);
            done.Visible = true;
            DialogResult dR = MessageBox.Show("Rainbow Six Siege is now the Steam Version!\r\nDo you want to Start the game now?", "Successful", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            { 
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
                //Close App
                Application.Exit();
            }
        }
        //Hover over Uplay Button
        private void Uplay_MouseEnter(object sender, EventArgs e)
        {
            Scon.Visible = false;
            Ucon.Visible = true;
            Siege.Visible = false;
        }
        //Hover over Steam Button
        private void Steam_MouseEnter(object sender, EventArgs e)
        {
            Scon.Visible = true;
            Ucon.Visible = false;
            Siege.Visible = false;
        }
        //To Restart installation to fix wrong Game Folder
        private void Reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

    }
}
