using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace BLL
{
    public class DbLogs
    {     
        public object _id { get; set; }
        public string operation {  get; set; }
        public int user {  get; set; }  
        public DateTime date { get; set; }
        public int Save() 
        {
            return DbLogsDAL.Save(this);
        }
    }
}