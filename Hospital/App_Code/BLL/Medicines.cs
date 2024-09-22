using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Medicines
    {
        public int MId { get; set; }
        public string Mname { get; set; }
        public float Price{ get; set; }
        public string MBarCod {  get; set; }
        public void Save()
        {
            MedicinesDAL.Save(this);
        }
        public static List<Medicines> GetAll()
        {
            return MedicinesDAL.GetAll();
        }
        public static Medicines GetByiD(int Id)
        {
            return MedicinesDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return MedicinesDAL.DeleteByiD(Id);
        }


    }
}