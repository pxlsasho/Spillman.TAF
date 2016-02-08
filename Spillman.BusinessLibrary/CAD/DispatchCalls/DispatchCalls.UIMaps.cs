
using System;

namespace Spillman.BusinessLibrary
{
    public partial class DispatchCalls
    {
        public static string DispatchCallsXPath = "/form[@title='Validate Address' and @processname='javaw' and @class='SunAwtDialog']";
        public static string SelectButtonXPath = ".//button[@name='selectButton']";
        public static string EnteredFieldXPath = ".//text[@name = 'enteredField']";
    }
}
