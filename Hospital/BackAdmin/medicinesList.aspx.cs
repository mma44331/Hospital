using BLL;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class medicinesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FileData();
            }

        }
        public void FileData()
        {
          

            RptMedicines.DataSource = Medicines.GetAll();//מקור הנתונים הוא 
            RptMedicines.DataBind();//מתחיל להפעיל אותו
        }
    }
}