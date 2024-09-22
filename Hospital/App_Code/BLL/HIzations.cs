using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class HIzations
    {
        public int HId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }   
        public string Id { get; set; }
        public DateTime DReception { get; set; }
        public int DId { get; set; }
        public string TDescription { get; set; }
        public string TSummary { get; set; }
        public DateTime DRelease { get; set; }

        public void Save()
        {
            HIzationsDAL.Save(this);
        }
        public static List<HIzations> GetAll()
        {
            return HIzationsDAL.GetAll();
        }
        public static HIzations GetByiD(int Id)
        {
            return HIzationsDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return HIzationsDAL.DeleteByiD(Id);
        }

    }
}