namespace Siege_Account_Switcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Steam = new System.Windows.Forms.Button();
            this.Uplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uplayc = new System.Windows.Forms.Label();
            this.siegec = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Steam
            // 
            this.Steam.BackColor = System.Drawing.Color.Transparent;
            this.Steam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Steam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Steam.Location = new System.Drawing.Point(78, 220);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(146, 47);
            this.Steam.TabIndex = 1;
            this.Steam.Text = "Steam";
            this.Steam.UseVisualStyleBackColor = false;
            this.Steam.Click += new System.EventHandler(this.Steam_Click);
            this.Steam.MouseEnter += new System.EventHandler(this.Steam_MouseEnter);
            this.Steam.MouseLeave += new System.EventHandler(this.Steam_MouseLeave);
            // 
            // Uplay
            // 
            this.Uplay.BackColor = System.Drawing.Color.Transparent;
            this.Uplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Uplay.Location = new System.Drawing.Point(633, 220);
            this.Uplay.Name = "Uplay";
            this.Uplay.Size = new System.Drawing.Size(146, 47);
            this.Uplay.TabIndex = 2;
            this.Uplay.Text = "Uplay";
            this.Uplay.UseVisualStyleBackColor = false;
            this.Uplay.Click += new System.EventHandler(this.Uplay_Click);
            this.Uplay.MouseEnter += new System.EventHandler(this.Uplay_MouseEnter);
            this.Uplay.MouseLeave += new System.EventHandler(this.Uplay_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Siege Account Switcher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "By SonicMastr";
            // 
            // uplayc
            // 
            this.uplayc.BackColor = System.Drawing.Color.Transparent;
            this.uplayc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uplayc.Location = new System.Drawing.Point(378, 383);
            this.uplayc.Name = "uplayc";
            this.uplayc.Size = new System.Drawing.Size(107, 23);
            this.uplayc.TabIndex = 9;
            this.uplayc.Text = "Uplay Closed...";
            this.uplayc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uplayc.Visible = false;
            // 
            // siegec
            // 
            this.siegec.BackColor = System.Drawing.Color.Transparent;
            this.siegec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.siegec.Location = new System.Drawing.Point(378, 406);
            this.siegec.Name = "siegec";
            this.siegec.Size = new System.Drawing.Size(107, 23);
            this.siegec.TabIndex = 10;
            this.siegec.Text = "Siege Closed...";
            this.siegec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siegec.Visible = false;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.Transparent;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.LimeGreen;
            this.done.Location = new System.Drawing.Point(377, 429);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(108, 23);
            this.done.TabIndex = 11;
            this.done.Text = "DONE!";
            this.done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.done.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(567, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "文件夹选错了？";
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.LinkColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(721, 454);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(117, 13);
            this.Reset.TabIndex = 13;
            this.Reset.TabStop = true;
            this.Reset.Text = "更改";
            this.Reset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reset_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Siege_Account_Switcher.Properties.Resources.R6S_Year_4_Keyart_ENG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.done);
            this.Controls.Add(this.siegec);
            this.Controls.Add(this.uplayc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siege Account Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button Uplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uplayc;
        private System.Windows.Forms.Label siegec;
        private System.Windows.Forms.Label done;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Reset;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

