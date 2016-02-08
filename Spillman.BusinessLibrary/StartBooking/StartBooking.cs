using Ranorex;
using Ranorex.Core;

namespace Spillman.BusinessLibrary
{
    public partial class StartBooking : Form
    {
        private StartBooking _loginFormInstance;
        private Duration _searchTime = 50000;

        public StartBooking(string xPath) : base(xPath)
        {
            _loginFormInstance = this;
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
            PressKeys("{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}");
            PressKeys(cellName);
            PressKeys("{enter}");
        }
        public static string getPath()
        {
            return SpillmanStartBookingXPath;
        }
    }
}
   

