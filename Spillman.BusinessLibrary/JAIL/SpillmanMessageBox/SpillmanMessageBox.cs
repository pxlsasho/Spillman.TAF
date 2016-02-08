using Ranorex;
using Ranorex.Core;

namespace Spillman.BusinessLibrary
{
    public partial class SpillmanMessageBox : Form
    {
        private Duration _searchTime = 50000;

        public SpillmanMessageBox(string xPath) : base(xPath)
        {
            Validate.Exists(getPath(), _searchTime);
        }
        public bool HasText(string text)
        {
            if (FindSingle<Text>(".//text[@accessiblename~'^" + text + "']").Visible)
                return true;
            else
                return false;
        }
        public Button ViewButton
        {
            get { return FindSingle<Button>(ViewButtonXPath, _searchTime); }
        }
        public Button OkButton
        {
            get { return FindSingle<Button>(ViewButtonXPath, _searchTime); }
        }

        public static string getPath()
        {
            return SpillmanMessageBoxXPath;
        }
    }
}
   

