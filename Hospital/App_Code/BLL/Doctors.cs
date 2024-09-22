using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Doctors
    {
        public int Id {  get; set; }
        public string DId {  get; set; }
        public string DFname { get; set; }
        public string DLname { get; set; }
        public string DPhone { get; set; }
        public string City { get; set; }
        public int Domain { get; set; }
        public DateTime DSeniority { get; set; }

        public void Save()
        {
            DoctorsDAL.Save(this);
        }
        public void Save(string ContextName)
        {
            DoctorsDAL.Save(this, ContextName);
        }

        public static List<Doctors> GetAll()
        {
            return DoctorsDAL.GetAll();
        }
        public static Doctors GetByiD(int Id)
        {
            return DoctorsDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return DoctorsDAL.DeleteByiD(Id);
        }


    }

}