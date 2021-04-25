using System;
using System.Web;

namespace MyResume
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Add("Idiom", HttpContext.Current.Request.UserLanguages[0].Substring(0, 2).ToUpper());
            
            Response.Redirect("~/About.aspx");
        }
    }
}