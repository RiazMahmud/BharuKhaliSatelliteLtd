using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;
using System.Collections;
namespace BO
{
    public class Account_BO
    {
        
        Account_DAL account_DAL = new Account_DAL();
        public bool createAccount(ArrayList account)
        {
            return account_DAL.createAccount(account);
        }
        public string getTotalUser()
        {
            return account_DAL.getTotalUser();
        }
        public ArrayList readAccount()
        {
            return account_DAL.readAccount();
        }
        public void increaseTotalUser()
        {
            account_DAL.increaseTotalUser();
        }
        public void decreaseTotalUser()
        {
            account_DAL.decreaseTotalUser();
        }
        public bool security_Checker(string name, string password)
        {
            return account_DAL.security_Checker(name, password);
        }
        public string generateID()
        {
            return account_DAL.generateID();
        }
        public void setID_Generator()
        {
            account_DAL.setID_Generator();
        }
        public bool setOwnerCost(ArrayList cost)
        {
            return account_DAL.setOwnerCost(cost);
        }
        public ArrayList getOwnerCost()
        {
            return account_DAL.getOwnerCost();
        }
        public bool setUserBill(ArrayList cost)
        {
            return account_DAL.setUserBill(cost);
        }
        public ArrayList getUserBill()
        {
            return account_DAL.getUserBill();
        }
        public bool setOwerIncome(ArrayList income)
        {
            return account_DAL.setOwnerIncome(income);
        }
        public ArrayList getOwnerincome()
        {
            return account_DAL.getOwnerIncome();
        }
        public bool setNote(ArrayList note)
        {
            return account_DAL.setNote(note);
        }
        public ArrayList getNote()
        {
            return account_DAL.getNote();
        }
    }
}
