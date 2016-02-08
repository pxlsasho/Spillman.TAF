using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;

namespace Spillman.BusinessLibrary
{
    public partial class Inmate : BaseForm
    {
        private Inmate _toolbarInstance;
        private Duration _searchTime = 150000;

        public Inmate(string xPath) : base(xPath)
        {
            Validate.Exists(getPath(), _searchTime);
            _toolbarInstance = this;
        }
        public Text NameNumberTextBox
        {
            get { return FindSingle<Ranorex.Text>(NameNumberTextBoxXPath, _searchTime); }
        }
        public Button SaveButton
        {
            get { return FindSingle<Button>(SaveButtonXPath, _searchTime); }
        }
        public Button AddButton
        {
            get { return FindSingle<Button>(AddButtonXPath, _searchTime); }
        }
        public Button IdentifyButton
        {
            get { return FindSingle<Button>(IdentifyButtonXPath, _searchTime); }
        }
        public void AddInmate(string number)
        {
            AddButton.Click();
            NameNumberTextBox.Click();
            Delay.Seconds(1);
            NameNumberTextBox.PressKeys(number);
            NameNumberTextBox.PressKeys("{enter}");
            SaveButton.Click();
            Delay.Seconds(5);
        }
        public static string getPath()
        {
            return InmateXPath;
        }
    }
}
   

