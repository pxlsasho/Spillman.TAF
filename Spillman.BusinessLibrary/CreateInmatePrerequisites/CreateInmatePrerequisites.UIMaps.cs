using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillman.BusinessLibrary
{
    public partial class CreateInmatePrerequisites

    {
        public static string CreateInmatePrerequisitesXPath = "/form[@controlname = 'CreateInmatePrerequisites']";
        public static string DOBTextBoxXPath = ".//text[@accessiblename = 'timeDateEditor1']";
        public static string SubmitButtonXPath = ".//button[@accessiblename='Submit']";
        public static string GenderComboBoxXPath = ".//combobox[@accessiblename='spillmanComboBox1']";
    }
}
