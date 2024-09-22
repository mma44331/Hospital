using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class MyPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FilleData();
            }

        }
        public void FilleData()
        {
            List<Departments> Ldep = Departments.GetAll();
            List<Patzient> lst=new List<Patzient>();
            List<Patzient> list = new List<Patzient>();
             string Id = Request["DDId"];
            if (string.IsNullOrEmpty(Id.ToString()))
            {
                Id = "-1";
            }
            else
            {
               list= Patzient.GetAll();
                for (int i = 0; i < list.Count; i++)
                {
                    if (Id == list[i].DId.ToString())
                    {
                        lst.Add(new Patzient()
                        {
                            PCId = list[i].PCId,
                            PId = list[i].PId,
                            PFname = list[i].PFname,
                            PLname = list[i].PLname,
                            PAddress = list[i].PAddress,    
                            PCity = list[i].PCity,
                            PAge = list[i].PAge,
                            Phone = list[i].Phone,
                            PGender = list[i].PGender,
                            Platoon = list[i].Platoon,
                            DId = list[i].DId,
                            PCarNumber = list[i].PCarNumber,
                        });
                    }
                }
                List<object> lsto = lst.Select(x => new
                {
                    PCId = x.PCId,
                    PId = x.PId,
                    PFname = x.PFname,
                    PLname = x.PLname,
                    PAddress = x.PAddress,
                    PCity = x.PCity,
                    PAge = x.PAge,
                    Phone = x.Phone,
                    PGender = x.PGender,
                    Platoon = Ldep.Where(d => d.DId == x.Platoon).ToList()[0].DName,
                    DId = x.DId,
                    PCarNumber = x.PCarNumber,
                }).ToList<object>();
                RPL.DataSource = lsto
                    ;
                RPL.DataBind();
                
            }
        }
    }
}