
using NUnit.Framework;
using Ranorex;
using Spillman.BusinessLibrary;
using System;
using System.Diagnostics;


namespace Spillman.Tests
{
    [SetUpFixture]
    public class MySetUpClass
    {
        private Process spillmanLauncher;
        private string version;

        [SetUp]
        public void RunBeforeTests()
        {
            //version = "6.2";
            //spillmanLauncher = new Process();
            //spillmanLauncher.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Spillman " + version + @"\Launcher.exe";
            //spillmanLauncher.Start();

            //SpillmanLogin loginForm = new SpillmanLogin(SpillmanLogin.getPath());
            //loginForm.Login("sds", "window");
            //loginForm.WaitUntilDisappear();

            //loginForm = new SpillmanLogin(SpillmanLogin.getPath());
            //loginForm.DbaseComboBox.SelectItem("live with NO mobile");
            //loginForm.SecondLoginButton.Click();
            //loginForm.MessageOfTheDayOkButton.Click();
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
            spillmanLauncher.Close();
        }
    }
    public class SmokeTests
    {
        Random rnd;
        private string inmateRecordA;
        private string inmateRecordB;
        private string inmateRecordC;
        private string inmateRecordD;
        private string inmateRecordE;
        private string inmateTempRecord;

        private Duration _searchTime = 100000;

        [SetUp]
        public void initialize()
        {
            rnd = new Random();
            inmateRecordA = "Record_" + rnd.Next(1, 100000) + "_A";
            inmateRecordB = "Record_" + rnd.Next(1, 100000) + "_B";
            inmateRecordC = "Record_" + rnd.Next(1, 100000) + "_C";
            inmateRecordD = "Record_" + rnd.Next(1, 100000) + "_D";
            inmateRecordE = "Record_" + rnd.Next(1, 100000) + "_E";
        }
     
        public void ArrestSmokeTest()
        {
           

            //•	Record E - A name record with an open booking
            //•	Record F - A name record with only closed booking records.Identify at least one record with at least one bond, offense, and arrest linked to it.Some categories should have more than one of these records linked to the booking
            //•	Record G - A name record with only closed booking records.Identify a booking to use in the test.

            //toolbar.OpenNames();
            //namesTable = new NamesTable(NamesTable.getPath());
            //namesTable.AddInmate(inmateRecord + "B","10102005","M", out TempRecordNumber);
            //namesTable.Close();

            //toolbar.OpenNames();
            //namesTable = new NamesTable(NamesTable.getPath());
            //namesTable.AddInmate(inmateRecord + "C", "10101987", "M", TempRecordNumber);
            //namesTable.Close();

            //toolbar.OpenNames();
            //NamesTable namesTable = new NamesTable(NamesTable.getPath());
            //namesTable.AddInmate(inmateRecord + "D", "10101987", "M", out TempRecordNumber);
            //namesTable.Close();

            //toolbar.OpenInmates();
            //Inmate inmate = new Inmate(Inmate.getPath());
            //inmate.AddInmates(TempRecordNumber,2);
            //inmate.Close();






            //toolbar.OpenBooking();
            //NameQuickSearch inmateNameQuickSearchForm = new NameQuickSearch(NameQuickSearch.getPath());
            //inmateNameQuickSearchForm.LastNameQuickSearchTextBox.TextValue = inmateSurname;
            //inmateNameQuickSearchForm.SearchButton.Click();
            //inmateNameQuickSearchForm.FindCell(inmateSurname).Click();
            //inmateNameQuickSearchForm.SelectNameButton.Click();

            //StartBooking startBookingWindow = new StartBooking(StartBooking.getPath());
            //startBookingWindow.StartNewButton.Click();
            //startBookingWindow.setCell("Block A Cell FJP1-1");
            //startBookingWindow.ProceedButton.Click();

            //BookingChecklist chklist = new BookingChecklist(BookingChecklist.getPath());
            //chklist.ArrestsButton.Click();
            //chklist.AddArrest("Arrested Held for Prosecution");
            //chklist.SaveButton.Click();

            //chklist.OffensesButton.Click();
            //chklist.SetOffence("00000000 - Sentenced by Circuit Judge");
            //chklist.SaveButton.Click();
            //chklist.AddButton.Click();
            //chklist.SetOffence("00000000 - Sentenced by Circuit Judge");
            //chklist.SaveButton.Click();



            //Open CHK for the record identified in setup.Click 
            //The No Arrests button.
            //Add an arrest Type and click Save.
            //chklist.AddArrest("Arrested Held for Prosecution");

            //VALIDATE: The arrest is added. 
            //chklist.OffensesButton.Click();
            //Assert.IsTrue(chklist.GetArrest().Visible);

        }
        [Test]
        public void BookingWithoutGenderSmokeTest()
        {
            //•	Record A - A new name record.Make sure DOB and Gender are not set.
            Toolbar toolbar = new Toolbar(Toolbar.getPath());
            toolbar.WaitUntilLoads();
            toolbar.OpenNames();

            NamesTable namesTable = new NamesTable(NamesTable.getPath());
            namesTable.AddInmate(inmateRecordA);
            namesTable.Close();

            // Test Step: Open Start Booking using any method. Search for and select Record A. 
            toolbar.StartBooking();

            NameQuickSearch inmateNameQuickSearch = new NameQuickSearch(NameQuickSearch.getPath());
            inmateNameQuickSearch.LastNameQuickSearchTextBox.TextValue = inmateRecordA;
            inmateNameQuickSearch.SearchButton.Click();
            inmateNameQuickSearch.FindCell(inmateRecordA).Click();
            inmateNameQuickSearch.SelectNameButton.Click();

            // VALIDATE:The information Required dialog opens asking for DOB and gender.
            CreateInmatePrerequisites createInmatePrerequisites = new CreateInmatePrerequisites(CreateInmatePrerequisites.getPath());
            Assert.That(createInmatePrerequisites.DOBTextBox.Visible);
            createInmatePrerequisites.AddGender("Male");
            createInmatePrerequisites.AddDOB("10101987");

            Assert.That(createInmatePrerequisites.SubmitButton.Visible);
            createInmatePrerequisites.SubmitButton.Click();

            // VALIDATE: The Start Booking screen is open and includes the name information. 
            StartBooking startBooking = new StartBooking(StartBooking.getPath());
            Assert.That(startBooking.LastNameTextBox.Visible);
            Assert.That(startBooking.LastNameTextBox.Enabled);
            Assert.AreEqual(startBooking.LastNameTextBox.TextValue, inmateRecordA);
            startBooking.Close();

        }

