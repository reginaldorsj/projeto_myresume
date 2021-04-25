using MyResume.OR;
using Regisoft;
using System;
using System.Collections.Generic;
using System.Web;

namespace MyResume
{
    public partial class Education : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuControl1.MenuItem = "Education";

            if (Session["Idiom"] == null)
                Response.Redirect("~/Index.aspx");

            AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
            lblCaption.Text = BOAccess.getBOFactory().CaptionBO().SelecionarPor("IdAboutInfo", aboutInfo).Education;

            IList<OR.Education> lst = BOAccess.getBOFactory().EducationBO().ListarPorAboutInfo(aboutInfo);
            rptEducation.DataSource = lst;
            rptEducation.DataBind();

        }
    }
}