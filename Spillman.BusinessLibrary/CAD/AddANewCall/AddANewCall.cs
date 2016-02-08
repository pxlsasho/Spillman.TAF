using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;
using System;

namespace Spillman.BusinessLibrary
{
    public partial class AddANewCall : BaseForm
    {
        private AddANewCall _addANewCallFormInstance;
        private Duration _searchTime = 250000;

        public AddANewCall(string xPath) : base(xPath)
        {
             Validate.Exists(AddANewCallXPath, _searchTime);
            _addANewCallFormInstance = this;
        }
        public Text TitleText
        {
            get { return FindSingle<Text>(TitleTextXPath, _searchTime); }
        }
        public ListItem AbadonedVechicleListItem
        {
            get { return FindSingle<ListItem>(AbandonedVehicleListItemXPath, _searchTime); }
        }
        public Button AcceptAdressButton
        {
            get { return FindSingle<Button>(AcceptAdressButtonXPath, _searchTime); }
        }
        public Button AcceptCallButton
        {
            get { return FindSingle<Button>(AcceptCallButtonXPath, _searchTime); }
        }

        public Text NatureField
        {
            get { return FindSingle<Text>(NatureFieldXPath, _searchTime); }
        }
        public Text AdressField
        {
            get { return FindSingle<Text>(AdressFieldXPath, _searchTime); }
        }
        public Text CallNumberField
        {
            get { return FindSingle<Text>(CallNumberFieldXPath, _searchTime); }
        }
        public static string getPath()
        {
            return AddANewCallXPath;
        }
    }
}
   

