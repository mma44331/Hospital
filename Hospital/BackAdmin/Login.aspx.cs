using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string Msg = "";
            if (FullName.Text.Length < 3)
                Msg += "עליך להזין שם מלא<br/>";
            if (Password.Text.Length < 6 || Password.Text.Contains(" "))
                Msg += "סיסמה לא תקינה, עליך להזין סיסמה חוקית לפחות 6 תווים וללא רווחים";
            if (Msg != "")
                LtlMsg.Text = Msg;

            Client Tmp = new Client()
            {
                FullName = FullName.Text,
                Email = Email.Text,
                Pass = Password.Text
            };
            if (Tmp.ChkLogin())
            {
                Session["ClientLogin"] = Tmp;//משמר את האבייקט הנוכחי עם הפרטים המלאים באיחסון כדי להשתמש עם זה תמיד ולחסוך לשלוף כל פעם מהDATABA
                Response.Redirect("/BackAdmin/ListDepartments.aspx");// מפנה אותך לדף הרצוי
            }
            else
            {
                Msg += "הפרטים שהוזנו שגויים<br/>";
                Msg += "אנא הכנס פרטים נכונים<br/>";
                LtlMsg.Text = Msg;
            }

        }
    }
}