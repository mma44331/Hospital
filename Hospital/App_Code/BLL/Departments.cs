using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Departments
    {
        public int DId {  get; set; }
        public string DName { get; set; }
        public string DHead { get; set; }

        public void Save()
        {
            DepartmentsDAL.Save(this);
        }
        public static List<Departments> GetAll()
        {
            return DepartmentsDAL.GetAll();
        }
        public static Departments GetByiD(int Id)
        {
            return DepartmentsDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return DepartmentsDAL.DeleteByiD(Id);
        }


    }
}