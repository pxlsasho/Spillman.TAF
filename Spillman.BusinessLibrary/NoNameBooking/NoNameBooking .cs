using Ranorex;
using SoftServe.TAF.BaseControls;

namespace Spillman.BusinessLibrary
{
    public partial class NoNameBooking : BaseForm
    {
        private NoNameBooking _loginFormInstance;
        private Duration _searchTime = 50000;

        public NoNameBooking(string xPath) : base(xPath)
        {
           Validate.Exists(getPath(), _searchTime);
        }
        public Button StartNewButton
        {
            get { return FindSingle<Button>(StartNewButtonXPath, _searchTime); }
        }
        public Button ProceedButton
        {
            get { return FindSingle<Button>(ProceedButtonXPath, _searchTime); }
        }
        public Text DOBTextBox
        {
            get { return FindSingle<Text>(DOBTextBoxXPath, _searchTime); }
        }
        public Text LastNameTextBox
        {
            get { return FindSingle<Text>(LastNameTextBoxXPath, _searchTime); }
        }
        public Button LocationTextBox
        {
            get { return FindSingle<Button>(LocationTextBoxXPath, _searchTime); }
        }
        public void setCell(string cellName)
        {
            LocationTextBox.Click();
            LocationTextBox.PressKeys(cellName);
            PressKeys("{enter}");
        }
        public static string getPath()
        {
            return SpillmanStartBookingXPath;
        }
    }
}
   

