using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using BO;
using System.Collections;
using System.IO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_CreateAccount : Form
    {
       

        public Home_Admin_CreateAccount()
        {
            InitializeComponent();
            
        }
        private void setFullScreen()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(x, y);
        }
        private void setMainPanelPosition()
        {
            int mX = (Width - home_admin_createAccount_pnl.Width) / 2;
            int mY = (Height - home_admin_createAccount_pnl.Height) / 2;
            home_admin_createAccount_pnl.Location = new Point(mX, mY);
        }
        int rightX;
        int rightY;
        private void setRightOptionPanel()
        {
            int y = Height;
            rightY = 0;
            rightX = Width + right_pnl.Width;
            right_pnl.Size = new Size(right_pnl.Width, y);
            right_pnl.Location = new Point(rightX, rightY);
            int rX = pnlRightMain.Location.X;
            int rY = (right_pnl.Height - pnlRightMain.Height) / 2;
            pnlRightMain.Location = new Point(rX, rY);
        }
        private void Home_Admin_CreateAccount_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();
        }
        public string imagePath;

        Account_BO account_Bo = new Account_BO();
      

        private void Create_Click(object sender, EventArgs e)
        {
            
        }

       
        private void Upload_Picture_Click(object sender, EventArgs e)
        {
           
        }
        string rightDirection = "right";

        int RightTimeOut = 0;

        private void rightOptionPnlTimer_Tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 1000)
            {
                RightTimeOut++;
            }
            if (RightTimeOut == 1000)
            {
                if (rightDirection == "left")
                {
                    rightDirection = "right";
                }
            }
            if (rightDirection == "left")
            {
                if (rightX > Width - right_pnl.Width)
                {
                    rightX -= 3;
                    right_pnl.Location = new Point(rightX, rightY);
                }
            }
            else
            {
                if (rightX < Width)
                {
                    rightX += 3;
                }
                right_pnl.Location = new Point(rightX, rightY);
            }
        }

        private void Home_Admin_CreateAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y >= Height - 15 && e.X < (Width - right_pnl.Width))
            {

                rightDirection = "right";

            }
            if (e.X >= Width - 15)
            {
                rightDirection = "left";
                RightTimeOut = 0;

            }
            if (e.X < (Width - right_pnl.Width))
            {
                rightDirection = "Left";
            }
        }

        private void home_pnl_MouseHover(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Red;
        }

        private void home_pnl_MouseLeave(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Black;
        }

        private void lock_pnl_MouseHover(object sender, EventArgs e)
        {
            lock_pnl.BackColor = Color.Red;
        }

        private void lock_pnl_MouseLeave(object sender, EventArgs e)
        {
            lock_pnl.BackColor = Color.Black;
        }

        private void exit_pnl_MouseHover(object sender, EventArgs e)
        {
            exit_pnl.BackColor = Color.Red;
        }

        private void exit_pnl_MouseLeave(object sender, EventArgs e)
        {
            exit_pnl.BackColor = Color.Black;
        }

        private void home_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin hm = new Home_Admin();
            this.Hide();
            hm.Show();
        }

        private void lock_pnl_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void exit_pnl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbStudentDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            userID.Text ="BST" + account_Bo.generateID();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.Title = "Select Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
                imagePath = pictureBox.ImageLocation;
            }
        }

        private void Create_Click_1(object sender, EventArgs e)
        {
            Account_BO account_Bo = new Account_BO();
            Account_ENTITY account_Entity = new Account_ENTITY();
            ArrayList bill = new ArrayList(account_Bo.getUserBill());
            ArrayList listAccount = new ArrayList(account_Bo.readAccount());
            try
            {
                if (userName.Text != "" &&entryDate_dtp.Text != null && ocupation_TextBox.Text != null && userID.Text != "" && genderCombo.Text != null && address.Text != "" && phoneNo.Text != "" && landline.Text != null && emailID.Text != null && this.dateOfBirth.Text != null && regFee != null && imagePath != null)
                {
                    if (Convert.ToDouble(regFee.Text) == 120)
                    {

                        int flag = 0;
                        for (int i = 0; i < listAccount.Count; i++)
                        {

                            if (listAccount[i].ToString() == userID.Text)
                            {
                                MessageBox.Show("Wrong!!! This User ID is already in used");
                                flag = 1;
                                break;
                            }
                        }
                        account_Entity.identity = "*****";
                        account_Entity.userID = userID.Text;
                        account_Entity.userName = userName.Text;
                        account_Entity.address = address.Text;
                        account_Entity.gender = genderCombo.Text;
                        account_Entity.dateOfBirth = dateOfBirth.Text;
                        account_Entity.occupation = ocupation_TextBox.Text;
                        account_Entity.regFee = Convert.ToInt32(regFee.Text);
                        account_Entity.phoneNo = phoneNo.Text;
                        account_Entity.landlineNo = landline.Text;
                        account_Entity.emailID = emailID.Text;
                        account_Entity.imagePath = imagePath;
                        account_Entity.entryDate = entryDate_dtp.Text;




                        if (flag == 0)
                        {
                           
                            listAccount.Add(account_Entity.userID);
                            listAccount.Add(account_Entity.userName);
                            listAccount.Add(account_Entity.address);
                            listAccount.Add(account_Entity.gender);
                            listAccount.Add(account_Entity.dateOfBirth);
                            listAccount.Add(account_Entity.occupation);
                            listAccount.Add(account_Entity.regFee);
                            listAccount.Add(account_Entity.phoneNo);
                            listAccount.Add(account_Entity.landlineNo);
                            listAccount.Add(account_Entity.emailID);
                            listAccount.Add(account_Entity.entryDate);
                            listAccount.Add(imagePath);
                            listAccount.Add(account_Entity.identity);

                            account_Bo.createAccount(listAccount);
                          
                            account_Bo.increaseTotalUser();

                            bill.Add(account_Entity.userID);
                            bill.Add(account_Entity.entryDate);
                            bill.Add(account_Entity.regFee);
                            bill.Add("0");
                            bill.Add("*");
                            account_Bo.setUserBill(bill);


                            try
                            {
                                Account_BO account_BO = new Account_BO();
                                ArrayList cost = new ArrayList();
                                ArrayList temp = new ArrayList();
                                cost = account_BO.getOwnerincome();
                                int f = 0;
                                for (int i = 0; i < cost.Count; i++)
                                {
                                    temp.Add(cost[i].ToString());

                                    if (cost[i].ToString() == entryDate_dtp.Text)
                                    {

                                        temp.Add("Bill");
                                        temp.Add(regFee.Text);
                                        for (int m = i + 1; m < cost.Count; m++)
                                        {
                                            temp.Add(cost[m].ToString());
                                        }
                                        account_BO.setOwerIncome(temp);
                                        f = 1;
                                    }

                                }
                                if (f == 0)
                                {

                                    cost.Add(entryDate_dtp.Text);
                                    cost.Add("Bill");
                                    cost.Add(regFee.Text);
                                    cost.Add("*");
                                    account_BO.setOwerIncome(cost);


                                }
                            }
                            catch
                            {

                            }

                            MessageBox.Show("The Account create successful");
                            account_Bo.setID_Generator();
                            Home_Admin ha = new Home_Admin();
                            this.Hide();
                            ha.Show();
                           
                           
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong!! You have to must deposit at least 120TK");
                        regFee.Clear();
                    }
                }
                else
                    MessageBox.Show("Wrong!!! Enter the information fully");


            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userName.Clear();
            address.Clear();
            genderCombo.ResetText();
            dateOfBirth.ResetText();
            ocupation_TextBox.Clear();
            regFee.Clear();
            phoneNo.Clear();
            landline.Clear();
            emailID.Clear();
            entryDate_dtp.ResetText();
            pictureBox.ImageLocation = "";
            
        }

       
    }
}
