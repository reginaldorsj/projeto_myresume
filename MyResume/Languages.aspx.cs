using MyResume.OR;
using Regisoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyResume
{
    public partial class Languages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuControl1.MenuItem = "Languages";

            if (Session["Idiom"] == null)
                Response.Redirect("~/Index.aspx");

            AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
            lblCaption.Text = BOAccess.getBOFactory().CaptionBO().SelecionarPor("IdAboutInfo", aboutInfo).Languages;

            IList<OR.Language> lst = BOAccess.getBOFactory().LanguageBO().ListarPorAboutInfo(aboutInfo);
            rptLanguages.DataSource = lst;
            rptLanguages.DataBind();

        }
    }
}