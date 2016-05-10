using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using BO;

namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountUpdate : Form
    {
        public Home_Admin_AccountUpdate()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_CreateAccount home_Admin_Create = new Home_Admin_CreateAccount();
            home_Admin_Create.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement home_Admin_Accountstatement = new Home_Admin_AccountStatement();
            home_Admin_Accountstatement.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate home_Admin_AccountUpdate = new Home_Admin_AccountUpdate();
            home_Admin_AccountUpdate.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountRemove home_Admin_AccountRemove = new Home_Admin_AccountRemove();
            home_Admin_AccountRemove.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountWithdraw home_Admin_AccountWithdraw = new Home_Admin_AccountWithdraw();
            home_Admin_AccountWithdraw.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void GoUpdateAccount_Click(object sender, EventArgs e)
        {
            Account_BO accountBO = new Account_BO();
            ArrayList list = new ArrayList(accountBO.readAccount());
            if (accountUpdateSearch.Text == "")
            {
                MessageBox.Show("Wrong!!! Enter the information fully");
            }
            else
            {
                try
                {
                    int flag = 0;
                    for (int i = 0; i < list.Count; i++)
                    {

                        if (list[i].ToString() == accountUpdateSearch.Text)
                        {
                            Home_Admin_AccountUpdate_Update home_Admin_AccountUpdate_Update = new Home_Admin_AccountUpdate_Update();
                            home_Admin_AccountUpdate_Update.giveIndex(list.IndexOf(list[i].ToString()));
                            home_Admin_AccountUpdate_Update.Show();
                            this.Hide();

                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Sorry!!! This account number isn't Exist");
                        accountUpdateSearch.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No User Exists");
                }
            }
        }

        private void Home_Admin_AccountUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeCrossPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void homeCrossPanel_MouseHover(object sender, EventArgs e)
        {
            homeCrossPanel.BackColor = Color.Red;
        }

        private void homeCrossPanel_MouseLeave(object sender, EventArgs e)
        {
            homeCrossPanel.BackColor = Color.Black;
        }
    }
}