        [Test]
        public void BookingJuvenileSmokeTest()
        {
            //•	Record B - A name record where the DOB places the individual under the Module.Jail.adultAge setting (18)
            Toolbar toolbar = new Toolbar(Toolbar.getPath());
            toolbar.WaitUntilLoads();   
            toolbar.OpenNames();

            NamesTable namesTable = new NamesTable(NamesTable.getPath());
            namesTable.AddInmate(inmateRecordB,"10102005","M");
            namesTable.Close();

            //Test Step: Start a new booking for Record B. 
            toolbar.StartBooking();

            Validate.Exists(NameQuickSearch.getPath(), _searchTime);
            NameQuickSearch inmateNameQuickSearch = new NameQuickSearch(NameQuickSearch.getPath());
            inmateNameQuickSearch.LastNameQuickSearchTextBox.TextValue = inmateRecordB;
            inmateNameQuickSearch.SearchButton.Click();
            inmateNameQuickSearch.FindCell(inmateRecordB).Click();
            inmateNameQuickSearch.SelectNameButton.Click();

            StartBooking startBooking = new StartBooking(StartBooking.getPath());
            startBooking.StartNewButton.Click();
            
            //VALIDATE:The Juvenile Instructions dialog opens and shows the text you added in setup. 
            SpillmanMessageBox msgBox = new SpillmanMessageBox(SpillmanMessageBox.getPath());
            Assert.IsTrue(msgBox.Visible);
            Assert.IsTrue(msgBox.HasText("This person is a juvenile"));

            msgBox.Close();
            startBooking.Close();
        }

        [Test]
        public void NoNameBookingSmokeTest()
        {
            //•	Record B - A name record where the DOB places the individual under the Module.Jail.adultAge setting (18)
            Toolbar toolbar = new Toolbar(Toolbar.getPath());
            toolbar.WaitUntilLoads();
            toolbar.OpenNames();

            NamesTable namesTable = new NamesTable(NamesTable.getPath());
            namesTable.AddInmate(inmateRecordA);
            namesTable.Close();

            //Test Step: Start a no-name booking. 
            toolbar.NoNameBooking();
            NoNameBooking startBooking = new NoNameBooking(NoNameBooking.getPath());
            startBooking.LocationTextBox.Click(); 
            startBooking.LocationTextBox.PressKeys("Block A Cell FJP1-1");
            startBooking.LocationTextBox.PressKeys("{enter}");
            startBooking.ProceedButton.Click();

            Validate.Exists(BookingChecklist.getPath(), _searchTime);
            BookingChecklist bookingChecklist = new BookingChecklist(BookingChecklist.getPath());
            bookingChecklist.InmateRecordLink.Click();

            Inmate inmate = new Inmate(Inmate.getPath());
            inmate.IdentifyButton.Click();

            NameQuickSearch inmateNameQuickSearch = new NameQuickSearch(NameQuickSearch.getPath());
            inmateNameQuickSearch.LastNameQuickSearchTextBox.TextValue = inmateRecordA;
            inmateNameQuickSearch.SearchButton.Click();
            inmateNameQuickSearch.FindCell(inmateRecordA).Click();
            inmateNameQuickSearch.SelectNameButton.Click();

            bookingChecklist.Activate();

            //VALIDATE:The Juvenile Instructions dialog opens and shows the text you added in setup. 
            Assert.AreEqual(bookingChecklist.LastNameText.TextValue, inmateRecordA);
            bookingChecklist.Close();
            inmate.Close();
        }

