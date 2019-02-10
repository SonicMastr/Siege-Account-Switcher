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
            this.Steam = new System.Windows.Forms.Button();
            this.Uplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Siege = new System.Windows.Forms.PictureBox();
            this.Scon = new System.Windows.Forms.PictureBox();
            this.Ucon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Siege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ucon)).BeginInit();
            this.SuspendLayout();
            // 
            // Steam
            // 
            this.Steam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steam.Location = new System.Drawing.Point(270, 182);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(146, 47);
            this.Steam.TabIndex = 1;
            this.Steam.Text = "Steam";
            this.Steam.UseVisualStyleBackColor = true;
            this.Steam.Click += new System.EventHandler(this.Steam_Click);
            this.Steam.MouseEnter += new System.EventHandler(this.Steam_MouseEnter);
            // 
            // Uplay
            // 
            this.Uplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uplay.Location = new System.Drawing.Point(442, 182);
            this.Uplay.Name = "Uplay";
            this.Uplay.Size = new System.Drawing.Size(146, 47);
            this.Uplay.TabIndex = 2;
            this.Uplay.Text = "Uplay";
            this.Uplay.UseVisualStyleBackColor = true;
            this.Uplay.Click += new System.EventHandler(this.Uplay_Click);
            this.Uplay.MouseEnter += new System.EventHandler(this.Uplay_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Siege Account Switcher";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Which Version You Want to Use";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "By SonicMastr";
            // 
            // Siege
            // 
            this.Siege.Image = global::Siege_Account_Switcher.Properties.Resources.d9hlqg4_429ebd49_a8ef_4c4b_9787_112c00d71d99;
            this.Siege.Location = new System.Drawing.Point(37, 92);
            this.Siege.Name = "Siege";
            this.Siege.Size = new System.Drawing.Size(201, 201);
            this.Siege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Siege.TabIndex = 6;
            this.Siege.TabStop = false;
            // 
            // Scon
            // 
            this.Scon.Image = global::Siege_Account_Switcher.Properties.Resources._512px_Steam_icon_logo_svg;
            this.Scon.Location = new System.Drawing.Point(37, 92);
            this.Scon.Name = "Scon";
            this.Scon.Size = new System.Drawing.Size(201, 201);
            this.Scon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scon.TabIndex = 5;
            this.Scon.TabStop = false;
            this.Scon.Visible = false;
            // 
            // Ucon
            // 
            this.Ucon.Image = global::Siege_Account_Switcher.Properties.Resources.DfekaqCWkAAt2X5;
            this.Ucon.Location = new System.Drawing.Point(37, 92);
            this.Ucon.Name = "Ucon";
            this.Ucon.Size = new System.Drawing.Size(201, 201);
            this.Ucon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ucon.TabIndex = 0;
            this.Ucon.TabStop = false;
            this.Ucon.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Siege);
            this.Controls.Add(this.Scon);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uplay);
            this.Controls.Add(this.Ucon);
            this.Name = "Form1";
            this.Text = "Siege Account Switcher";
            ((System.ComponentModel.ISupportInitialize)(this.Siege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ucon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ucon;
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button Uplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Scon;
        private System.Windows.Forms.PictureBox Siege;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

