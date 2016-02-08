using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;

namespace Spillman.BusinessLibrary
{
    public partial class SpillmanLogin : BaseForm
    {
        private SpillmanLogin _loginFormInstance;
        private Duration _searchTime = 50000;

        public SpillmanLogin(string xPath) : base(xPath)
        {
            _loginFormInstance = this;
        }

        public Button DetailsButton
        {
            get { return FindSingle<Ranorex.Button>(DetailsButtonXPath, _searchTime); }
        }

        public Button LoginButton
        {
            get { return FindSingle<Ranorex.Button>(LoginXPath, _searchTime); }
        }

        public Button SecondLoginButton
        {
            get { return FindSingle<Ranorex.Button>(SecondLoginXPath, _searchTime); }
        }

        public Text UserNameTextBox
        {
            get { return FindSingle<Ranorex.Text>(UserNameXPath, _searchTime); }
        }

        public Text PasswordTextBox
        {
            get { return FindSingle<Ranorex.Text>(PasswordXPath, _searchTime); }
        }

        public dbaseComboBox DbaseComboBox
        {
            get { return FindSingle<dbaseComboBox>(dbaseXPath, _searchTime); }
        }

        public ListItem GetListItem(string item)
        {
            return FindSingle<ListItem>(".//listitem[@text='" + item + "']", _searchTime);

        }

        public Button MessageOfTheDayOkButton
        {
            get { return FindSingle<Button>(MessageOfTheDayOkButtonXPath, _searchTime); }
        }

        public class dbaseComboBox : ComboBox
        {
            public dbaseComboBox(Element element) : base(element)
            {
            }

            public void SelectItem(string item)
            {
                Click();
                SpillmanLogin loginForm = new SpillmanLogin(LoginFormXPath);
                ListItem selectListItem = loginForm.GetListItem(item);
                selectListItem.Focus();
                selectListItem.Click();
            }

            public static implicit operator dbaseComboBox(string xPath)
            {
                return new dbaseComboBox(xPath);
            }
        }

        public void Login(string login, string password)
        {
            Activate();
            DetailsButton.Click();
            UserNameTextBox.TextValue = login;
            PasswordTextBox.Click();
            PasswordTextBox.PressKeys(password);
            LoginButton.Click();
        }
        public static string getPath()
        {
            return LoginFormXPath;
        }
    }
}
   

