using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume
{
    public static class LetterOfMonth
    {
        public static string Get(int? month, string idiom)
        {
            if (!month.HasValue)
                return "Present";

            if (idiom == null || idiom == "EN")
            {
                switch (month)
                {
                    case 1:
                        return "Jan";
                    case 2:
                        return "Feb";
                    case 3:
                        return "Mar";
                    case 4:
                        return "Apr";
                    case 5:
                        return "May";
                    case 6:
                        return "Jun";
                    case 7:
                        return "Jul";
                    case 8:
                        return "Aug";
                    case 9:
                        return "Sep";
                    case 10:
                        return "Oct";
                    case 11:
                        return "Nov";
                    case 12:
                        return "Dec";
                }
            }
            else
            {
                switch (month)
                {
                    case 1:
                        return "Jan";
                    case 2:
                        return "Fev";
                    case 3:
                        return "Mar";
                    case 4:
                        return "Abr";
                    case 5:
                        return "Mai";
                    case 6:
                        return "Jun";
                    case 7:
                        return "Jul";
                    case 8:
                        return "Ago";
                    case 9:
                        return "Set";
                    case 10:
                        return "Out";
                    case 11:
                        return "Nov";
                    case 12:
                        return "Dez";
                }

            }

            return null;
        }

    }
}