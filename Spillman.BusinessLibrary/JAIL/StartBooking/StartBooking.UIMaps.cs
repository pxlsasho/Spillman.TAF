
namespace Spillman.BusinessLibrary
{
    public partial class StartBooking
    {
        public static string SpillmanStartBookingXPath = "/form[@controlname = 'StartBookingWindow']";
        public static string StartNewButtonXPath = ".//button[@accessiblename = 'Start New']";
        public static string ProceedButtonXPath = ".//button[@accessiblename = 'Proceed']";
        public static string DOBTextBoxXPath = ".//text[@accessiblename~'^inmateInfoControlDOBTimeD']";
        public static string LastNameTextBoxXPath = ".//text[@accessiblename~'^inmateInfoControlLastName' and @accessiblerole='Text']";
        public static string LocationTextBoxXPath = ".//button[@accessiblename='locationComboBox1']";
    }
}
