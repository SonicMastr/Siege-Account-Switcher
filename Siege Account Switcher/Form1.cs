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

namespace Siege_Account_Switcher
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            byte Setup = Properties.Settings.Default.Setup;
            if (Setup == 0)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void Uplay_Click(object sender, EventArgs e)
        {
            //Terminates Uplay Process to ensure auto-login
            foreach (var process in Process.GetProcessesByName("upc"))
            {
                process.Kill();
            }
            //Terminates Siege Process to ensure successful copy
            foreach (var process in Process.GetProcessesByName("RainbowSix"))
            {
                process.Kill();
            }
            MessageBox.Show("Uplay");
        }

        private void Steam_Click(object sender, EventArgs e)
        {
            //Terminates Uplay Process to ensure auto-login
            foreach (var process in Process.GetProcessesByName("upc"))
            {
                process.Kill();
            }
            //Terminates Siege Process to ensure successful copy
            foreach (var process in Process.GetProcessesByName("RainbowSix"))
            {
                process.Kill();
            }
            MessageBox.Show("Steam");
        }

        private void Uplay_MouseEnter(object sender, EventArgs e)
        {
            Scon.Visible = false;
            Ucon.Visible = true;
            Siege.Visible = false;
        }

        private void Steam_MouseEnter(object sender, EventArgs e)
        {
            Scon.Visible = true;
            Ucon.Visible = false;
            Siege.Visible = false;
        }
    }
}
