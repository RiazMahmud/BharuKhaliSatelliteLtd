using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_Withdraw_Show : Form
    {
        public Home_Admin_Withdraw_Show()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        string rightDirection = "right";

        int RightTimeOut = 0;
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
       



       /* int index1 = 0;
        int index2 = 0;
        int m = 0;
        public void giveData(int i, int j,int k)
        {
            index1 = i;
            index2 = j;
            m = k;
        }
        
        private void yes_Click(object sender, EventArgs e)
        {
            Home_Admin_AccountWithdraw_Withdraw home_admin = new Home_Admin_AccountWithdraw_Withdraw();
           
            int j = index2 + 2;
            int j1 = index2 + 1;
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            ArrayList lastList = new ArrayList();
            ArrayList saveList = new ArrayList();
            if (account_BO.security_Checker("r", password.Text))
            {
                if (index2 - index1 == 10)
                {
                    if (index1 != 0)
                    {
                        for (int i = 0; i < index1; i++)
                        {
                            saveList.Add(list[i]);
                        }

                        for (int i = index1; i <= index2 + 1; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }
                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);

                        

                        MessageBox.Show("Payment Successfully Done");
                        home_admin.giveIndex(index1);
                        home_admin.giveYear(index2);
                      
                        home_admin.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        for (int i = index1; i <= index2 + 1; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }

                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);
                        MessageBox.Show("Payment Successfully Done");
                        home_admin.giveIndex(index1);
                        home_admin.giveYear(index2);
                        
                        home_admin.Show();
                        this.Hide();
                        

                    }
                }
                else
                {
                    if (index1 != 0)
                    {
                        for (int i = 0; i < index1; i++)
                        {
                            saveList.Add(list[i]);
                        }

                        for (int i = index1; i <= index2; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j1; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }
                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);
                        MessageBox.Show("Payment Successfully Done");
                        home_admin.giveIndex(index1);
                        home_admin.giveYear(index2);
                        
                        home_admin.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        for (int i = index1; i <= index2; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j1; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }

                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);
                        MessageBox.Show("Payment Successfully Done");
                        home_admin.giveIndex(index1);
                        home_admin.giveYear(index2);
                        
                        home_admin.Show();
                        this.Hide();
                       

                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong Password !");
                password.Clear();
            }
                
        }
        
        private void No_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Cancell");
            
            this.Hide();

        }*/
        public int index1;
       
        public void giveIndex(int i)
        {
            index1 = i;
        }
     

        private void Home_Admin_Withdraw_Show_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();

            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            ArrayList userBill = new ArrayList(account_BO.getUserBill());
            

            try
            {
                int j;
                for (j = index1; list[j].ToString() != "*****"; j++)
                {

                }
                string k = list[j - 1].ToString();
                int index = index1;
                int temp = index1;
                userID.Text = list[index].ToString();
                userName.Text = list[index + 1].ToString();
                address.Text = list[index + 2].ToString();
                gender.Text = list[index + 3].ToString();
                dateOfBirth.Text = list[index + 4].ToString();
                occupation.Text = list[index + 5].ToString();
                mob.Text = list[index + 7].ToString();
                lan.Text = list[index + 8].ToString();
                email.Text = list[index + 9].ToString();
                stYear.Text = list[index + 10].ToString();
                pictureBox.Load(k);
                //serYear.Text = list[index2].ToString();


                //billing

                int m = 0;

                while (userBill[m].ToString() != list[index].ToString())
                {
                    m++;
                }
                int b;
                for (b = m; userBill[b].ToString() != "*"; b++)
                {

                }
                DateTime presentDate = DateTime.Now;

                lastPaidDate_lbl.Text = userBill[b - 3].ToString();
                lastPaidAmount_lbl.Text = userBill[b - 2].ToString() + " TK";
                previousDue_lbl.Text = userBill[b - 1].ToString() + " TK";
                int dueBill = Convert.ToInt32(userBill[b - 1].ToString());
                firstDate_lbl.Text = userBill[b - 3].ToString();
                lastDate_lbl.Text = presentDate.ToShortDateString();
                DateTime prevDate = DateTime.Parse(userBill[b - 3].ToString());
                TimeSpan defDate = presentDate.Subtract(prevDate);
                string defDays = defDate.Days.ToString();

                double temp1 = (Convert.ToDouble(defDays) / 30);
                int totalMonth = (int)temp1;
                totalMonth_lbl.Text = totalMonth.ToString();
                totalBill_lbl.Text = (totalMonth * 120 + dueBill).ToString() + " TK";
            }
            catch
            {

            }
        }
    
        private void Home_Admin_Withdraw_Show_MouseMove(object sender, MouseEventArgs e)
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
        }

    }

