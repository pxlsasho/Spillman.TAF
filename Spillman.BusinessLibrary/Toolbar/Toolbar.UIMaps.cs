using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillman.BusinessLibrary
{
    public partial class Toolbar
    {
        public static string ToolbarFormXPath = "/form[@title = 'Spillman 6.3']";
        //public static string ToolbarFormXPath = "/form[@processname = 'javaw' and @class = 'SunAwtDialog']";
        public static string ConsoleTextBoxXPath = ".//text[@type = 'BasicComboBoxEditor$BorderlessTextField']";
        public static string MainFormProgressBarXPath = ".//progressbar[@name = 'progressBar']";
    }
}
