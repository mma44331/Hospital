using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class PatientDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FileDate();
            }
        }
        public void FileDate()
        {
            Patzient Tmp = null;
            string PCId= Request["PCId"] + "";
            if (string.IsNullOrEmpty(PCId))
            {
                PCId = "-1";
            }
            else
            {
                Tmp = Patzient.GetByiD(int.Parse(PCId));
                if (Tmp == null)
                {
                    PCId="-1";
                }
            }
            HidP.Value = PCId;
            Platoon.DataSource =Departments.GetAll();
            Platoon.DataTextField = "DName";
            Platoon.DataValueField = "DId";
            Platoon.DataBind();
            Platoon.Items.Insert(0, "בחר מחלקה");
            DDLDId.DataSource =Doctors.GetAll();
            DDLDId.DataTextField = "DLname";
            DDLDId.DataValueField = "Id";
            DDLDId.DataBind();
            DDLDId.Items.Insert(0, "בחר רופא");
            

            if(Tmp != null)
            {
                FName.Text = Tmp.PFname;
                LName.Text = Tmp.PLname;
                Id.Text = Tmp.PId;
                Phone.Text = Tmp.Phone;
                City.Text = Tmp.PCity;
                Address.Text = Tmp.PAddress;
                Gender.Text = Tmp.PGender+"";
                Age.Text = Tmp.PAge+"";
                Platoon.Text= Tmp.Platoon+"";
                DDLDId.Text = Tmp.DId + "";
                CarNumber.Text = Tmp.PCarNumber;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Patzient Tmp = new Patzient()
            {
                PCId = int.Parse(HidP.Value + ""),
                PFname = FName.Text,
                PLname = LName.Text,
                PId = Id.Text,
                Phone = Phone.Text,
                PCity = City.Text,
                PAddress = Address.Text,
                PGender = int.Parse(Gender.Text + ""),
                PAge = float.Parse(Age.Text + ""),
                Platoon = int.Parse(Platoon.Text + ""),
                DId = int.Parse(DDLDId.Text + ""),
              PCarNumber= CarNumber.Text
            };
            Tmp.Save();
            Response.Redirect("PatientList.aspx");


        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            Patzient Tmp = new Patzient()
            {
                PCId = int.Parse(HidP.Value),
                PFname = FName.Text,
                PLname = LName.Text,
                PId = Id.Text,
                Phone = Phone.Text,
                PCity = City.Text,
                PAddress = Address.Text,
                PGender = int.Parse(Gender.Text+""),
                PAge = float.Parse(Age.Text),
                Platoon = int.Parse(Platoon.Text + ""),
                PCarNumber = CarNumber.Text
            };
            Patzient.DeleteByiD(Tmp.PCId);
            Response.Redirect("PatientList.aspx");

        }
    }
}