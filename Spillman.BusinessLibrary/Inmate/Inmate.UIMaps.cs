
namespace Spillman.BusinessLibrary
{
    public partial class Inmate
    {
        public static string InmateXPath = "/form[@controlname='InmateWindow']";
        public static string NameNumberTextBoxXPath = ".//element[@controlname='nameNumberLookup']/text[]";
        public const string SaveButtonXPath = ".//button[@accessiblename='Save']";
        public const string AddButtonXPath = ".//button[@accessiblename='Add']";
        public const string IdentifyButtonXPath = ".//button[@accessiblename = 'Identify']";

    }
}
