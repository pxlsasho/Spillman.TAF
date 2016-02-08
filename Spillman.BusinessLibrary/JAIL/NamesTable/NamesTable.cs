using Ranorex;
using Ranorex.Core;

namespace Spillman.BusinessLibrary
{
    public partial class NamesTable : Form
    {
        private NamesTable _loginFormInstance;
        private Duration _searchTime = 50000;

        public NamesTable(string xPath) : base(xPath)
        {
            _loginFormInstance = this;
        }
        public Text SexTextBox
        {
            get { return FindSingle<Ranorex.Text>(SexTextBoxXPath, _searchTime); }
        }
        public Text FirstNameTextBox
        {
            get { return FindSingle<Ranorex.Text>(FirstNameTextBoxXPath, _searchTime); }
        }
        public Text LastNameTextBox
        {
            get { return FindSingle<Ranorex.Text>(LastNameTextBoxXPath, _searchTime); }
        }
        public Text BirthdTextBox
        {
            get { return FindSingle<Ranorex.Text>(BirthTextBoxXPath, _searchTime); }
        }
        public Text AliasTextBox
        {
            get { return FindSingle<Ranorex.Text>(AliasTextBoxXPath, _searchTime); }
        }
        public Button AcceptButton
        {
            get { return FindSingle<Button>(AcceptButtonXPath, _searchTime); }
        }
        public Button YesButton
        {
            get { return FindSingle<Button>(YesButtonXPath, _searchTime); }
        }
        public Text NumberText
        {
            get { return FindSingle<Text>(NumberTextXPath, _searchTime); }
        }
        public void ConfirmYesNoRequest()
        {
            Validate.Exists(YesButton);
            YesButton.Click();
        }
        public void AddInmate(string name, string birthd, string sex)
        {
            LastNameTextBox.Click();
            Delay.Seconds(2);
            LastNameTextBox.PressKeys(name);
            LastNameTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            BirthdTextBox.Click();
            Delay.Seconds(2);
            BirthdTextBox.PressKeys(birthd);
            BirthdTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            SexTextBox.Click();
            Delay.Seconds(2);
            SexTextBox.PressKeys(sex);
            SexTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            AcceptButton.Click();
            ConfirmYesNoRequest();
            Delay.Seconds(2);
            AcceptButton.Click();
        }
        public void AddInmate(string name, string birthd, string sex, string alias)
        {
            LastNameTextBox.Click();
            Delay.Seconds(1);
            LastNameTextBox.PressKeys(name);
            LastNameTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            BirthdTextBox.Click();
            Delay.Seconds(1);
            BirthdTextBox.PressKeys(birthd);
            BirthdTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            SexTextBox.Click();
            Delay.Seconds(2);
            SexTextBox.PressKeys(sex);
            SexTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            AliasTextBox.Click();
            Delay.Seconds(2);
            AliasTextBox.PressKeys(alias);
            AliasTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            AcceptButton.Click();
            ConfirmYesNoRequest();
            Delay.Seconds(2);
            AcceptButton.Click();
        }
        public void AddInmate(string name, string birthd, string sex, out string number)
        {
            LastNameTextBox.Click();
            Delay.Seconds(1);
            LastNameTextBox.PressKeys(name);
            LastNameTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            BirthdTextBox.Click();
            Delay.Seconds(1);
            BirthdTextBox.PressKeys(birthd);
            BirthdTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            SexTextBox.Click();
            Delay.Seconds(2);
            SexTextBox.PressKeys(sex);
            SexTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            AcceptButton.Click();
            ConfirmYesNoRequest();
            NumberText.Click();
            number = NumberText.TextValue.ToString();
            Delay.Seconds(2);
            AcceptButton.Click();
        }
        public void AddInmate(string name)
        {
            LastNameTextBox.Click();
            Delay.Seconds(2);
            LastNameTextBox.PressKeys(name);
            LastNameTextBox.PressKeys("{enter}");
            Delay.Seconds(2);
            AcceptButton.Click();
            ConfirmYesNoRequest();
            Delay.Seconds(2);
            AcceptButton.Click();
        }
        public static string getPath()
        {
            return NamesFormXPath;
        }
    }
}
   

