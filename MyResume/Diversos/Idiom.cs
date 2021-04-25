using MyResume.OR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume
{
    public static class Idiom
    {
        public static AboutInfo GetAboutInfo(string language)
        {

            AboutInfo aboutInfo = null;
            if (language != null && language.StartsWith("PT"))
                aboutInfo = BOAccess.getBOFactory().AboutInfoBO().SelecionarPor("Idiom", "PT");

            if (aboutInfo != null)
                return aboutInfo;
            else
                return BOAccess.getBOFactory().AboutInfoBO().SelecionarPor("Idiom", "EN");

        }
    }
}