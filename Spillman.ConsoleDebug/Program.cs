using Ranorex;
using Spillman.BusinessLibrary;
using System;
using System.Diagnostics;


namespace Spillman.ConsoleDebug
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Console.Write("Starting Spaillman...");
            //Process spillmanLauncher;
            //spillmanLauncher = new Process();
            //spillmanLauncher.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Spillman\Launcher.exe";
            //spillmanLauncher.Start();

            //SpillmanLogin loginForm = new SpillmanLogin(SpillmanLogin.getPath());
            //loginForm.Login("sds", "window");
            //loginForm.WaitUntilDisappear();

            //loginForm = new SpillmanLogin(SpillmanLogin.getPath());
            //loginForm.DbaseComboBox.SelectItem("live with NO mobile");
            //loginForm.SecondLoginButton.Click();

            //In this version of poduct there is no Message Of the Day Window
            //loginForm.MessageOfTheDayOkButton.Click();

            Toolbar toolbar = new Toolbar(Toolbar.getPath());
            toolbar.WaitUntilLoads();
            toolbar.OpenCAD();

            CADToolbar cadToolbar = new CADToolbar(CADToolbar.getPath());
            AddANewCall addANewCall = cadToolbar.AddCall();
            Console.Write(addANewCall.GetPath());
            addANewCall.WaitUntilAppear();
            //Validate.Exists(addANewCall);
            //Delay.Seconds(2);
            addANewCall.TitleText.Click();
            addANewCall.NatureField.DoubleClick();

            addANewCall.PressKeys("{down}{down}{down}{down}{down}");
            addANewCall.PressKeys("{enter}");

            Delay.Seconds(2);
            addANewCall.AdressField.PressKeys("123 s main st");
            addANewCall.AdressField.PressKeys("{enter}");
            ValidateAdress validateAdress = new ValidateAdress(ValidateAdress.getPath());
            Console.Write(validateAdress.GetPath());
            validateAdress.EnteredFieldText.Click();
            validateAdress.SelectButton.Click();
            var callNumber = addANewCall.CallNumberField.TextValue;
            Console.Write(callNumber);
            addANewCall.AcceptCallButton.Click();




            cadToolbar.Exit();

            //spillmanLauncher.Close();
        }
    }
}
