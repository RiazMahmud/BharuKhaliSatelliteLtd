namespace BankAccountSystemUI
{
    partial class Home_Admin_AccountRemove
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
            this.searchRemoveAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GoRemoveAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeCrossPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchRemoveAccount
            // 
            this.searchRemoveAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchRemoveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRemoveAccount.Location = new System.Drawing.Point(348, 94);
            this.searchRemoveAccount.Name = "searchRemoveAccount";
            this.searchRemoveAccount.Size = new System.Drawing.Size(147, 26);
            this.searchRemoveAccount.TabIndex = 0;
            this.searchRemoveAccount.TextChanged += new System.EventHandler(this.searchRemoveAccount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Enter Account NO";
            // 
            // GoRemoveAccount
            // 
            this.GoRemoveAccount.BackColor = System.Drawing.Color.Transparent;
            this.GoRemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoRemoveAccount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoRemoveAccount.ForeColor = System.Drawing.Color.White;
            this.GoRemoveAccount.Location = new System.Drawing.Point(348, 126);
            this.GoRemoveAccount.Name = "GoRemoveAccount";
            this.GoRemoveAccount.Size = new System.Drawing.Size(147, 30);
            this.GoRemoveAccount.TabIndex = 1;
            this.GoRemoveAccount.Text = "Ok";
            this.GoRemoveAccount.UseVisualStyleBackColor = false;
            this.GoRemoveAccount.Click += new System.EventHandler(this.GoRemoveAccount_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeCrossPanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.searchRemoveAccount);
            this.panel1.Controls.Add(this.GoRemoveAccount);
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
            // Home_Admin_AccountRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Admin_AccountRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Admin_AccountRemove";
            this.Load += new System.EventHandler(this.Home_Admin_AccountRemove_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchRemoveAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoRemoveAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel homeCrossPanel;
    }
}