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
    public partial class Home_Admin_AccountUpdate_Update : Form
    {
        public Home_Admin_AccountUpdate_Update()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        public int index1;
        public void giveIndex(int i)
        {
            index1 = i;
        }
        private void Update_Click(object sender, EventArgs e)
        {
           
            
        }
   
        private void Home_Admin_AccountUpdate_Update_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());

            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();

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
            stDate.Text = list[index + 10].ToString();
            pictureBox.Load(k);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate h = new Home_Admin_AccountUpdate();
            h.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateUserID_Click(object sender, EventArgs e)
        {

        }
       
        private void updateUpload_Picture_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void presentPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public string imagePath;
        private void Upload_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.Title = "Select Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                update_pictureBox.ImageLocation = openFileDialog.FileName;
                imagePath = update_pictureBox.ImageLocation;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Home_Admin_AccountUpdate_Update_MouseMove(object sender, MouseEventArgs e)
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

        private void update_Create_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());

            try
            {
                int temp = index1;
                if (update_userName_txt.Text != "" && update_Ocupation_TextBox.Text != null && update_Gender_com.Text != null && update_address.Text != null && update_phoneNo.Text != "" && update_Landline.Text != null && update_EmailID.Text != null && imagePath != null && update_dop_dtp.Text != null)
                {
                    list[temp + 1] = update_userName_txt.Text;
                    list[temp + 2] = update_address.Text;
                    list[temp + 3] = update_Gender_com.Text;
                    list[temp + 4] = update_dop_dtp.Text;
                    list[temp + 5] = update_Ocupation_TextBox.Text;
                    list[temp + 7] = update_phoneNo.Text;
                    list[temp + 8] = update_Landline.Text;
                    list[temp + 9] = update_EmailID.Text;

                    int i;
                    for (i = index1; list[i].ToString() != "*****"; i++)
                    {

                    }
                    int j = i - 1;
                    list[j] = imagePath;
                    account_BO.createAccount(list);
                    Home_Admin_AccountUpdate_Update_Show home_Admin_AccountStatement_Update_Show = new Home_Admin_AccountUpdate_Update_Show();
                    home_Admin_AccountStatement_Update_Show.giveIndex(index1);
                    home_Admin_AccountStatement_Update_Show.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong!!! Enter the information carefully");
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!");
            }
        }

        private void update_Reset_Click(object sender, EventArgs e)
        {
            update_userName_txt.Clear();
            update_Ocupation_TextBox.Clear();
            update_Gender_com.ResetText();
            update_address.Clear();
            update_phoneNo.Clear();
            update_Landline.Clear();
            update_EmailID.Clear();
            update_dop_dtp.ResetText();
            update_pictureBox.ImageLocation = "";
        }
    }
}
