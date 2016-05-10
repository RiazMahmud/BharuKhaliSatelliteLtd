using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using System.Collections;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_Note : Form
    {
        public Home_Admin_Note()
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

      

        private void rightOptionPnlTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void Home_Admin_Note_MouseMove(object sender, MouseEventArgs e)
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

        private void rightOptionPnlTimer_Tick_1(object sender, EventArgs e)
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

        private void reset_btn_Click(object sender, EventArgs e)
        {
            entryDtp.ResetText();
            writeNote_txt.Clear();
        }

        private void saveCost_btn_Click(object sender, EventArgs e)
        {
            try{
                Account_BO ab = new Account_BO();
                ArrayList note = new ArrayList();
                ArrayList temp = new ArrayList();
                note = ab.getNote();
                int f = 0;
                for (int i = 0; i < note.Count; i++)
                {
                    temp.Add(note[i].ToString());
                   
                    if (note[i].ToString() == entryDtp.Text)
                    {
                        
                        temp.Add(writeNote_txt.Text);
                        
                        for (int m = i + 1; m < note.Count ; m++)
                        {
                            temp.Add(note[m].ToString());
                        }
                        ab.setNote(temp);
                        MessageBox.Show("Save Successfully Done");
                        entryDtp.ResetText();
                        writeNote_txt.Clear();
                        f = 1;
                        break;
                    }
                   
                }
                if (f == 0)
                {
                     
                        note.Add(entryDtp.Text);
                        note.Add(writeNote_txt.Text);
                        note.Add("*");
                        ab.setNote(note);
                        MessageBox.Show("Save Successfully Done");
                        entryDtp.ResetText();
                        writeNote_txt.Clear();
                    
                }

                
            }
            catch(Exception)
            {
                MessageBox.Show("Error !!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList note = new ArrayList();
            dataGridView1.Rows.Clear();
            note = account_BO.getNote();
            int f = 0;
           
            for (int i = 0; i < note.Count; i++)
            {

                if (viewTimePicker.Text == note[i].ToString())
                {
                    for (int j = i+1; note[j].ToString() != "*"; j++)
                    {
                        dataGridView1.Rows.Add(note[i].ToString(), note[j].ToString());
                        f = 1;
                    }
                }
            }
            if (f == 0)
                MessageBox.Show("This date is not exist");
        }

        private void Home_Admin_Note_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();
        }

}
}
