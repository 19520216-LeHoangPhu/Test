namespace Todo
{
    partial class FDialog
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
            this.gbcontent = new System.Windows.Forms.GroupBox();
            this.tbcontent = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.gbcontent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcontent
            // 
            this.gbcontent.AutoSize = true;
            this.gbcontent.Controls.Add(this.tbcontent);
            this.gbcontent.Controls.Add(this.btok);
            this.gbcontent.Controls.Add(this.btcancel);
            this.gbcontent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcontent.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbcontent.Location = new System.Drawing.Point(12, 12);
            this.gbcontent.Name = "gbcontent";
            this.gbcontent.Size = new System.Drawing.Size(491, 395);
            this.gbcontent.TabIndex = 7;
            this.gbcontent.TabStop = false;
            this.gbcontent.Text = "Content";
            // 
            // tbcontent
            // 
            this.tbcontent.Location = new System.Drawing.Point(3, 23);
            this.tbcontent.Multiline = true;
            this.tbcontent.Name = "tbcontent";
            this.tbcontent.Size = new System.Drawing.Size(468, 275);
            this.tbcontent.TabIndex = 0;
            // 
            // btok
            // 
            this.btok.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btok.Location = new System.Drawing.Point(201, 331);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(97, 35);
            this.btok.TabIndex = 1;
            this.btok.Text = "Ok";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btcancel
            // 
            this.btcancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btcancel.Location = new System.Drawing.Point(354, 331);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(97, 35);
            this.btcancel.TabIndex = 2;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // FDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 431);
            this.Controls.Add(this.gbcontent);
            this.Name = "FDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dialog_FormClosing);
            this.Load += new System.EventHandler(this.Dialog_Load);
            this.gbcontent.ResumeLayout(false);
            this.gbcontent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcontent;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.TextBox tbcontent;
    }
}