namespace BankAccountSystemUI
{
    partial class Home_Admin_Note
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.Registration = new System.Windows.Forms.TabPage();
            this.gbStudentDetails = new System.Windows.Forms.GroupBox();
            this.entryDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.saveCost_btn = new System.Windows.Forms.Button();
            this.writeNote_txt = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.exit_pnl = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lock_pnl = new System.Windows.Forms.PictureBox();
            this.right_pnl = new System.Windows.Forms.Panel();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.home_pnl = new System.Windows.Forms.PictureBox();
            this.home_admin_createAccount_pnl = new System.Windows.Forms.Panel();
            this.rightOptionPnlTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMain.SuspendLayout();
            this.Registration.SuspendLayout();
            this.gbStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pnl)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pnl)).BeginInit();
            this.right_pnl.SuspendLayout();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_pnl)).BeginInit();
            this.home_admin_createAccount_pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Registration.Controls.Add(this.groupBox1);
            this.Registration.Controls.Add(this.gbStudentDetails);
            this.Registration.Location = new System.Drawing.Point(4, 35);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(1033, 573);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Note";
            // 
            // gbStudentDetails
            // 
            this.gbStudentDetails.Controls.Add(this.entryDtp);
            this.gbStudentDetails.Controls.Add(this.label1);
            this.gbStudentDetails.Controls.Add(this.reset_btn);
            this.gbStudentDetails.Controls.Add(this.saveCost_btn);
            this.gbStudentDetails.Controls.Add(this.writeNote_txt);
            this.gbStudentDetails.Controls.Add(this.label29);
            this.gbStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStudentDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentDetails.ForeColor = System.Drawing.Color.Black;
            this.gbStudentDetails.Location = new System.Drawing.Point(15, 4);
            this.gbStudentDetails.Name = "gbStudentDetails";
            this.gbStudentDetails.Size = new System.Drawing.Size(1001, 282);
            this.gbStudentDetails.TabIndex = 0;
            this.gbStudentDetails.TabStop = false;
            this.gbStudentDetails.Text = "Enter Details";
            // 
            // entryDtp
            // 
            this.entryDtp.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.entryDtp.CustomFormat = "MM/dd/yyyy";
            this.entryDtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.entryDtp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDtp.Location = new System.Drawing.Point(163, 24);
            this.entryDtp.Name = "entryDtp";
            this.entryDtp.ShowUpDown = true;
            this.entryDtp.Size = new System.Drawing.Size(212, 27);
            this.entryDtp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date :";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(870, 237);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(121, 31);
            this.reset_btn.TabIndex = 4;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // saveCost_btn
            // 
            this.saveCost_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.saveCost_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.saveCost_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.saveCost_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.saveCost_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.saveCost_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCost_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCost_btn.Location = new System.Drawing.Point(733, 237);
            this.saveCost_btn.Name = "saveCost_btn";
            this.saveCost_btn.Size = new System.Drawing.Size(121, 31);
            this.saveCost_btn.TabIndex = 3;
            this.saveCost_btn.Text = "Save";
            this.saveCost_btn.UseVisualStyleBackColor = false;
            this.saveCost_btn.Click += new System.EventHandler(this.saveCost_btn_Click);
            // 
            // writeNote_txt
            // 
            this.writeNote_txt.BackColor = System.Drawing.Color.Gainsboro;
            this.writeNote_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.writeNote_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeNote_txt.Location = new System.Drawing.Point(163, 57);
            this.writeNote_txt.Multiline = true;
            this.writeNote_txt.Name = "writeNote_txt";
            this.writeNote_txt.Size = new System.Drawing.Size(828, 174);
            this.writeNote_txt.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(8, 94);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(93, 21);
            this.label29.TabIndex = 15;
            this.label29.Text = "Write Note :";
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.tcMain);
            this.pnlMain.Controls.Add(this.lblMainTitle);
            this.pnlMain.Controls.Add(this.lblCopyright);
            this.pnlMain.Location = new System.Drawing.Point(3, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1044, 648);
            this.pnlMain.TabIndex = 17;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(1, 1);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(194, 32);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "Note Something";
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
            // right_pnl
            // 
            this.right_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.right_pnl.Controls.Add(this.pnlRightMain);
            this.right_pnl.Location = new System.Drawing.Point(1055, 2);
            this.right_pnl.Name = "right_pnl";
            this.right_pnl.Size = new System.Drawing.Size(74, 644);
            this.right_pnl.TabIndex = 74;
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
            // home_admin_createAccount_pnl
            // 
            this.home_admin_createAccount_pnl.Controls.Add(this.pnlMain);
            this.home_admin_createAccount_pnl.Location = new System.Drawing.Point(2, 2);
            this.home_admin_createAccount_pnl.Name = "home_admin_createAccount_pnl";
            this.home_admin_createAccount_pnl.Size = new System.Drawing.Size(1047, 644);
            this.home_admin_createAccount_pnl.TabIndex = 75;
            // 
            // rightOptionPnlTimer
            // 
            this.rightOptionPnlTimer.Interval = 1;
            this.rightOptionPnlTimer.Tick += new System.EventHandler(this.rightOptionPnlTimer_Tick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.viewTimePicker);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(870, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "View Detais";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Note :";
            // 
            // viewTimePicker
            // 
            this.viewTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.viewTimePicker.CustomFormat = "MM/dd/yyyy";
            this.viewTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.viewTimePicker.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.viewTimePicker.Location = new System.Drawing.Point(163, 28);
            this.viewTimePicker.Name = "viewTimePicker";
            this.viewTimePicker.ShowUpDown = true;
            this.viewTimePicker.Size = new System.Drawing.Size(212, 27);
            this.viewTimePicker.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(163, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 174);
            this.dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Descriptin";
            this.Column2.Name = "Column2";
            // 
            // Home_Admin_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1131, 648);
            this.Controls.Add(this.right_pnl);
            this.Controls.Add(this.home_admin_createAccount_pnl);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Admin_Note";
            this.Text = "Home_Admin_Note";
            this.Load += new System.EventHandler(this.Home_Admin_Note_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_Admin_Note_MouseMove);
            this.tcMain.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.gbStudentDetails.ResumeLayout(false);
            this.gbStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pnl)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pnl)).EndInit();
            this.right_pnl.ResumeLayout(false);
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home_pnl)).EndInit();
            this.home_admin_createAccount_pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.GroupBox gbStudentDetails;
        private System.Windows.Forms.DateTimePicker entryDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button saveCost_btn;
        private System.Windows.Forms.TextBox writeNote_txt;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox exit_pnl;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox lock_pnl;
        private System.Windows.Forms.Panel right_pnl;
        private System.Windows.Forms.Panel pnlRightMain;
        private System.Windows.Forms.PictureBox home_pnl;
        private System.Windows.Forms.Panel home_admin_createAccount_pnl;
        private System.Windows.Forms.Timer rightOptionPnlTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker viewTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}