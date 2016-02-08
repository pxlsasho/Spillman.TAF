using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;

namespace Spillman.BusinessLibrary
{
    public partial class CADToolbar : Toolbar
    {
        private CADToolbar _toolbarInstance;
        private Duration _searchTime = 50000;
        public CADToolbar(string xPath) : base(xPath)
        {
            _toolbarInstance = this;
        }
        public void Exit()
        {
            ConsoleTextBox.Click();
            ConsoleTextBox.TextValue = "exit";
            ConsoleTextBox.PressKeys("{enter}");
        }
        public AddANewCall AddCall()
        {
            ConsoleTextBox.Click();
            ConsoleTextBox.TextValue = "ac";
            ConsoleTextBox.PressKeys("{enter}");

            AddANewCall addANewCallForm = new AddANewCall(AddANewCall.getPath());
            Validate.Exists(addANewCallForm);

            return addANewCallForm;
        }
    }
}
   

