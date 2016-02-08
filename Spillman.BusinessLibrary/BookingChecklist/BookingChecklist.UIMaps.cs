
using System;

namespace Spillman.BusinessLibrary
{
    public partial class BookingChecklist
    {
        public static string SpillmanBookingChecklistXPath = "/form[@controlname = 'BookingChecklistMainMDI']";
        public static string ArrestsButtonXPath = ".//container[@controlname='arrestsButton']";
        public static string ArrestTypeCodeControlButtonXPath = ".//button[@accessiblename = 'arrestTypeCodeControl']";
        public static string SaveButtonXPath = ".//button[@accessiblename='Save']";
        public static string AddButtonXPath = ".//button[@accessiblename='Add']";
        public static string OffensesButtonXPath = ".//container[@controlname='offensesButton']/?/?/button[]";
        public static string StatuteCodeControlButtonXPath = ".//button[@accessiblename = 'statuteCodeControl']";
        public static string BondCodeControlButtonXPath = ".//button[@accessiblename = 'bondCodeControl']";
        public static string SentenceCodeControlButtonXPath = ".//button[@accessiblename = 'sentenceCodeControl']";
        public static string InmateRecordLinkXPath = ".//element[@controlname='inmateRecord']//text[@accessiblename='Text area']";
        public static string LastNameTextXPath = ".//element[@controlname = 'inmateControlLastNameTextBox']/text[@controltypename = 'EmbeddableTextBoxWithUIPermissions']";
    }
}
