using MyResume.OR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MyResume
{
    public partial class MenuControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Caption Caption
        {
            get
            {
                AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
                return BOAccess.getBOFactory().CaptionBO().SelecionarPor("IdAboutInfo", aboutInfo);
            }

        }

        public string MenuItem
        {
            set
            {
                HtmlControl htmlControl = (HtmlControl)FindControl("uli" + value);
                htmlControl.Attributes.Add("class", "active");

                Label lblHome = (Label)Page.Master.FindControl("lblHome");
                lblHome.Visible = value != "About";


            }
        }
    }
}