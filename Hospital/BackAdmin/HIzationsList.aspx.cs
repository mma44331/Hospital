using BLL;
using Microsoft.Win32;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.Back_Admin
{
    public partial class _new : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FileDate();
            }
        }
        public void FileDate()
        {
            var Lst = Doctors.GetAll();
            var Lstt = HIzations.GetAll();
            List<object> list = Lstt.Select(x => new
            {
                HId=x.HId,
                Id = x.Id,
                FName=x.FName,
                LName=x.LName,
                DReception = x.DReception,
                DId =Lst.Where(c => c.Id == x.DId).ToList()[0].DLname,
                TDescription = x.TDescription,
                TSummary = x.TSummary,
                DRelease = x.DRelease,

            }).ToList<object>();
            RptHIL.DataSource = list; 
            RptHIL.DataBind();
           

        }

    }
}