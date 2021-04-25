using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Regisoft;
using System.IO;
using MyResume.OR;

namespace MyResume
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        public AboutInfo aboutInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            aboutInfo = Idiom.GetAboutInfo(HttpContext.Current.Request.UserLanguages[0]);

            lnkFacebook.NavigateUrl = aboutInfo.FacebookUrl;
            lnkGithub.NavigateUrl = aboutInfo.GithubUrl;
            lnkLinkedIn.NavigateUrl = aboutInfo.LinkedinUrl;

            lblEmail.Text = aboutInfo.Email;
            lblLocation.Text = aboutInfo.LocationInThisCountry+", "+ aboutInfo.Country;
            lblPhone.Text = aboutInfo.CellPhone;           
        }
    }
}