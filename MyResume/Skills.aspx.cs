using MyResume.OR;
using Regisoft;
using System;
using System.Collections.Generic;
using System.Web;

namespace MyResume
{
    public partial class Skills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuControl1.MenuItem = "Skills";

            if (Session["Idiom"] == null)
                Response.Redirect("~/Index.aspx");

            AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
            lblCaption.Text = BOAccess.getBOFactory().CaptionBO().SelecionarPor("IdAboutInfo", aboutInfo).Skills;

            IList<Skill> lst = BOAccess.getBOFactory().SkillBO().ListarPorAboutInfo(aboutInfo);
            rptSkillDetails.DataSource = lst;
            rptSkillDetails.DataBind();

            lblSkillSummary.Text = aboutInfo.SkillSummary;


        }
    }
}