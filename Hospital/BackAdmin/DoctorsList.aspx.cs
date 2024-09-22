using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class DoctorsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }
        public void FillData()
        {
            var Lst=Doctors.GetAll();
            var Lstt = Departments.GetAll();
            List<object> list = Lst.Select(x => new
            {
                Id = x.Id,
                DId = x.DId,
                DFname = x.DFname,
                DLname = x.DLname,
                DPhone = x.DPhone,
                City = x.City,
                Domain = Lstt.Where(l => l.DId == x.Domain).ToList()[0].DName,
            }).ToList<object>();
            RptD.DataSource = list;
            RptD.DataBind();
        }
    }
}