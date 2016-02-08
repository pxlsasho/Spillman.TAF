using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;
using System;

namespace Spillman.BusinessLibrary
{
    public partial class Booking : BaseForm
    {
        private Booking _loginFormInstance;
        private Duration _searchTime = 250000;

        public Booking(string xPath) : base(xPath)
        {
             Validate.Exists(BookingXPath, _searchTime);
            _loginFormInstance = this;
        }
        public Text LastNameText
        {
            get { return FindSingle<Text>(LastNameTextXPath, _searchTime); }
        }
       
        public static string getPath()
        {
            return BookingXPath;
        }
    }
}
   

