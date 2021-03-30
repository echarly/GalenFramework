using System;
using Galen_Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TestGalen
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void TestInitialize()
        { 
            BasePage basePage = new BasePage();
            basePage.InitializeDriver();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Login
            LoginPageObject login = new LoginPageObject();
            BasePage basePage = new BasePage();

            login
                .OpenBrowser();
            Assert.AreEqual(basePage.ObtainTitle(login.welcomeTitle), "Welcome to our test page!");

            login
                .ClickLogin();

            Assert.AreEqual(basePage.ObtainTitle(login.LoginTitle), "Login");

            login
                .LoginValidUser("testuser@example.com", "test123");

            //Notes
            MyNotesPage note = new MyNotesPage();

            Assert.AreEqual(basePage.ObtainTitle(note.NotesTitle), "My Notes");
            note
                .ClickButton();

            Assert.AreEqual(basePage.ObtainTitle(note.AddNoteTitle), "Add note");

            note
                .AddNote()
                .ClickButton();
        }

        [TestCleanup]
        public void CleanUp()
        {
            BasePage basePage = new BasePage();
            basePage.closeBrowser();
        }
    }
}
