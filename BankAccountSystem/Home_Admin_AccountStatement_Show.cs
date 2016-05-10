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
using System.IO;
namespace BankAccountSystemUI
{
   
    public partial class Home_Admin_AccountStatement_Show : Form
    {
        public int index;
        public Home_Admin_AccountStatement_Show()
        {
            InitializeComponent();
            
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
        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Exit_Click(object sender, EventArgs e)
        {
           
        }
        int index1;
        int f, l;
        public void giveIndex(int i)
        {
            index1 = i;
        }
        public void giveUserBillIndex(int i, int j)
        {
            f = i;
            l = j;
            Console.WriteLine(f);
            Console.WriteLine(l);

        }
       
        public void Home_Admin_AccountStatement_Show_Load(object sender, EventArgs e)
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

                userDataGridView.Rows.Clear();
                for (int i = f +1; i < l; i = i+3)
                {
                    userDataGridView.Rows.Add(userBill[i].ToString(), userBill[i + 1].ToString(), userBill[i + 2].ToString());
                }
                /*jan.Text = "DUE";
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


                }
                
               
               /* if (index2 - index1 == 5)
                {
                    if (list[index2 + 1].ToString() == "February")
                    {
                        dt.Rows.Add("PAID");
                    }

                    else if (list[index2 + 1].ToString() == "February")
                    {
                        dt.Rows.Add("NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "March")
                    {
                        dt.Rows.Add("NILL", "NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "April")
                    {
                        dt.Rows.Add("NILL", "NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "May")
                    {
                        dt.Rows.Add("NILL", "NILL","NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "June")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "July")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "August")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL","NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "September")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "October")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "November")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "December")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL","NILL", "PAID");
                    }
                }
                /*for (int i = index2 + 1; list[i].ToString() != "*****"; i++)
                {
                    if (list[i].ToString() == "January" || list[i].ToString() == "February" || list[i].ToString() == "March" || list[i].ToString() == "April" || list[i].ToString() == "May" || list[i].ToString() == "June" || list[i].ToString() == "July" || list[i].ToString() == "August" || list[i].ToString() == "September" || list[i].ToString() == "October" || list[i].ToString() == "November" || list[i].ToString() == "December")
                    {
                        if (list[i].ToString() == "January")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "February")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "March")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "April")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "May")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "June")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "July")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "August")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "September")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "October")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "November")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "December")
                        {
                            lt.SubItems.Add("PAID");
                        }
                    }
                    else
                    {
                        break;
                    }
                

                }*/
               

            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!");
            }
            
        }
        private void ShowAccountNo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void signBox_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void gbStudentDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

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

        private void Home_Admin_AccountStatement_Show_MouseMove(object sender, MouseEventArgs e)
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

        private void apr_Click(object sender, EventArgs e)
        {

        }

        private void jun_Click(object sender, EventArgs e)
        {

        }

        private void dec_Click(object sender, EventArgs e)
        {

        }

        private void oct_Click(object sender, EventArgs e)
        {

        }
    }
}
