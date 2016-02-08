using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;

namespace Spillman.BusinessLibrary
{
    public partial class NameQuickSearch : BaseForm
    {
        private NameQuickSearch _toolbarInstance;
        private Duration _searchTime = 1000000;

        public NameQuickSearch(string xPath) : base(xPath)
        {
            Validate.Exists(getPath(), _searchTime);
            _toolbarInstance = this;
        }
        public Text LastNameQuickSearchTextBox
        {
            get { return FindSingle<Text>(LastNameQuickSearchTextBoxXPath, _searchTime); }
        }
        public Button SearchButton
        {
            get { return FindSingle<Button>(SearchButtonXPath, _searchTime); }
        }
        public Button SelectNameButton
        {
            get { return FindSingle<Button>(SelectNameButtonXPath, _searchTime); }
        }
        public Cell FindCell(string name)
        {
            return FindSingle<Cell>(".//cell[@accessiblename = 'Last' and @accessiblevalue = '" + name + "']", _searchTime);
        }
        public static string getPath()
        {
            return SpillmanNameQuickSearchFormXPath;
        }
    }
} 


