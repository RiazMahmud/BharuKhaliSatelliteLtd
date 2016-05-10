namespace BankAccountSystemUI
{
    partial class Home_Admin_Total_User
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
            this.components = new System.ComponentModel.Container();
            this.rightOptionPnlTimer = new System.Windows.Forms.Timer(this.components);
            this.lock_pnl = new System.Windows.Forms.PictureBox();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.exit_pnl = new System.Windows.Forms.PictureBox();
            this.home_pnl = new System.Windows.Forms.PictureBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.home_admin_createAccount_pnl = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.Registration = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalUserGridView = new System.Windows.Forms.DataGridView();
            this.right_pnl = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.time_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalUser_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pnl)).BeginInit();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pnl)).BeginInit();
            this.home_admin_createAccount_pnl.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.Registration.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalUserGridView)).BeginInit();
            this.right_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightOptionPnlTimer
            // 
            this.rightOptionPnlTimer.Interval = 1;
            this.rightOptionPnlTimer.Tick += new System.EventHandler(this.rightOptionPnlTimer_Tick);
            // 
            // lock_pnl
            // 
            this.lock_pnl.BackgroundImage = global::BankAccountSystemUI.Properties.Resources.appbar_lock;
            this.lock_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lock_pnl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lock_pnl.Location = new System.Drawing.Point(-3, 160);
            this.lock_pnl.Name = "lock_pnl";
            this.lock_pnl.Size = new System.Drawing.Size(76, 76);
            this.lock_pnl.TabIndex = 4;
            this.lock_pnl.TabStop = false;
            this.lock_pnl.Click += new System.EventHandler(this.lock_pnl_Click);
            this.lock_pnl.MouseLeave += new System.EventHandler(this.lock_pnl_MouseLeave);
            this.lock_pnl.MouseHover += new System.EventHandler(this.lock_pnl_MouseHover);
            // 
            // pnlRightMain
            // 
            this.pnlRightMain.Controls.Add(this.exit_pnl);
            this.pnlRightMain.Controls.Add(this.lock_pnl);
            this.pnlRightMain.Controls.Add(this.home_pnl);
            this.pnlRightMain.Location = new System.Drawing.Point(3, 52);
            this.pnlRightMain.Name = "pnlRightMain";
            this.pnlRightMain.Size = new System.Drawing.Size(70, 396);
            this.pnlRightMain.TabIndex = 1;
            // 
            // exit_pnl
            // 
            this.exit_pnl.BackgroundImage = global::BankAccountSystemUI.Properties.Resources.appbar1;
            this.exit_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_pnl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_pnl.Location = new System.Drawing.Point(-3, 320);
            this.exit_pnl.Name = "exit_pnl";
            this.exit_pnl.Size = new System.Drawing.Size(76, 76);
            this.exit_pnl.TabIndex = 5;
            this.exit_pnl.TabStop = false;
            this.exit_pnl.Click += new System.EventHandler(this.exit_pnl_Click);
            this.exit_pnl.MouseLeave += new System.EventHandler(this.exit_pnl_MouseLeave);
            this.exit_pnl.MouseHover += new System.EventHandler(this.exit_pnl_MouseHover);
            // 
            // home_pnl
            // 
            this.home_pnl.BackgroundImage = global::BankAccountSystemUI.Properties.Resources.appbar_home;
            this.home_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_pnl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.home_pnl.Location = new System.Drawing.Point(-3, 0);
            this.home_pnl.Name = "home_pnl";
            this.home_pnl.Size = new System.Drawing.Size(76, 76);
            this.home_pnl.TabIndex = 3;
            this.home_pnl.TabStop = false;
            this.home_pnl.Click += new System.EventHandler(this.home_pnl_Click);
            this.home_pnl.MouseLeave += new System.EventHandler(this.home_pnl_MouseLeave);
            this.home_pnl.MouseHover += new System.EventHandler(this.home_pnl_MouseHover);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(-3, 1);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(124, 32);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "Total User";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(403, 624);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(219, 21);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Copyright @ Technoxen, 2014";
            // 
            // home_admin_createAccount_pnl
            // 
            this.home_admin_createAccount_pnl.Controls.Add(this.pnlMain);
            this.home_admin_createAccount_pnl.Location = new System.Drawing.Point(2, 2);
            this.home_admin_createAccount_pnl.Name = "home_admin_createAccount_pnl";
            this.home_admin_createAccount_pnl.Size = new System.Drawing.Size(1047, 644);
            this.home_admin_createAccount_pnl.TabIndex = 217;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.tcMain);
            this.pnlMain.Controls.Add(this.lblMainTitle);
            this.pnlMain.Controls.Add(this.lblCopyright);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1047, 648);
            this.pnlMain.TabIndex = 17;
            // 
            // tcMain
            // 
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.Registration);
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.HotTrack = true;
            this.tcMain.Location = new System.Drawing.Point(3, 36);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1041, 612);
            this.tcMain.TabIndex = 6;
            this.tcMain.TabStop = false;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.White;
            this.Registration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Registration.Controls.Add(this.groupBox2);
            this.Registration.Location = new System.Drawing.Point(4, 35);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(1033, 573);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Total User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalUser_lbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.totalUserGridView);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 568);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total User";
            // 
            // totalUserGridView
            // 
            this.totalUserGridView.BackgroundColor = System.Drawing.Color.White;
            this.totalUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalUserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Gender,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.totalUserGridView.Location = new System.Drawing.Point(13, 34);
            this.totalUserGridView.Name = "totalUserGridView";
            this.totalUserGridView.Size = new System.Drawing.Size(974, 500);
            this.totalUserGridView.TabIndex = 1;
            // 
            // right_pnl
            // 
            this.right_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.right_pnl.Controls.Add(this.pnlRightMain);
            this.right_pnl.Location = new System.Drawing.Point(1055, 2);
            this.right_pnl.Name = "right_pnl";
            this.right_pnl.Size = new System.Drawing.Size(74, 644);
            this.right_pnl.TabIndex = 216;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(651, 601);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 30);
            this.cancel.TabIndex = 213;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.ForeColor = System.Drawing.Color.White;
            this.time_lbl.Location = new System.Drawing.Point(2, 607);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(0, 19);
            this.time_lbl.TabIndex = 215;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label12.Location = new System.Drawing.Point(322, 616);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 15);
            this.label12.TabIndex = 214;
            this.label12.Text = "All rights reserved by Riaz Mahmud";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "User Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Date Of Birth";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Occupation";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Entry Fee";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Mobile No";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Landline No";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Email";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Entry Date";
            this.Column10.Name = "Column10";
            // 
            // totalUser_lbl
            // 
            this.totalUser_lbl.AutoSize = true;
            this.totalUser_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUser_lbl.Location = new System.Drawing.Point(855, 543);
            this.totalUser_lbl.Name = "totalUser_lbl";
            this.totalUser_lbl.Size = new System.Drawing.Size(0, 21);
            this.totalUser_lbl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total User :";
            // 
            // Home_Admin_Total_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1131, 648);
            this.Controls.Add(this.home_admin_createAccount_pnl);
            this.Controls.Add(this.right_pnl);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Admin_Total_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document";
            this.Load += new System.EventHandler(this.Document_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_Admin_Total_User_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.lock_pnl)).EndInit();
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit_pnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pnl)).EndInit();
            this.home_admin_createAccount_pnl.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalUserGridView)).EndInit();
            this.right_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer rightOptionPnlTimer;
        private System.Windows.Forms.PictureBox lock_pnl;
        private System.Windows.Forms.Panel pnlRightMain;
        private System.Windows.Forms.PictureBox exit_pnl;
        private System.Windows.Forms.PictureBox home_pnl;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel home_admin_createAccount_pnl;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView totalUserGridView;
        private System.Windows.Forms.Panel right_pnl;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label totalUser_lbl;
        private System.Windows.Forms.Label label1;



    }
}