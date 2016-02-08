using Ranorex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillman.BusinessLibrary
{
    public partial class CreateInmatePrerequisites : Form
    {
        private Duration _searchTime = 50000;

        public CreateInmatePrerequisites(string xPath) : base(xPath)
        {

        }
        public Text DOBTextBox
        {
            get { return FindSingle<Text>(DOBTextBoxXPath, _searchTime); }
        }
        public ComboBox GenderComboBox
        {
            get { return FindSingle<ComboBox>(GenderComboBoxXPath, _searchTime); }
        }
        public Button SubmitButton
        {
            get { return FindSingle<Button>(SubmitButtonXPath, _searchTime); }
        }
        public void AddGender(string gender)
        {
            GenderComboBox.Click();
            GenderComboBox.PressKeys(gender);
        }
        public void AddDOB(string date)
        {
            DOBTextBox.Click();
            DOBTextBox.PressKeys(date);          
        }
        public static string getPath()
        {
            return CreateInmatePrerequisitesXPath;
        }
    }

}
