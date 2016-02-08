using Ranorex;
using Ranorex.Core;
using System;

namespace Spillman.BusinessLibrary
{
    public partial class BookingChecklist : Form
    {
        private BookingChecklist _loginFormInstance;
        private Duration _searchTime = 250000;

        public BookingChecklist(string xPath) : base(xPath)
        {
            Validate.Exists(SpillmanBookingChecklistXPath, _searchTime);
            _loginFormInstance = this;
        }
        public Container ArrestsButton
        {
            get { return FindSingle<Container>(ArrestsButtonXPath, _searchTime); }
        }
        public Button OffensesButton
        {
            get { return FindSingle<Button>(OffensesButtonXPath, _searchTime); }
        }
        public Button ArrestTypeCodeControlButton
        {
            get { return FindSingle<Button>(ArrestTypeCodeControlButtonXPath, _searchTime); }
        }
        public Button StatuteCodeControlButton
        {
            get { return FindSingle<Button>(StatuteCodeControlButtonXPath, _searchTime); }
        }
        public Button BondCodeControlButton
        {
            get { return FindSingle<Button>(BondCodeControlButtonXPath, _searchTime); }
        }
        public Button SaveButton
        {
            get { return FindSingle<Button>(SaveButtonXPath, _searchTime); }
        }
        public Button AddButton
        {
            get { return FindSingle<Button>(AddButtonXPath, _searchTime); }
        }
        public Text InmateRecordLink
        {
            get { return FindSingle<Text>(InmateRecordLinkXPath, _searchTime); }
        }
        public Text LastNameText
        {
            get { return FindSingle<Text>(LastNameTextXPath, _searchTime); }
        }
        public void AddArrest(string arrestDefintion)
        {
            ArrestTypeCodeControlButton.Click();
            Delay.Seconds(1);
            ArrestTypeCodeControlButton.PressKeys(arrestDefintion);
            PressKeys("{enter}");
        }
        public object GetArrest()
        {
            throw new NotImplementedException();
        }
        public void SetOffence(string offenceDefintion)
        {
            StatuteCodeControlButton.Click();
            Delay.Seconds(1);
            StatuteCodeControlButton.PressKeys(offenceDefintion);
            PressKeys("{enter}");
        }
        public void SetBond(string bondDefintion)
        {
            BondCodeControlButton.Click();
            Delay.Seconds(1);
            BondCodeControlButton.PressKeys(bondDefintion);
            PressKeys("{enter}");
        }
        public void SetSentence(string sentenceDefintion)
        {
            BondCodeControlButton.Click();
            Delay.Seconds(1);
            BondCodeControlButton.PressKeys(sentenceDefintion);
            PressKeys("{enter}");
        }
        public static string getPath()
        {
            return SpillmanBookingChecklistXPath;
        }
    }
}
   

