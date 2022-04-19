using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkedTogether
{
    public static class Common
    {
        //[DefaultValue(MessageType.None)]
        //public enum MessageType
        //{
        //    ISO8385 = 1,
        //    OFS = 2,
        //    XML = 3,
        //    Script = 4,
        //    None = 5
        //}

        public static char delimiterChars = ',';

        public static string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                                          //"MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                                          //"M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                                          //"M/d/yyyy h:mm", "M/d/yyyy h:mm",
                                          //"MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm",
                                          "dd/MM/yyyy", "dd.MM.yyyy", "dd-MM-yyyy"};

        public static Dictionary<string, ProjectObject> projects = new Dictionary<string, ProjectObject>();

        //string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
        //             "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
        //             "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
        //             "M/d/yyyy h:mm", "M/d/yyyy h:mm",
        //             "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};
        //string[] dateStrings = {"5/1/2009 6:32 PM", "05/01/2009 6:32:05 PM",
        //                  "5/1/2009 6:32:00", "05/01/2009 06:32",
        //                  "05/01/2009 06:32:00 PM", "05/01/2009 06:32:00"};
        //DateTime dateValue;

        public static DateTime checkDate(string dateString)
        {
            DateTime dateValue;
            if (!DateTime.TryParseExact(dateString, formats, new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
                dateValue = DateTime.Today;            
            return dateValue;
        }
    }
}
