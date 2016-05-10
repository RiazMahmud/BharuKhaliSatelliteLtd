namespace BankAccountSystemUI
{
    partial class Home_Admin_Owner_Income_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Admin_Owner_Income_Details));
            this.home_admin_createAccount_pnl = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.right_pnl = new System.Windows.Forms.Panel();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.exit_pnl = new System.Windows.Forms.PictureBox();
            this.lock_pnl = new System.Windows.Forms.PictureBox();
            this.home_pnl = new System.Windows.Forms.PictureBox();
            this.rightOptionPnlTimer = new System.Windows.Forms.Timer(this.components);
            this.VSTprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.VSTprintDocument = new System.Drawing.Printing.PrintDocument();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.Registration = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ownerDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home_admin_createAccount_pnl.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.right_pnl.SuspendLayout();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pnl)).BeginInit();
            this.tcMain.SuspendLayout();
            this.Registration.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // home_admin_createAccount_pnl
            // 
            this.home_admin_createAccount_pnl.Controls.Add(this.pnlMain);
            this.home_admin_createAccount_pnl.Location = new System.Drawing.Point(2, 2);
            this.home_admin_createAccount_pnl.Name = "home_admin_createAccount_pnl";
            this.home_admin_createAccount_pnl.Size = new System.Drawing.Size(1047, 644);
            this.home_admin_createAccount_pnl.TabIndex = 75;
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
            this.lblMainTitle.Size = new System.Drawing.Size(240, 32);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "Owner Income Panel";
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
            this.home_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.home_pnl_MouseMove);
            // 
            // rightOptionPnlTimer
            // 
            this.rightOptionPnlTimer.Interval = 1;
            this.rightOptionPnlTimer.Tick += new System.EventHandler(this.rightOptionPnlTimer_Tick);
            // 
            // VSTprintPreviewDialog
            // 
            this.VSTprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.VSTprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.VSTprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.VSTprintPreviewDialog.Enabled = true;
            this.VSTprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("VSTprintPreviewDialog.Icon")));
            this.VSTprintPreviewDialog.Name = "printPreviewDialog1";
            this.VSTprintPreviewDialog.Visible = false;
            this.VSTprintPreviewDialog.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // VSTprintDocument
            // 
            this.VSTprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.VSTprintDocument_PrintPage);
            // 
            // tcMain
            // 
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.Registration);
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.HotTrack = true;
            this.tcMain.Location = new System.Drawing.Point(7, 36);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1041, 612);
            this.tcMain.TabIndex = 7;
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
            this.Registration.Text = "Income";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ownerDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 563);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Income Details";
            // 
            // ownerDataGridView
            // 
            this.ownerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ownerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ownerDataGridView.Location = new System.Drawing.Point(13, 19);
            this.ownerDataGridView.Name = "ownerDataGridView";
            this.ownerDataGridView.Size = new System.Drawing.Size(974, 524);
            this.ownerDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Cost Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Cost Amount";
            this.Column3.Name = "Column3";
            // 
            // Home_Admin_Owner_Income_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1131, 648);
            this.Controls.Add(this.home_admin_createAccount_pnl);
            this.Controls.Add(this.right_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Admin_Owner_Income_Details";
            this.Text = "Print_Document";
            this.Load += new System.EventHandler(this.Print_Document_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Print_Document_MouseMove);
            this.home_admin_createAccount_pnl.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.right_pnl.ResumeLayout(false);
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit_pnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pnl)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel home_admin_createAccount_pnl;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel right_pnl;
        private System.Windows.Forms.Panel pnlRightMain;
        private System.Windows.Forms.PictureBox exit_pnl;
        private System.Windows.Forms.PictureBox lock_pnl;
        private System.Windows.Forms.PictureBox home_pnl;
        private System.Windows.Forms.Timer rightOptionPnlTimer;
        private System.Windows.Forms.PrintPreviewDialog VSTprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument VSTprintDocument;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ownerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}