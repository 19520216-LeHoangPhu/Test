namespace Todo
{
    partial class FTodos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbtodo = new System.Windows.Forms.GroupBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbtodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clid,
            this.cltodo,
            this.clcheckbox});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(50, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // clid
            // 
            this.clid.HeaderText = "ID";
            this.clid.MinimumWidth = 6;
            this.clid.Name = "clid";
            this.clid.ReadOnly = true;
            // 
            // cltodo
            // 
            this.cltodo.HeaderText = "TO DO";
            this.cltodo.MinimumWidth = 6;
            this.cltodo.Name = "cltodo";
            this.cltodo.ReadOnly = true;
            // 
            // clcheckbox
            // 
            this.clcheckbox.HeaderText = "DONE";
            this.clcheckbox.MinimumWidth = 6;
            this.clcheckbox.Name = "clcheckbox";
            this.clcheckbox.ReadOnly = true;
            // 
            // gbtodo
            // 
            this.gbtodo.AutoSize = true;
            this.gbtodo.Controls.Add(this.btsave);
            this.gbtodo.Controls.Add(this.btupdate);
            this.gbtodo.Controls.Add(this.btdelete);
            this.gbtodo.Controls.Add(this.btadd);
            this.gbtodo.Controls.Add(this.dataGridView1);
            this.gbtodo.Controls.Add(this.btlogout);
            this.gbtodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtodo.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbtodo.Location = new System.Drawing.Point(12, 21);
            this.gbtodo.Name = "gbtodo";
            this.gbtodo.Size = new System.Drawing.Size(817, 494);
            this.gbtodo.TabIndex = 6;
            this.gbtodo.TabStop = false;
            this.gbtodo.Text = "To Do";
            // 
            // btsave
            // 
            this.btsave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btsave.Location = new System.Drawing.Point(555, 433);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(97, 35);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // btupdate
            // 
            this.btupdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btupdate.Location = new System.Drawing.Point(294, 433);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(97, 35);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            // 
            // btdelete
            // 
            this.btdelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btdelete.Location = new System.Drawing.Point(424, 433);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(97, 35);
            this.btdelete.TabIndex = 3;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // btadd
            // 
            this.btadd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btadd.Location = new System.Drawing.Point(164, 433);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(97, 35);
            this.btadd.TabIndex = 1;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btlogout
            // 
            this.btlogout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btlogout.Location = new System.Drawing.Point(687, 433);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(97, 35);
            this.btlogout.TabIndex = 5;
            this.btlogout.Text = "Log out";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // FTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 535);
            this.Controls.Add(this.gbtodo);
            this.Name = "FTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTodos_FormClosing);
            this.Load += new System.EventHandler(this.fTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbtodo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clcheckbox;
        private System.Windows.Forms.GroupBox gbtodo;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
    }
}