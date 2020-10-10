namespace Todo
{
    partial class FSignin
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.GbSignin = new System.Windows.Forms.GroupBox();
            this.btsignup = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.btSignin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.GbSignin.SuspendLayout();
            this.SuspendLayout();
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
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(162, 46);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(203, 27);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            // 
            // GbSignin
            // 
            this.GbSignin.Controls.Add(this.btsignup);
            this.GbSignin.Controls.Add(this.btcancel);
            this.GbSignin.Controls.Add(this.btSignin);
            this.GbSignin.Controls.Add(this.tbPassword);
            this.GbSignin.Controls.Add(this.lbUser);
            this.GbSignin.Controls.Add(this.tbUsername);
            this.GbSignin.Controls.Add(this.lbPassword);
            this.GbSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSignin.ForeColor = System.Drawing.Color.DarkCyan;
            this.GbSignin.Location = new System.Drawing.Point(12, 12);
            this.GbSignin.Name = "GbSignin";
            this.GbSignin.Size = new System.Drawing.Size(422, 284);
            this.GbSignin.TabIndex = 4;
            this.GbSignin.TabStop = false;
            this.GbSignin.Text = "Sign in";
            // 
            // btsignup
            // 
            this.btsignup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btsignup.Location = new System.Drawing.Point(14, 201);
            this.btsignup.Name = "btsignup";
            this.btsignup.Size = new System.Drawing.Size(97, 35);
            this.btsignup.TabIndex = 3;
            this.btsignup.Text = "Sign up";
            this.btsignup.UseVisualStyleBackColor = true;
            this.btsignup.Click += new System.EventHandler(this.btsignup_Click);
            // 
            // btcancel
            // 
            this.btcancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btcancel.Location = new System.Drawing.Point(291, 201);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(97, 35);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btSignin
            // 
            this.btSignin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btSignin.Location = new System.Drawing.Point(153, 201);
            this.btSignin.Name = "btSignin";
            this.btSignin.Size = new System.Drawing.Size(97, 35);
            this.btSignin.TabIndex = 2;
            this.btSignin.Text = "Sign in";
            this.btSignin.UseVisualStyleBackColor = true;
            this.btSignin.Click += new System.EventHandler(this.btSignin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(162, 111);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(203, 27);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // FSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(446, 307);
            this.Controls.Add(this.GbSignin);
            this.Name = "FSignin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.fsignin_Load);
            this.GbSignin.ResumeLayout(false);
            this.GbSignin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox GbSignin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btsignup;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btSignin;
    }
}

