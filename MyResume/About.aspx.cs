using MyResume.OR;
using System;
using System.Web.UI;
using System.IO;

namespace MyResume
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuControl1.MenuItem = "About";

            if (Session["Idiom"] == null)
                Response.Redirect("~/Index.aspx");

            AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
            switch (aboutInfo.Idiom)
            {
                case "PT":
                    lblGreetings.Text = "Oi, Eu sou";
                    btnBrasil.Visible = false;
                    btnUS.Visible = true;
                    break;
                default:
                    lblGreetings.Text = "Hi, I'm";
                    btnBrasil.Visible = true;
                    btnUS.Visible = false;
                    break;
            }

            lblFirstName.Text = aboutInfo.FirstName;
            lblLastName.Text = aboutInfo.LastName;
            lblSummary.Text = aboutInfo.Summary;
            lblHeadLine.Text = aboutInfo.HeadLine;

            lnkFacebook.NavigateUrl = aboutInfo.FacebookUrl;
            lnkGithub.NavigateUrl = aboutInfo.GithubUrl;
            lnkLinkedIn.NavigateUrl = aboutInfo.LinkedinUrl;
        }

        protected void btnBrasil_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("Idiom", "PT");
            Page_Load(sender, null);

        }

        protected void btnUS_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("Idiom", "EN");
            Page_Load(sender, null);
        }

        protected void btnDownload_Click(object sender, ImageClickEventArgs e)
        {
            byte[] bytes;
            string fileName;
            if (Session["Idiom"].ToString() == "PT")
                fileName = "Reginaldo_Rodrigues_da_Silva_Junior_CurriculoFinal.pdf";
            else
                fileName = "Reginaldo_Rodrigues_da_Silva_Junior_FinalResume.pdf";

            string path = Request.MapPath(Request.ApplicationPath) + "\\Downloads\\" + fileName;

            bytes = File.ReadAllBytes(path);
            Response.AddHeader("content-disposition", "attachment; filename=" + fileName);
            Response.ContentType = "application/pdf";
            Response.OutputStream.Write(bytes, 0, bytes.Length);
        }
    }
}