using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Patzient
    {
        public int PCId { get; set; }
        public string PId { get; set; }
        public string PFname { get; set; }
        public string PLname { get; set; }
        public string PAddress { get; set; }
        public string PCity { get; set; }
        public float PAge { get; set; }
        public string Phone { get; set; }
        public int DId {  get; set; }
        public int PGender{ get; set; }
        public int Platoon { get; set; }
        public string PCarNumber { get; set; }

        public void Save()
        {
            PatzientDAL.Save(this);
        }
        public static List<Patzient> GetAll()
        {
            return PatzientDAL.GetAll();
        }
        public static Patzient GetByiD(int Id)
        {
            return PatzientDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return PatzientDAL.DeleteByiD(Id);
        }


    }
}