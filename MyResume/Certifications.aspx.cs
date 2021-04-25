using MyResume.OR;
using Regisoft;
using System;
using System.Collections.Generic;
using System.Web;

namespace MyResume
{
    public partial class Certifications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuControl1.MenuItem = "Certifications";

            if (Session["Idiom"] == null)
                Response.Redirect("~/Index.aspx");

            AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
            lblCaption.Text = BOAccess.getBOFactory().CaptionBO().SelecionarPor("IdAboutInfo", aboutInfo).Certifications;

            IList<ProfessionalDevelopment> lst = BOAccess.getBOFactory().ProfessionalDevelopmentBO().ListarPorAboutInfo(aboutInfo);
            rptCertifications.DataSource = lst;
            rptCertifications.DataBind();

        }
    }
}