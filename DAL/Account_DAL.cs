using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;
using System.Collections;
namespace DAL
{
    public class Account_DAL
    {
        public string generateID()
        {
            try
            {
                int m = 100000;
                StreamReader read = new StreamReader("C://BankAccountSystemData//Data//ID_Generator.txt");
                string s = read.ReadLine();
                
                int a = Convert.ToInt32(s);
                for (int i = 0; i < a; i++)
                {
                    m++;
                }
                m++;
                s = Convert.ToString(m);
                read.Close();
                return s;
               
            }
            catch(Exception e)
            {
                return null;
            }
           

        }
        public string getTotalUser()
        {
            try
            {
                StreamReader read = new StreamReader("C://BankAccountSystemData//Data//Total_ID.txt");
                string s = read.ReadLine();
                read.Close();
                return s;
            }
            catch(Exception e)
            {
                return null;
            }
           
        }
        
        public void setID_Generator()
        {
            StreamReader read = new StreamReader("C://BankAccountSystemData//Data//ID_Generator.txt");
            string s = read.ReadLine();
            int a = Convert.ToInt32(s);
            a++;
            
            s = Convert.ToString(a);
         
            read.Close();
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//ID_Generator.txt");
            try
            {
                write.WriteLine(s.ToString());
                write.Close();
            }
            catch(Exception e)
            {
               
            }
           

        }
        public void increaseTotalUser()
        {
            StreamReader read = new StreamReader("C://BankAccountSystemData//Data//Total_ID.txt");
            string s = read.ReadLine();
            int a = Convert.ToInt32(s);
            a++;

            s = Convert.ToString(a);

            read.Close();
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//Total_ID.txt");
            try
            {
                write.WriteLine(s.ToString());
                write.Close();
            }
            catch (Exception e)
            {

            }
        }
        public void decreaseTotalUser()
        {
            StreamReader read = new StreamReader("C://BankAccountSystemData//Data//Total_ID.txt");
            string s = read.ReadLine();
            int a = Convert.ToInt32(s);
            a--;

            s = Convert.ToString(a);
            
            read.Close();
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//Total_ID.txt");
            try
            {
                write.WriteLine(s.ToString());
                write.Close();
            }
            catch (Exception e)
            {

            }
        }
        public bool createAccount(ArrayList account)
        {
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//User.txt");
            try
            {
                for (int i = 0; i < account.Count; i++)
                {
                    write.WriteLine(account[i].ToString());
                }
                write.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public ArrayList readAccount()
        {
            try
            {
                string[] data = File.ReadAllLines("C://BankAccountSystemData//Data//User.txt");
                ArrayList list = new ArrayList(data);
                return list;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public bool security_Checker(string name, string password)
        {
            if ("rintu" == name && "rintu" == password)
            {
                return true;
            }
            else
                return false;
        }
        public bool setOwnerCost(ArrayList cost)
        {
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//Owner_Expenditure.txt");
            try
            {
                for (int i = 0; i < cost.Count; i++)
                {
                    write.WriteLine(cost[i].ToString());
                }
                write.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public ArrayList getOwnerCost()
        {
            try
            {
                string[] data = File.ReadAllLines("C://BankAccountSystemData//Data//Owner_Expenditure.txt");
                ArrayList list = new ArrayList(data);
                return list;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public bool setOwnerIncome(ArrayList income)
        {
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//Owner_Income.txt");
            try
            {
                for (int i = 0; i < income.Count; i++)
                {
                    write.WriteLine(income[i].ToString());
                }
                write.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public ArrayList getOwnerIncome()
        {
            try
            {
                string[] data = File.ReadAllLines("C://BankAccountSystemData//Data//Owner_Income.txt");
                ArrayList list = new ArrayList(data);
                return list;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public bool setUserBill(ArrayList cost)
        {
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//User_Bill.txt");
            try
            {
                for (int i = 0; i < cost.Count; i++)
                {
                    write.WriteLine(cost[i].ToString());
                }
                write.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public ArrayList getUserBill()
        {
            try
            {
                string[] data = File.ReadAllLines("C://BankAccountSystemData//Data//User_Bill.txt");
                ArrayList list = new ArrayList(data);
                return list;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool setNote(ArrayList note)
        {
            StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//Note.txt");
            try
            {
                for (int i = 0; i < note.Count; i++)
                {
                    write.WriteLine(note[i].ToString());
                }
                write.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public ArrayList getNote()
        {
            try
            {
                string[] data = File.ReadAllLines("C://BankAccountSystemData//Data//Note.txt");
                ArrayList list = new ArrayList(data);
                return list;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
