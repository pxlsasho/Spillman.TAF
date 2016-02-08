
namespace Spillman.BusinessLibrary
{
    public partial class NamesTable
    {
        public static string NamesFormXPath = "/form[@title = 'nmmain']";
        public static string FirstNameTextBoxXPath = ".//text[@name = 'nmmain.first']";
        public static string LastNameTextBoxXPath = ".//text[@name = 'nmmain.last']";
        public static string BirthTextBoxXPath = ".//text[@name = 'nmmain.birthd']";
        public static string SexTextBoxXPath = ".//text[@name = 'nmmain.sex']";
        public static string AliasTextBoxXPath = ".//text[@name='nmmain.aka']";
        public const string AcceptButtonXPath = ".//button[@name='accept']";
        public const string YesButtonXPath = "/form[@title ='Yes/No Request']/?/?/button[@name='Yes']";
        public const string NumberTextXPath = ".//text[@name='nmmain.number']";
        
    }
}
