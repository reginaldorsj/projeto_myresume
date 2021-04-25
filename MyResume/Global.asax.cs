using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;

namespace MyResume
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            if (this.Context.Error is Regisoft.ExceptionRS ||
               (this.Context.Error.InnerException != null && this.Context.Error.InnerException is Regisoft.ExceptionRS))
                return;

            string arq = Server.MapPath(Request.ApplicationPath) + "\\Erros.txt";
            System.IO.StreamWriter fl = null;
            try
            {
                string texto = "(" + Request.UserHostAddress + "); " + Request.Path + ": ";
                Regisoft.Log LogAcesso = new Regisoft.Log(arq, true);
                LogAcesso.Gravar(texto);

                fl = File.AppendText(arq);
                for (int n = 0; n <= this.Context.AllErrors.Length - 1; n++)
                    fl.WriteLine(this.Context.AllErrors.GetValue(n));
            }
            catch { }
            finally
            {
                if (fl != null)
                    fl.Close();
            }

            if (!Request.IsLocal)
                Response.Redirect(Request.ApplicationPath + (!Request.ApplicationPath.EndsWith("/") ? "/" : string.Empty) + "Erro.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}