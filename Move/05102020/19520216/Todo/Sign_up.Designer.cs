namespace Todo
{
    partial class FSignup
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
            this.gbsignup = new System.Windows.Forms.GroupBox();
            this.tbconfirmpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btsigup = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.gbsignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsignup
            // 
            this.gbsignup.Controls.Add(this.tbconfirmpass);
            this.gbsignup.Controls.Add(this.label1);
            this.gbsignup.Controls.Add(this.btsigup);
            this.gbsignup.Controls.Add(this.btcancel);
            this.gbsignup.Controls.Add(this.tbpassword);
            this.gbsignup.Controls.Add(this.lbUser);
            this.gbsignup.Controls.Add(this.tbUsername);
            this.gbsignup.Controls.Add(this.lbPassword);
            this.gbsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsignup.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbsignup.Location = new System.Drawing.Point(12, 18);
            this.gbsignup.Name = "gbsignup";
            this.gbsignup.Size = new System.Drawing.Size(454, 307);
            this.gbsignup.TabIndex = 5;
            this.gbsignup.TabStop = false;
            this.gbsignup.Text = "Sign up";
            // 
            // tbconfirmpass
            // 
            this.tbconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbconfirmpass.Location = new System.Drawing.Point(231, 174);
            this.tbconfirmpass.Name = "tbconfirmpass";
            this.tbconfirmpass.Size = new System.Drawing.Size(203, 27);
            this.tbconfirmpass.TabIndex = 5;
            this.tbconfirmpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbconfirmpass_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(6, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirm Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btsigup
            // 
            this.btsigup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btsigup.Location = new System.Drawing.Point(50, 242);
            this.btsigup.Name = "btsigup";
            this.btsigup.Size = new System.Drawing.Size(97, 35);
            this.btsigup.TabIndex = 3;
            this.btsigup.Text = "Sign up";
            this.btsigup.UseVisualStyleBackColor = true;
            this.btsigup.Click += new System.EventHandler(this.btsigup_Click);
            // 
            // btcancel
            // 
            this.btcancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btcancel.Location = new System.Drawing.Point(303, 242);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(97, 35);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(231, 114);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(203, 27);
            this.tbpassword.TabIndex = 1;
            this.tbpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpassword_KeyDown);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUser.Location = new System.Drawing.Point(6, 49);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(105, 24);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Username";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(231, 49);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(203, 27);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbPassword.Location = new System.Drawing.Point(6, 114);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 24);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 337);
            this.Controls.Add(this.gbsignup);
            this.Name = "FSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSignup_FormClosing);
            this.Load += new System.EventHandler(this.FSignup_Load);
            this.gbsignup.ResumeLayout(false);
            this.gbsignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsignup;
        private System.Windows.Forms.Button btsigup;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbconfirmpass;
        private System.Windows.Forms.Label label1;
    }
}