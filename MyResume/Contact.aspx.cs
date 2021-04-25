using MyResume.OR;
using Regisoft;
using Regisoft.Web;
using System;
using System.Web;

namespace MyResume
{
    public partial class Contact : System.Web.UI.Page
    {
        protected AboutInfo aboutInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuControl1.MenuItem = "Contact";

            if (Session["Idiom"] == null)
                Response.Redirect("~/Index.aspx");

            AboutInfo aboutInfo = Idiom.GetAboutInfo(Session["Idiom"].ToString());
            lblCaption.Text = BOAccess.getBOFactory().CaptionBO().SelecionarPor("IdAboutInfo", aboutInfo).Contact;

            lblContactSummary.Text = aboutInfo.ContactSummary;
            txtFullName.Attributes.Add("placeholder", aboutInfo.NameContactField);
            txtEmailAddress.Attributes.Add("placeholder", aboutInfo.EmailContactField);
            txtPhone.Attributes.Add("placeholder", aboutInfo.PhoneContactField);
            txtComments.Attributes.Add("placeholder", aboutInfo.CommentsContactField);
            bntSendMessage.Text = aboutInfo.SendMessageContacttButton;

        }

        protected void Msg(string texto)
        {
            JavaScriptManager.Alert(Page, texto);
        }

        protected void bntSendMessage_Click(object sender, EventArgs e)
        {
            if (!stringf.ValidaEmail(txtEmailAddress.Text, true))
            {
                Msg("Invalid Email.");
                return;
            }

            try
            {
                string corpo = @"
Message was received by the website http://reginaldojr.somee.com

Name: {0}
E-mail: {1}
Phone: {2}
Comments: {3}
";
                corpo = string.Format(corpo, txtFullName.Text, txtEmailAddress.Text, txtPhone.Text, txtComments.Text);
                Email.Enviar("reginaldojr@yahoo.com", "reginaldojr.somee.com - Message Received", corpo);
            }
            catch (ExceptionRS E)
            {
                Msg(E.Message);
                return;
            }
            Msg("Message sent successfully. You'll received the answer as soon as possible.");
            txtFullName.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtComments.Text = string.Empty;
        }
    }
}