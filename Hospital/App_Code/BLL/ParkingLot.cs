using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class ParkingLot
    {
        public int CId {  get; set; }
        public string CNumber { get; set; }
        public DateTime EntryTime {  get; set; }
        public DateTime ReleaseTime {  get; set; }

        public void Save()
        {
            ParkingLotDAL.Save(this);
        }
        public static List<ParkingLot> GetAll()
        {
            return ParkingLotDAL.GetAll();
        }
        public static ParkingLot GetByiD(int Id)
        {
            return ParkingLotDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return ParkingLotDAL.DeleteByiD(Id);
        }

    }
}