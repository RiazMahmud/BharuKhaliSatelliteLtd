namespace BankAccountSystemUI
{
    partial class Home_Admin_AccountStatement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeCrossPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.GoWithdrawAccount = new System.Windows.Forms.Button();
            this.searchUserID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeCrossPanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GoWithdrawAccount);
            this.panel1.Controls.Add(this.searchUserID);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 250);
            this.panel1.TabIndex = 145;
            // 
            // homeCrossPanel
            // 
            this.homeCrossPanel.BackColor = System.Drawing.Color.Black;
            this.homeCrossPanel.BackgroundImage = global::BankAccountSystemUI.Properties.Resources.delete_button1;
            this.homeCrossPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeCrossPanel.Location = new System.Drawing.Point(595, 0);
            this.homeCrossPanel.Name = "homeCrossPanel";
            this.homeCrossPanel.Size = new System.Drawing.Size(35, 35);
            this.homeCrossPanel.TabIndex = 143;
            this.homeCrossPanel.Click += new System.EventHandler(this.homeCrossPanel_Click);
            this.homeCrossPanel.MouseLeave += new System.EventHandler(this.homeCrossPanel_MouseLeave);
            this.homeCrossPanel.MouseHover += new System.EventHandler(this.homeCrossPanel_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 117;
            this.label3.Text = "Enter User ID";
            // 
            // GoWithdrawAccount
            // 
            this.GoWithdrawAccount.BackColor = System.Drawing.Color.Transparent;
            this.GoWithdrawAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoWithdrawAccount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoWithdrawAccount.ForeColor = System.Drawing.Color.White;
            this.GoWithdrawAccount.Location = new System.Drawing.Point(326, 128);
            this.GoWithdrawAccount.Name = "GoWithdrawAccount";
            this.GoWithdrawAccount.Size = new System.Drawing.Size(147, 27);
            this.GoWithdrawAccount.TabIndex = 1;
            this.GoWithdrawAccount.Text = "Ok";
            this.GoWithdrawAccount.UseVisualStyleBackColor = false;
            this.GoWithdrawAccount.Click += new System.EventHandler(this.GoWithdrawAccount_Click);
            // 
            // searchUserID
            // 
            this.searchUserID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUserID.Location = new System.Drawing.Point(326, 96);
            this.searchUserID.Name = "searchUserID";
            this.searchUserID.Size = new System.Drawing.Size(147, 26);
            this.searchUserID.TabIndex = 0;
            // 
            // Home_Admin_AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Admin_AccountStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Admin_AccountStatement";
            this.Load += new System.EventHandler(this.Home_Admin_AccountStatement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel homeCrossPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoWithdrawAccount;
        private System.Windows.Forms.TextBox searchUserID;

    }
}