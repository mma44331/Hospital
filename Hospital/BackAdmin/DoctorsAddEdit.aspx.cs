using BLL;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class DoctorsAddEdit : System.Web.UI.Page
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
            //string EndPoint = "https://data.gov.il/api/3/action/datastore_search";
            //string Search = "אשד";
            //var Client = new RestClient(EndPoint);
            //var request = new RestRequest();
            //request.AddParameter(" resource_id", "5c78e9fa-c2e2-4771-93ff-7f400a12f7ba");
            //request.AddParameter("q", Search);
            //var res = Client.Get(request);
            //var x = res.Content.ToLower();
            //var obj = JsonConvert.DeserializeObject<dynamic>(x);
            //var records = obj.result.records;
            //DDLCity.DataSource = records;
            //DDLCity.DataBind();


            Doctors Tmp = null;
            string Id = Request["Id"] + "";//מקבל את המספר שנשלח עם הבקשה לדף
            if (string.IsNullOrEmpty(Id))//בודק האם הגיע משהו למשתנה או לא
            {
                Id = "-1";//במידה ולא הגיע שום דבר אז אנחנו במצב של הוספה 
            }
            else
            {
                Tmp = Doctors.GetByiD(int.Parse(Id));//במידה וכן הגיע מספר כלשהוא אז תשלוף את מבסיס הנתונים את הלוקח על פי המספר שהגיע
                if (Tmp == null)
                {
                    Id = "-1";
                }
            }
            HidId.Value = Id;
            DDLDomain.DataSource = Departments.GetAll();
            DDLDomain.DataTextField = "DName";
            DDLDomain.DataValueField = "DId";
            DDLDomain.DataBind();
            DDLDomain.Items.Insert(0, "בחר תחום התמקצעות");
            DDLCity.DataBind();
            DDLCity.Items.Insert(0, "אנאבחרעיר");

       
            if (Tmp != null)//ממלאים את השדות עם הנתונים שהיגעו מה    DATABASE 
            {
                DId.Text = Tmp.DId;
                FName.Text = Tmp.DFname;
                LName.Text = Tmp.DLname;
                Phone.Text = Tmp.DPhone;
                DDLCity.Text = Tmp.City;
                DDLDomain.Text = Tmp.Domain+"";
                Seniority.Text = Tmp.DSeniority.ToString();
            }
            

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            string Msg = "";
            if (Phone.Text.Length!=10)
            {
                Msg = "עליך להזין מספר פלאפון באורך 10 תווים";
                LtlCheck.Text = Msg;
            }
            if (Msg.Length == 0)
            {
                    Doctors Tmp = new Doctors()
                    {
                        Id = int.Parse(HidId.Value),
                        DId = DId.Text,
                        DFname = FName.Text,
                        DLname = LName.Text,
                        DPhone = Phone.Text,
                        City = DDLCity.Text,
                        Domain = int.Parse(DDLDomain.SelectedValue + ""),
                        DSeniority = DateTime.Parse(Seniority.Text.ToString()),
                    };
                    Tmp.Save();
                    Response.Redirect("DoctorsList.aspx");
            }           
        }
    }
}