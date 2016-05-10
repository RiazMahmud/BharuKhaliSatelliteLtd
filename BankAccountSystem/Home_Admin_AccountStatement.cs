using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ENTITY;
using BO;
using System.Collections;
using System.IO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountStatement : Form
    {


        public int index;
        public Home_Admin_AccountStatement()
        {
            InitializeComponent();

        }

        private void logIn_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void ShowAccountStatement_Click(object sender, EventArgs e)
        {

        }
        private void AccountStatementSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Admin_AccountStatement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void homeCrossPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void GoWithdrawAccount_Click(object sender, EventArgs e)
        {
            Account_BO accountBO = new Account_BO();
            ArrayList list = new ArrayList(accountBO.readAccount());
            ArrayList userBill = new ArrayList(accountBO.getUserBill());
            if (searchUserID.Text == "")
            {
                MessageBox.Show("Wrong!!! Enter the information fully");
            }
            else
            {
                try
                {
                    int flag = 0;
                    int i;
                    for (i = 0; i < list.Count; i++)
                    {

                        if (list[i].ToString() == searchUserID.Text)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Sorry!!! This account number isn't Exist");
                        searchUserID.Clear();
                    }

                   
                    if (flag == 1)
                    {
                        int m = 0;

                        while (userBill[m].ToString() != searchUserID.Text)
                        {
                            m++;
                        }
                        int b;
                        for (b = m; userBill[b].ToString() != "*"; b++)
                        {

                        }
                        Home_Admin_AccountStatement_Show home_Admin_AccountRemove_Remove = new Home_Admin_AccountStatement_Show();
                        home_Admin_AccountRemove_Remove.giveIndex(list.IndexOf(list[i].ToString()));
                        home_Admin_AccountRemove_Remove.giveUserBillIndex(m,b);
                        home_Admin_AccountRemove_Remove.Show();
                        this.Hide();
                    }
                    

                }
                catch (Exception)
                {
                    MessageBox.Show("No User Exists");
                }
            }
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
