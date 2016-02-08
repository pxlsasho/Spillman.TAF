using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;

namespace Spillman.BusinessLibrary
{
    public partial class Toolbar : BaseForm
    {
        private Toolbar _toolbarInstance;
        private Duration _searchTime = 50000;
        public Toolbar(string xPath) : base(xPath)
        {
            _toolbarInstance = this;
        }
        public Text ConsoleTextBox
        {
            get { return FindSingle<Text>(ConsoleTextBoxXPath, _searchTime); }
        }
        public ProgressBar MainFormProgressBar
        {
            get { return FindSingle<ProgressBar>(MainFormProgressBarXPath, _searchTime); }
        }

        public void WaitUntilLoads()
        {
            try
            {
                while (MainFormProgressBar.Visible)
                {
                    Delay.Seconds(1);
                }
            }
            catch
            {
                
            }
           
        }
        public void OpenCAD()
        {
            ConsoleTextBox.Click();
            ConsoleTextBox.TextValue = "cad";
            ConsoleTextBox.PressKeys("{enter}");
        }
        public void OpenNames()
        {
            ConsoleTextBox.Click();
            ConsoleTextBox.TextValue= "names";
            ConsoleTextBox.PressKeys("{enter}");
        }
        public void OpenInmates()
        {
            ConsoleTextBox.Click();
            ConsoleTextBox.TextValue = "inmate";
            ConsoleTextBox.PressKeys("{enter}");
        }
        public void StartBooking()
        {
            ConsoleTextBox.Click();
            ConsoleTextBox.TextValue = "startbooking";
            ConsoleTextBox.PressKeys("{enter}");
        }
        public void NoNameBooking()
        {
            ConsoleTextBox.Click();
            ConsoleTextBox.TextValue = "nonamebooking";
            ConsoleTextBox.PressKeys("{enter}");
        }

        public static string getPath()
        {
            return ToolbarFormXPath;
        }
    }
}
   