        [Test]
        public void AliasBookingSmokeTest()
        {
            //•	Record C - An alias record - make sure the real name record does not have an open booking.
            Toolbar toolbar = new Toolbar(Toolbar.getPath());
            toolbar.WaitUntilLoads();
            toolbar.OpenNames();

            NamesTable namesTable = new NamesTable(NamesTable.getPath());
            namesTable.AddInmate(inmateRecordB, "10101987", "M", out inmateTempRecord);
            namesTable.Close();
            
            toolbar.OpenNames();
            namesTable = new NamesTable(NamesTable.getPath());
            namesTable.AddInmate(inmateRecordC, "10101987", "M", inmateTempRecord);
            namesTable.Close();

            toolbar.StartBooking();

            NameQuickSearch inmateNameQuickSearch = new NameQuickSearch(NameQuickSearch.getPath());
            inmateNameQuickSearch.LastNameQuickSearchTextBox.TextValue = inmateRecordC;
            inmateNameQuickSearch.SearchButton.Click();
            inmateNameQuickSearch.FindCell(inmateRecordC).Click();
            inmateNameQuickSearch.SelectNameButton.Click();

        }

        [Test]
        public void TwoInmatesBookingSmokeTest()
        {
            //•	Record D - A name record with two inmate records. (Use the Add option on the inmate screen) neither inmate ID should have an open booking.
            Toolbar toolbar = new Toolbar(Toolbar.getPath());
            toolbar.WaitUntilLoads();
            toolbar.OpenNames();

            NamesTable namesTable = new NamesTable(NamesTable.getPath());
            namesTable.AddInmate(inmateRecordD, "10101987", "M", out inmateTempRecord);
            namesTable.Close();

            toolbar.OpenInmates();

            Inmate inmate = new Inmate(Inmate.getPath());
            inmate.AddInmate(inmateTempRecord);
            inmate.AddInmate(inmateTempRecord);
            inmate.Close();

            toolbar.StartBooking();
            NameQuickSearch inmateNameQuickSearch = new NameQuickSearch(NameQuickSearch.getPath());
            inmateNameQuickSearch.LastNameQuickSearchTextBox.TextValue = inmateRecordD;
            inmateNameQuickSearch.SearchButton.Click();
            inmateNameQuickSearch.FindCell(inmateRecordD).Click();
            inmateNameQuickSearch.SelectNameButton.Click();

            InmateSelector inmateSelector = new InmateSelector(InmateSelector.getPath());
            inmateSelector.SelectInmateButton.Click();

            StartBooking startBooking = new StartBooking(StartBooking.getPath());
            Assert.AreEqual(startBooking.LastNameTextBox.TextValue, inmateRecordD);
            startBooking.Close();

        }

        [Test]
        public void OpenedBookingSmokeTest()
        {
            //•	Record E - A name record with an open booking
            Toolbar toolbar = new Toolbar(Toolbar.getPath());
            toolbar.WaitUntilLoads();
            toolbar.OpenNames();

            NamesTable namesTable = new NamesTable(NamesTable.getPath());
            namesTable.AddInmate(inmateRecordE, "10101987", "M");
            namesTable.Close();

            toolbar.StartBooking();
            NameQuickSearch inmateNameQuickSearch = new NameQuickSearch(NameQuickSearch.getPath());
            inmateNameQuickSearch.LastNameQuickSearchTextBox.TextValue = inmateRecordE;
            inmateNameQuickSearch.SearchButton.Click();
            inmateNameQuickSearch.FindCell(inmateRecordE).Click();
            inmateNameQuickSearch.SelectNameButton.Click();
        
            StartBooking startBooking = new StartBooking(StartBooking.getPath());
            startBooking.StartNewButton.Click();
            startBooking.LocationTextBox.PressKeys("Block A Cell FP1-1");
            startBooking.LocationTextBox.PressKeys("{enter}");
            startBooking.ProceedButton.Click();

            Validate.Exists(BookingChecklist.getPath(), _searchTime);
            BookingChecklist bookingChecklist = new BookingChecklist(BookingChecklist.getPath());
            Assert.AreEqual(bookingChecklist.LastNameText.TextValue, inmateRecordE);

            toolbar.StartBooking();

            inmateNameQuickSearch = new NameQuickSearch(NameQuickSearch.getPath());
            inmateNameQuickSearch.LastNameQuickSearchTextBox.TextValue = inmateRecordE;
            inmateNameQuickSearch.SearchButton.Click();
            inmateNameQuickSearch.FindCell(inmateRecordE).Click();
            inmateNameQuickSearch.SelectNameButton.Click();

            //VALIDATE:
            SpillmanMessageBox msgBox = new SpillmanMessageBox(SpillmanMessageBox.getPath());
            Assert.IsTrue(msgBox.Visible);

            msgBox.ViewButton.Click();

            //VALIDATE:The Booking screen opens to the booking record for Record E. 
            Validate.Exists(Booking.getPath(), _searchTime);
            Booking booking = new Booking(Booking.getPath());

            booking.LastNameText.Click();
            Assert.That(booking.LastNameText.Visible);
            Assert.That(booking.LastNameText.Enabled);
            Assert.AreEqual(booking.LastNameText.TextValue, inmateRecordE);


        }

        [TearDown]
        public void teardown()
        {
         
        }
    }
}
