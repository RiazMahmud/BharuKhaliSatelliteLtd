namespace BankAccountSystemUI
{
    partial class Home
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.logIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.homeCrossPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "  User Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "  Password :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(223, 67);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(169, 26);
            this.userName.TabIndex = 0;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(223, 106);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(169, 26);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.Transparent;
            this.logIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.ForeColor = System.Drawing.Color.White;
            this.logIn.Location = new System.Drawing.Point(170, 149);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(130, 26);
            this.logIn.TabIndex = 2;
            this.logIn.Text = "Log in";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = " WELCOME TO BHARUKHALI SATELLITE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 79);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BankAccountSystemUI.Properties.Resources.received_10203436732319562;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(694, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 79);
            this.panel2.TabIndex = 1;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.ForeColor = System.Drawing.Color.White;
            this.time_lbl.Location = new System.Drawing.Point(9, 511);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(0, 19);
            this.time_lbl.TabIndex = 69;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.homeCrossPanel);
            this.panel4.Controls.Add(this.time_lbl);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(-1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 540);
            this.panel4.TabIndex = 71;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseHover += new System.EventHandler(this.panel4_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label6.Location = new System.Drawing.Point(303, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 15);
            this.label6.TabIndex = 71;
            this.label6.Text = "All rights reserved by Riaz Mahmud";
            // 
            // homeCrossPanel
            // 
            this.homeCrossPanel.BackColor = System.Drawing.Color.Black;
            this.homeCrossPanel.BackgroundImage = global::BankAccountSystemUI.Properties.Resources.delete_button1;
            this.homeCrossPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeCrossPanel.Location = new System.Drawing.Point(771, 0);
            this.homeCrossPanel.Name = "homeCrossPanel";
            this.homeCrossPanel.Size = new System.Drawing.Size(34, 29);
            this.homeCrossPanel.TabIndex = 70;
            this.homeCrossPanel.Click += new System.EventHandler(this.panel3_Click);
            this.homeCrossPanel.MouseLeave += new System.EventHandler(this.homeCrossPanel_MouseLeave);
            this.homeCrossPanel.MouseHover += new System.EventHandler(this.panel3_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.logIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(167, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 238);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Panel";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel homeCrossPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;


    }
}

