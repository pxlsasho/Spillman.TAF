using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Spillman.BusinessLibrary;
using Ranorex;

namespace Spillman.TAF
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize()]
        public void TestSetUp()
        {
            Console.Write("Aloha Spillman!!");
            Process spillmanLauncher = new Process();
            spillmanLauncher.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Spillman\Launcher.exe"; ;
            spillmanLauncher.StartInfo.Arguments = "";
            spillmanLauncher.Start();
            Form d = new Form("d");
            
        }
        [TestMethod]
        public void TestMethod1()
        {
            SpillmanLogin spillmanLoginForm = new SpillmanLogin(SpillmanLogin.LoginFormXPath);
        }
    }
}
