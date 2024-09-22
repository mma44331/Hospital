using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class HIzationsAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FilleData();
            }

        }
        public void FilleData()
        {
            HIzations Tmp = null;
            string Id = Request["HId"];
            if (string.IsNullOrEmpty(Id))
            {
                Id = "-1";
            }
            else
            {
                Tmp = HIzations.GetByiD(int.Parse(Id));
                if (Tmp == null)
                {
                    Id = "-1";
                }
            }
            HId.Value =Id;
            DDLId.DataSource = Doctors.GetAll();
            DDLId.DataTextField = "DLName";
            DDLId.DataValueField = "Id";
            DDLId.DataBind();
            DDLId.Items.Insert(0, "בחר רופא מטפל");
            

            if(Tmp != null)
            {
                PId.Text=Tmp.Id;
                FNmae.Text = Tmp.FName;
                LName.Text = Tmp.LName;
                DReception.Text = Tmp.DReception.ToString("dd/MM/yyyy");
                DDLId.Text = Tmp.DId + "";
                TDescription.Text = Tmp.TDescription;
                TSummary.Text = Tmp.TSummary;
                DRelease.Text = Tmp.DRelease.ToString("dd/MM/yyyy");
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            HIzations Tmp = new HIzations()
            {
                HId = int.Parse(HId.Value + ""),
                Id = PId.Text,
                FName = FNmae.Text,
                LName = LName.Text,
                DReception = DateTime.Parse(DReception.Text + ""),
                DId = int.Parse(DDLId.SelectedValue + ""),
                TDescription = TDescription.Text,
                TSummary = TSummary.Text,
                DRelease = DateTime.Parse(DRelease.Text.ToString())
            };
            Tmp.Save();
            Response.Redirect("HIzationsList.aspx");

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            HIzations Tmp = new HIzations()
            {
                HId = int.Parse(HId.Value + ""),
                Id = PId.Text,
                FName = FNmae.Text,
                LName = LName.Text,
                DReception = DateTime.Parse(DReception.Text + ""),
                DId = int.Parse(DDLId.SelectedValue + ""),
                TDescription = TDescription.Text,
                TSummary = TSummary.Text,
                DRelease = DateTime.Parse(DRelease.Text.ToString())
            };
            HIzations.DeleteByiD(Tmp.HId);
            Response.Redirect("HIzationsList.aspx");
        }
    }
}