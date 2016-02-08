using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillman.BusinessLibrary
{
    public partial class NameQuickSearch
    {
        public static string SpillmanNameQuickSearchFormXPath = "/form[@controlname = 'NameQuickSearchWindow']";
        public static string LastNameQuickSearchTextBoxXPath = ".//text[@accessiblename='lastName' and @accessiblerole='Text']";
        public static string SearchButtonXPath = ".//button[@accessiblename = 'Search']";
        public static string SelectNameButtonXPath = ".//button[@accessiblename = 'Select Name']";

        public static implicit operator NameQuickSearch(Inmate v)
        {
            throw new NotImplementedException();
        }
    }
}
