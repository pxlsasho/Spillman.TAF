﻿
using System;

namespace Spillman.BusinessLibrary
{
    public partial class ValidateAdress
    {
        public static string ValidateAdressXPath = "/form[@title='Validate Address' and @processname='javaw' and @class='SunAwtDialog']";
        public static string SelectButtonXPath = ".//button[@name='selectButton']";
        public static string EnteredFieldXPath = ".//text[@name = 'enteredField']";
    }
}
