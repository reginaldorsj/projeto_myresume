using MyResume.OR;
using Regisoft;
using System;
using System.Collections.Generic;
using System.Web;

namespace MyResume
{
    public partial class Experience : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuControl1.MenuItem = "Experience";

            if (Session["Idiom"] == null)
                Response.Redirect("~/Index.aspx");

            AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
            lblCaption.Text = BOAccess.getBOFactory().CaptionBO().SelecionarPor("IdAboutInfo", aboutInfo).Experience;

            IList<OR.Experience> lst = BOAccess.getBOFactory().ExperienceBO().ListarPorAboutInfo(aboutInfo);
            rptExperience.DataSource = lst;
            rptExperience.DataBind();

        }
    }
}