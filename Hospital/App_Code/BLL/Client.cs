using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Client
    {
        public int CId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
       
        public bool ChkLogin()
        {
            return ClientDAL.ChkLogin(this);
        }

        public void Save()
        {
            ClientDAL.Save(this);
        }
        public static List<Client> GetAll()
        {
            return ClientDAL.GetAll();
        }
        public static Client GetByiD(int Id)
        {
            return ClientDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return ClientDAL.DeleteByiD(Id);
        }



    }
}