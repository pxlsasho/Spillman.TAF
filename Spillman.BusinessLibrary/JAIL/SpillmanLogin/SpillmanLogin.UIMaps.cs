using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillman.BusinessLibrary
{
    public partial class SpillmanLogin
    {
        public static string LoginFormXPath = "/form[@title = 'Spillman Login']";
        public const string DetailsButtonXPath = ".//container//button[@automationid='DetailButton']";
        //public const string DetailsButtonXPath = ".//button[@name='detail']";
        public const string LoginXPath = ".//button[@automationid = 'LoginButton']";
        public const string SecondLoginXPath = ".//button[@name = 'login']";
        public const string UserNameXPath = ".//text[@automationid='UserNameTextBox']";
        public const string PasswordXPath = ".//text[@automationid='PasswordTextBox']";
        public const string dbaseXPath = ".//combobox[@name='DBASE']";
        public const string MessageOfTheDayOkButtonXPath = "/form[@title = 'Message Of The Day'] /?/?/ button[@name = 'Ok']";

    }
}
