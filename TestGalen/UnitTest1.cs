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
            LoginPageObject login = new LoginPageObject();            
            login
                .OpenBrowser()
                .ClickLogin()
                .LoginValidUser("testuser@example.com", "test123");

            MyNotesPage note = new MyNotesPage();
            note
                .ClickButton()
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
