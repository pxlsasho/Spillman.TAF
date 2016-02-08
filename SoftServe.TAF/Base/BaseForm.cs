using Ranorex;

namespace SoftServe.TAF.BaseControls
{
    public class BaseForm : Form
    {
        public BaseForm(string xPath) : base(xPath)
        {
            Activate();
        }
        public void WaitUntilDisappear()
        {
            while (Visible)
            {
                Delay.Seconds(1);
            }
        }
        public void WaitUntilAppear()
        {
            while (!Visible)
            {
                Delay.Seconds(1);
            }
        }
    }
}
