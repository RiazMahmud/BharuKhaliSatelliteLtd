using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;

namespace BankAccountSystemUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Wrong!!! Enter the information fully");
            }
            else
            {
                if (account_BO.security_Checker(userName.Text, password.Text))
                {
                    
                    Home_Admin home_Admin = new Home_Admin();
                    home_Admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                    userName.Clear();
                    password.Clear();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            homeCrossPanel.BackColor = Color.Red;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {

        }

        private void homeCrossPanel_MouseLeave(object sender, EventArgs e)
        {
            homeCrossPanel.BackColor = Color.Black;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
