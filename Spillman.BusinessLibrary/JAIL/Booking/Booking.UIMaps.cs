
using System;

namespace Spillman.BusinessLibrary
{
    public partial class Booking
    {
        public static string BookingXPath = "/form[@controlname = 'BookingChecklistMainMDI']";
        public static string LastNameTextXPath = ".//element[@controlname='inmateControlLastNameTextBox']/text[]";
    }
}
