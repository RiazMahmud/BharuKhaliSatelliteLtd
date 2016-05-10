using BO;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountWithdraw_Withdraw : Form
    {
        public Home_Admin_AccountWithdraw_Withdraw()
        {
            InitializeComponent();
           
        }
        Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
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

        private void logIn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        public int index1;
        public int index2;
        public void giveIndex(int i)
        {
            index1 = i;
        }
        public void giveYear(int i)
        {
            index2 = i;
        }
        private void Withdraw_Click(object sender, EventArgs e)
        {

        }

        private void Home_Admin_AccountWithdraw_Withdraw_Load(object sender, EventArgs e)
        {
            
           
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            ArrayList userBill = new ArrayList(account_BO.getUserBill());
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();
           
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
                firstDate_lbl.Text = userBill[b-3].ToString();
                lastDate_lbl.Text = presentDate.ToShortDateString();
                DateTime prevDate = DateTime.Parse(userBill[b - 3].ToString());
                TimeSpan defDate = presentDate.Subtract(prevDate);
                string defDays = defDate.Days.ToString();

                double temp1 = (Convert.ToDouble(defDays) / 30);
                int totalMonth = (int)temp1;
                totalMonth_lbl.Text = totalMonth.ToString();
                totalBill_lbl.Text = (totalMonth * 120 + dueBill).ToString();
               /* jan.Text = "DUE";
                feb.Text = "DUE";
                mar.Text = "DUE";
                apr.Text = "DUE";
                may.Text = "DUE";
                jun.Text = "DUE";
                jul.Text = "DUE";
                aug.Text = "DUE";
                sep.Text = "DUE";
                oct.Text = "DUE";
                nov.Text = "DUE";
                dec.Text = "DUE";

                if (index2 - index1 == 10)
                {
                    for (int i = index2 + 1; list[i].ToString() != "*****"; i++)
                    {
                        if (list[i].ToString() == "January" || list[i].ToString() == "February" || list[i].ToString() == "March" || list[i].ToString() == "April" || list[i].ToString() == "May" || list[i].ToString() == "June" || list[i].ToString() == "July" || list[i].ToString() == "August" || list[i].ToString() == "September" || list[i].ToString() == "October" || list[i].ToString() == "November" || list[i].ToString() == "December")
                        {
                            if (list[i].ToString() == "January")
                            {
                                jan.Text = "PAID";
                            }
                            else if (list[i].ToString() == "February")
                            {
                                feb.Text = "PAID";
                            }
                            else if (list[i].ToString() == "March")
                            {
                                mar.Text = "PAID";
                            }
                            else if (list[i].ToString() == "April")
                            {
                                apr.Text = "PAID";
                            }
                            else if (list[i].ToString() == "May")
                            {
                                may.Text = "PAID";
                            }
                            else if (list[i].ToString() == "June")
                            {
                                jun.Text = "PAID";
                            }
                            else if (list[i].ToString() == "July")
                            {
                                jul.Text = "PAID";
                            }
                            else if (list[i].ToString() == "August")
                            {
                                aug.Text = "PAID";
                            }
                            else if (list[i].ToString() == "September")
                            {
                                sep.Text = "PAID";
                            }
                            else if (list[i].ToString() == "October")
                            {
                                oct.Text = "PAID";
                            }
                            else if (list[i].ToString() == "November")
                            {
                                nov.Text = "PAID";
                            }
                            else if (list[i].ToString() == "December")
                            {
                                dec.Text = "PAID";
                            }
                        }
                        else
                        {
                            break;
                        }


                    }
                    if (list[index2 + 1].ToString() == "February")
                    {
                        jan.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "March")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "April")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "May")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "June")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                        may.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "July")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                        may.Text = "N/A";
                        jun.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "August")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                        may.Text = "N/A";
                        jun.Text = "N/A";
                        jul.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "September")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                        may.Text = "N/A";
                        jun.Text = "N/A";
                        jul.Text = "N/A";
                        aug.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "October")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                        may.Text = "N/A";
                        jun.Text = "N/A";
                        jul.Text = "N/A";
                        aug.Text = "N/A";
                        sep.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "November")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                        may.Text = "N/A";
                        jun.Text = "N/A";
                        jul.Text = "N/A";
                        aug.Text = "N/A";
                        sep.Text = "N/A";
                        oct.Text = "N/A";
                    }
                    else if (list[index2 + 1].ToString() == "December")
                    {
                        jan.Text = "N/A";
                        feb.Text = "N/A";
                        mar.Text = "N/A";
                        apr.Text = "N/A";
                        may.Text = "N/A";
                        jun.Text = "N/A";
                        jul.Text = "N/A";
                        aug.Text = "N/A";
                        sep.Text = "N/A";
                        oct.Text = "N/A";
                        nov.Text = "N/A";
                    }

                }
                else
                {
                    for (int i = index2 + 1; list[i].ToString() != "*****"; i++)
                    {
                        if (list[i].ToString() == "January" || list[i].ToString() == "February" || list[i].ToString() == "March" || list[i].ToString() == "April" || list[i].ToString() == "May" || list[i].ToString() == "June" || list[i].ToString() == "July" || list[i].ToString() == "August" || list[i].ToString() == "September" || list[i].ToString() == "October" || list[i].ToString() == "November" || list[i].ToString() == "December")
                        {
                            if (list[i].ToString() == "January")
                            {
                                jan.Text = "PAID";
                            }
                            else if (list[i].ToString() == "February")
                            {
                                feb.Text = "PAID";
                            }
                            else if (list[i].ToString() == "March")
                            {
                                mar.Text = "PAID";
                            }
                            else if (list[i].ToString() == "April")
                            {
                                apr.Text = "PAID";
                            }
                            else if (list[i].ToString() == "May")
                            {
                                may.Text = "PAID";
                            }
                            else if (list[i].ToString() == "June")
                            {
                                jun.Text = "PAID";
                            }
                            else if (list[i].ToString() == "July")
                            {
                                jul.Text = "PAID";
                            }
                            else if (list[i].ToString() == "August")
                            {
                                aug.Text = "PAID";
                            }
                            else if (list[i].ToString() == "September")
                            {
                                sep.Text = "PAID";
                            }
                            else if (list[i].ToString() == "October")
                            {
                                oct.Text = "PAID";
                            }
                            else if (list[i].ToString() == "November")
                            {
                                nov.Text = "PAID";
                            }
                            else if (list[i].ToString() == "December")
                            {
                                dec.Text = "PAID";
                            }
                        }
                        else
                        {
                            break;
                        }
                    }


                }*/

            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!");
            }
            }
           /* if (jan.Text == "DUE")
            {
                jan_pnl.BackColor = Color.Red;
            }
            if (jan.Text == "N/A")
            {
                jan_pnl.BackColor = Color.Yellow;
            }
            if (jan.Text == "PAID")
            {
                jan_pnl.BackColor = Color.Green;
            }
            if (feb.Text == "DUE")
            {
                feb_pnl.BackColor = Color.Red;
            }
            if (feb.Text == "N/A")
            {
                feb_pnl.BackColor = Color.Yellow;
            }
            if (feb.Text == "PAID")
            {
                feb_pnl.BackColor = Color.Green;
            }
            if (mar.Text == "DUE")
            {
                mar_pnl.BackColor = Color.Red;
            }
            if (mar.Text == "N/A")
            {
                mar_pnl.BackColor = Color.Yellow;
            }
            if (mar.Text == "PAID")
            {
                mar_pnl.BackColor = Color.Green;
            }
            if (apr.Text == "DUE")
            {
                apr_pnl.BackColor = Color.Red;
            }
            if (apr.Text == "N/A")
            {
                apr_pnl.BackColor = Color.Yellow;
            }
            if (apr.Text == "PAID")
            {
                apr_pnl.BackColor = Color.Green;
            }
            if (may.Text == "DUE")
            {
                may_pnl.BackColor = Color.Red;
            }
            if (may.Text == "N/A")
            {
                may_pnl.BackColor = Color.Yellow;
            }
            if (may.Text == "PAID")
            {
                may_pnl.BackColor = Color.Green;
            }
            if (jun.Text == "DUE")
            {
                jun_pnl.BackColor = Color.Red;
            }
            if (jun.Text == "N/A")
            {
                jun_pnl.BackColor = Color.Yellow;
            }
            if (jun.Text == "PAID")
            {
                jun_pnl.BackColor = Color.Green;
            }
            if (jul.Text == "DUE")
            {
                jul_pnl.BackColor = Color.Red;
            }
            if (jul.Text == "N/A")
            {
                jul_pnl.BackColor = Color.Yellow;
            }
            if (jul.Text == "PAID")
            {
                jul_pnl.BackColor = Color.Green;
            }
            if (aug.Text == "DUE")
            {
                aug_pnl.BackColor = Color.Red;
            }
            if (aug.Text == "N/A")
            {
                aug_pnl.BackColor = Color.Yellow;
            }
            if (aug.Text == "PAID")
            {
                aug_pnl.BackColor = Color.Green;
            }
            if (sep.Text == "DUE")
            {
                sep_pnl.BackColor = Color.Red;
            }
            if (sep.Text == "N/A")
            {
                sep_pnl.BackColor = Color.Yellow;
            }
            if (sep.Text == "PAID")
            {
                sep_pnl.BackColor = Color.Green;
            }
            if (oct.Text == "DUE")
            {
                oct_pnl.BackColor = Color.Red;
            }
            if (oct.Text == "N/A")
            {
                oct_pnl.BackColor = Color.Yellow;
            }
            if (oct.Text == "PAID")
            {
                oct_pnl.BackColor = Color.Green;
            }
            if (nov.Text == "DUE")
            {
                nov_pnl.BackColor = Color.Red;
            }
            if (nov.Text == "N/A")
            {
                nov_pnl.BackColor = Color.Yellow;
            }
            if (nov.Text == "PAID")
            {
                nov_pnl.BackColor = Color.Green;
            }
            if (dec.Text == "DUE")
            {
                dec_pnl.BackColor = Color.Red;
            }
            if (dec.Text == "N/A")
            {
                dec_pnl.BackColor = Color.Yellow;
            }
            if (dec.Text == "PAID")
            {
                dec_pnl.BackColor = Color.Green;
            }
        }
       */

        private void button9_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
        }

        private void WithdrawBalance_Click(object sender, EventArgs e)
        {
            
        }

        private void WithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        
       
        private void payFeb_Click(object sender, EventArgs e)
        {
           
            
           
               
        }

        private void payJan_Click(object sender, EventArgs e)
        {
            
            
        }

        private void payMar_Click(object sender, EventArgs e)
        {
            
         }

        private void payApr_Click(object sender, EventArgs e)
        {
            
        }

        private void payMay_Click(object sender, EventArgs e)
        {
              
         }

        private void payJune_Click(object sender, EventArgs e)
        {
            
         }

        private void payJuly_Click(object sender, EventArgs e)
        {

        }

        private void payAug_Click(object sender, EventArgs e)
        {

            
        }

        private void paySep_Click(object sender, EventArgs e)
        {
  
             
        }

        private void payOct_Click(object sender, EventArgs e)
        {

           
        }

        private void payNov_Click(object sender, EventArgs e)
        {

              
              
        }

        private void payDec_Click(object sender, EventArgs e)
        {

             
        }

        private void stNewYearBt_Click(object sender, EventArgs e)
        {
            
        }

        private void year_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        

        private void Home_Admin_AccountWithdraw_Withdraw_MouseMove(object sender, MouseEventArgs e)
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

       /* private void jan_pnl_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (jan.Text != "PAID" && jan.Text != "N/A")
                {

                    
                    h2.Show();
                    h2.giveData(index1, index2, 1);
                   // this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }*/

        /*private void jan_pnl_MouseHover(object sender, EventArgs e)
        {
            jan_pnl.BackColor = Color.Cyan;
        }

        private void feb_pnl_MouseHover(object sender, EventArgs e)
        {
            feb_pnl.BackColor = Color.Cyan;
        }

        private void mar_pnl_MouseHover(object sender, EventArgs e)
        {
            mar_pnl.BackColor = Color.Cyan;
        }

        private void apr_pnl_MouseHover(object sender, EventArgs e)
        {
            apr_pnl.BackColor = Color.Cyan;
        }

        private void may_pnl_MouseHover(object sender, EventArgs e)
        {
            may_pnl.BackColor = Color.Cyan;
        }

        private void jun_pnl_MouseHover(object sender, EventArgs e)
        {
            jun_pnl.BackColor = Color.Cyan;
        }

        private void jul_pnl_MouseHover(object sender, EventArgs e)
        {
            jul_pnl.BackColor = Color.Cyan;
        }

        private void aug_pnl_MouseHover(object sender, EventArgs e)
        {
            aug_pnl.BackColor = Color.Cyan;
        }

        private void sep_pnl_MouseHover(object sender, EventArgs e)
        {
            sep_pnl.BackColor = Color.Cyan;
        }

        private void oct_pnl_MouseHover(object sender, EventArgs e)
        {
            oct_pnl.BackColor = Color.Cyan;
        }

        private void nov_pnl_MouseHover(object sender, EventArgs e)
        {
            nov_pnl.BackColor = Color.Cyan;
        }

        private void dec_pnl_MouseHover(object sender, EventArgs e)
        {
            dec_pnl.BackColor = Color.Cyan;
        }

        private void jan_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (jan.Text == "DUE")
            {
                jan_pnl.BackColor = Color.Red;
            }
            else if (jan.Text == "N/A")
            {
                jan_pnl.BackColor = Color.Yellow;
            }
            else if (jan.Text == "PAID")
            {
                jan_pnl.BackColor = Color.Green;
            }
        }

        private void feb_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (feb.Text == "DUE")
            {
                feb_pnl.BackColor = Color.Red;
            }
            else if (feb.Text == "N/A")
            {
                feb_pnl.BackColor = Color.Yellow;
            }
            else if (feb.Text == "PAID")
            {
                feb_pnl.BackColor = Color.Green;
            }
          
        }

        private void mar_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (mar.Text == "DUE")
            {
                mar_pnl.BackColor = Color.Red;
            }
            else if (mar.Text == "N/A")
            {
                mar_pnl.BackColor = Color.Yellow;
            }
            else if (mar.Text == "PAID")
            {
                mar_pnl.BackColor = Color.Green;
            }

        }

        private void apr_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (apr.Text == "DUE")
            {
                apr_pnl.BackColor = Color.Red;
            }
            else if (apr.Text == "N/A")
            {
                apr_pnl.BackColor = Color.Yellow;
            }
            else if (apr.Text == "PAID")
            {
                apr_pnl.BackColor = Color.Green;
            }
          
        }

        private void may_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (may.Text == "DUE")
            {
                may_pnl.BackColor = Color.Red;
            }
            else if (may.Text == "N/A")
            {
                may_pnl.BackColor = Color.Yellow;
            }
            else if (may.Text == "PAID")
            {
                may_pnl.BackColor = Color.Green;
            }
            
        }

        private void jun_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (jun.Text == "DUE")
            {
                jun_pnl.BackColor = Color.Red;
            }
            else if (jun.Text == "N/A")
            {
                jun_pnl.BackColor = Color.Yellow;
            }
            else if (jun.Text == "PAID")
            {
                jun_pnl.BackColor = Color.Green;
            }
            
        }

        private void jul_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (jul.Text == "DUE")
            {
                jul_pnl.BackColor = Color.Red;
            }
            else if (jul.Text == "N/A")
            {
                jul_pnl.BackColor = Color.Yellow;
            }
            else if (jul.Text == "PAID")
            {
                jul_pnl.BackColor = Color.Green;
            }
            
          
          
          
        }

        private void aug_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (aug.Text == "DUE")
            {
                aug_pnl.BackColor = Color.Red;
            }
            else if (aug.Text == "N/A")
            {
                aug_pnl.BackColor = Color.Yellow;
            }
            else if (aug.Text == "PAID")
            {
                aug_pnl.BackColor = Color.Green;
            }
        }*/

        private void sep_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void sep_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (sep.Text == "DUE")
            {
                sep_pnl.BackColor = Color.Red;
            }
            else if (sep.Text == "N/A")
            {
                sep_pnl.BackColor = Color.Yellow;
            }
            else if (sep.Text == "PAID")
            {
                sep_pnl.BackColor = Color.Green;
            }
        }

        private void oct_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (oct.Text == "DUE")
            {
                oct_pnl.BackColor = Color.Red;
            }
            else if (oct.Text == "N/A")
            {
                oct_pnl.BackColor = Color.Yellow;
            }
            else if (oct.Text == "PAID")
            {
                oct_pnl.BackColor = Color.Green;
            }
        }

        private void nov_pnl_MouseLeave(object sender, EventArgs e)
        {
            if (nov.Text == "DUE")
            {
                nov_pnl.BackColor = Color.Red;
            }
            else if (nov.Text == "N/A")
            {
                nov_pnl.BackColor = Color.Yellow;
            }
            else if (nov.Text == "PAID")
            {
                nov_pnl.BackColor = Color.Green;
            }
        }

        private void dec_pnl_MouseLeave(object sender, EventArgs e)
        {

            if (dec.Text == "DUE")
            {
                dec_pnl.BackColor = Color.Red;
            }
            else if (dec.Text == "N/A")
            {
                dec_pnl.BackColor = Color.Yellow;
            }
            else if (dec.Text == "PAID")
            {
                dec_pnl.BackColor = Color.Green;
            }
        }

        private void feb_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();

            try
            {

                if (feb.Text != "PAID" && feb.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 2);
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            } 
        }

        private void mar_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();

            try
            {
                if (mar.Text != "PAID" && mar.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 3);
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void apr_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();

            try
            {
                if (apr.Text != "PAID" && apr.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 4);
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void may_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (may.Text != "PAID" && may.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 5);
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }   
        }

        private void jun_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (jun.Text != "PAID" && jun.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 6);
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void jul_pnl_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (jul.Text != "PAID" && jul.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 7);
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void aug_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (aug.Text != "PAID" && aug.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 8);
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }    
        }

        private void sep_pnl_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (sep.Text != "PAID" && sep.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 9);
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Paid");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }   
        }

        private void oct_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (oct.Text != "PAID" && oct.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 10);
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void nov_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (nov.Text != "PAID" && nov.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 11);
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }   
        }

        private void dec_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (dec.Text != "PAID" && dec.Text != "N/A")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 12);
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }    
        }
        */
       /* private void stNewYearBt_Click_1(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_New h = new Home_Admin_Withdraw_New();
            h.giveData(index1, index2, serYear.Text);
            this.Hide();
            h.Show();
        }*/

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lastDate_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Home_Admin hm = new Home_Admin();
            this.Hide();
            hm.Show();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList();
            ArrayList userBill = new ArrayList(account_BO.getUserBill());
            DateTime dt = DateTime.Now;


           

                try
                {

                    if (enterAmount_tb.Text != null)
                    {

                        int paymentBill = Convert.ToInt32(enterAmount_tb.Text);

                        if (paymentBill % 120 == 0)
                        {

                            int m = 0;

                            while (userBill[m].ToString() != userID.Text)
                            {
                                m++;
                            }
                            int b;
                            for (b = m; userBill[b].ToString() != "*"; b++)
                            {

                            }

                            int totalBill = Convert.ToInt32(totalBill_lbl.Text);

                            if (paymentBill <= totalBill)
                            {
                                for (int j = 0; j < b; j++)
                                {
                                    list.Add(userBill[j].ToString());
                                }
                                list.Add(dt.ToShortDateString());
                                list.Add(enterAmount_tb.Text);
                                list.Add((totalBill - paymentBill).ToString());
                                for (int k = b; k < userBill.Count; k++)
                                {
                                    list.Add(userBill[k].ToString());
                                }
                                account_BO.setUserBill(list);


                                try
                                {
                                    ArrayList cost = new ArrayList();
                                    ArrayList temp = new ArrayList();
                                    cost = account_BO.getOwnerincome();
                                    int f = 0;
                                    for (int i = 0; i < cost.Count; i++)
                                    {
                                        temp.Add(cost[i].ToString());

                                        if (cost[i].ToString() == lastDate_lbl.Text)
                                        {

                                            temp.Add("Bill");
                                            temp.Add(enterAmount_tb.Text);
                                            for (int m1 = i + 1; m1 < cost.Count; m1++)
                                            {
                                                temp.Add(cost[m1].ToString());
                                            }
                                            account_BO.setOwerIncome(temp);
                                            f = 1;
                                        }

                                    }
                                    if (f == 0)
                                    {

                                        cost.Add(lastDate_lbl.Text);
                                        cost.Add("Bill");
                                        cost.Add(enterAmount_tb.Text);
                                        cost.Add("*");
                                        account_BO.setOwerIncome(cost);


                                    }
                                }
                                catch
                                {

                                }


                                Home_Admin_Withdraw_Show hs = new Home_Admin_Withdraw_Show();
                                hs.giveIndex(index1);
                                this.Hide();
                                hs.Show();
                            }
                            else
                            {
                                MessageBox.Show("You can not entry any amount more than the due bill");
                                enterAmount_tb.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter the amount in correct format");
                            enterAmount_tb.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter amount");
                    }

                }
                catch
                {
                    MessageBox.Show("Please enter amount");
                }


            }
        

        private void printBill_btn_Click(object sender, EventArgs e)
        {
            VSTprintDocument.Print();
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            VSTprintPreviewDialog.Document = VSTprintDocument;
            VSTprintPreviewDialog.ShowDialog();
        }

        private void VSTprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Untitled_1;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 100, 10, newImage.Width, newImage.Height);

            e.Graphics.DrawString(userID.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(230, 270));
            e.Graphics.DrawString(userName.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(230, 286));
            e.Graphics.DrawString(dateOfBirth.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(230, 302));
            e.Graphics.DrawString(occupation.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(230, 318));
            e.Graphics.DrawString(stYear.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(230, 336));

            e.Graphics.DrawString(mob.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(280, 428));
            e.Graphics.DrawString(lan.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(280, 446));
            e.Graphics.DrawString(address.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(280, 464));

            e.Graphics.DrawString(firstDate_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(260, 553));
            e.Graphics.DrawString(lastDate_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(440, 553));
            e.Graphics.DrawString(totalMonth_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(350, 573));
            e.Graphics.DrawString(totalBill_lbl.Text + " TK", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(247, 590));

            e.Graphics.DrawString(firstDate_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(260, 787));
            e.Graphics.DrawString(lastDate_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(440, 787));
            e.Graphics.DrawString(totalMonth_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(350, 807));
            e.Graphics.DrawString(totalBill_lbl.Text + " TK", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(247, 824));

            e.Graphics.DrawString(lastDate_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(235, 642));
            e.Graphics.DrawString(lastDate_lbl.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(235, 922));

            e.Graphics.DrawString(userName.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(225, 722));
            e.Graphics.DrawString(userID.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(590, 722));

            e.Graphics.DrawString("Paid Amount ______________", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(114, 872));

        }

        private void VSTprintPreviewDialog_Load(object sender, EventArgs e)
        {

        }
               
       }
           
  }


