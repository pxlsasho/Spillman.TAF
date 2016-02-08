using Ranorex;
using Ranorex.Core;
using SoftServe.TAF.BaseControls;

namespace Spillman.BusinessLibrary
{
    public partial class InmateSelector : BaseForm
    {
        private InmateSelector _toolbarInstance;
        private Duration _searchTime = 150000;

        public InmateSelector(string xPath) : base(xPath)
        {
            Validate.Exists(getPath(), _searchTime);
            _toolbarInstance = this;
        }
        public Cell FindCell(string name)
        {
            return FindSingle<Cell>(".//cell[@accessiblename = 'Last' and @accessiblevalue = '" + name + "']", _searchTime);
        }
        public Button SelectInmateButton
        {
            get { return FindSingle<Button>(SelectInmateButtonXPath, _searchTime); }
        }
        public static string getPath()
        {
            return InmateSelectorXPath;
        }
    }
}
   

