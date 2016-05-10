namespace BankAccountSystemUI
{
    partial class Home_Admin_AccountUpdate
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
            this.accountUpdateSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GoUpdateAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeCrossPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountUpdateSearch
            // 
            this.accountUpdateSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountUpdateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountUpdateSearch.Location = new System.Drawing.Point(326, 95);
            this.accountUpdateSearch.Name = "accountUpdateSearch";
            this.accountUpdateSearch.Size = new System.Drawing.Size(147, 26);
            this.accountUpdateSearch.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Enter User ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GoUpdateAccount
            // 
            this.GoUpdateAccount.BackColor = System.Drawing.Color.Transparent;
            this.GoUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoUpdateAccount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.GoUpdateAccount.Location = new System.Drawing.Point(326, 127);
            this.GoUpdateAccount.Name = "GoUpdateAccount";
            this.GoUpdateAccount.Size = new System.Drawing.Size(147, 30);
            this.GoUpdateAccount.TabIndex = 1;
            this.GoUpdateAccount.Text = "Ok";
            this.GoUpdateAccount.UseVisualStyleBackColor = false;
            this.GoUpdateAccount.Click += new System.EventHandler(this.GoUpdateAccount_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeCrossPanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.accountUpdateSearch);
            this.panel1.Controls.Add(this.GoUpdateAccount);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 250);
            this.panel1.TabIndex = 105;
            // 
            // homeCrossPanel
            // 
            this.homeCrossPanel.BackColor = System.Drawing.Color.Black;
            this.homeCrossPanel.BackgroundImage = global::BankAccountSystemUI.Properties.Resources.delete_button1;
            this.homeCrossPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeCrossPanel.Location = new System.Drawing.Point(595, 0);
            this.homeCrossPanel.Name = "homeCrossPanel";
            this.homeCrossPanel.Size = new System.Drawing.Size(35, 35);
            this.homeCrossPanel.TabIndex = 144;
            this.homeCrossPanel.Click += new System.EventHandler(this.homeCrossPanel_Click);
            this.homeCrossPanel.MouseLeave += new System.EventHandler(this.homeCrossPanel_MouseLeave);
            this.homeCrossPanel.MouseHover += new System.EventHandler(this.homeCrossPanel_MouseHover);
            // 
            // Home_Admin_AccountUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Admin_AccountUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Admin_AccountUpdate";
            this.Load += new System.EventHandler(this.Home_Admin_AccountUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox accountUpdateSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoUpdateAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel homeCrossPanel;
    }
}