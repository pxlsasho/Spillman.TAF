
using System;

namespace Spillman.BusinessLibrary
{
    public partial class AddANewCall
    {
        public static string AddANewCallXPath = "/form[@title=' ' and @processname='javaw' and @class='SunAwtDialog']";
        public static string TitleTextXPath = "menubar[@name = 'menuBar']/?/?/container[@name = 'titlePanel']/?/?/text[@name = 'middleText' and @caption = 'Add A New Call']";
        public static string AbandonedVehicleListItemXPath = "//list[@type='JList']/listitem[4]";
        public static string AdressFieldXPath = "//container[@name = 'xcs_pane']/container[@name = 'viewport']//text[@name='edit_field']";
        public static string AcceptAdressButtonXPath = ".//container[@type='JPanel']/?/?/button[@text='Accept']";
        public static string AcceptCallButtonXPath = "//container[@name='mainPanel']/container[@name='modePanel']/?/?/button[@name='accept']";
        public static string NatureFieldXPath = ".//container[@name = 'xcs_pane']/container[@name = 'viewport']//text[@name='edit_field']";
        public static string CallNumberFieldXPath = "//text[@name='sycad.callnum']";
    }
}
