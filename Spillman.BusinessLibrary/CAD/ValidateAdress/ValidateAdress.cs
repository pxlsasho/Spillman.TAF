using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;
using System;

namespace Spillman.BusinessLibrary
{
    public partial class ValidateAdress : BaseForm
    {
        private ValidateAdress _addANewCallFormInstance;
        private Duration _searchTime = 5000;

        public ValidateAdress(string xPath) : base(xPath)
        {
             Validate.Exists(ValidateAdressXPath, _searchTime);
            _addANewCallFormInstance = this;
        }
        public Button SelectButton
        {
            get { return FindSingle<Button>(SelectButtonXPath, _searchTime); }
        }
        public Text EnteredFieldText
        {
            get { return FindSingle<Text>(EnteredFieldXPath, _searchTime); }
        }
        
        public static string getPath()
        {
            return ValidateAdressXPath;
        }
    }
}
   

