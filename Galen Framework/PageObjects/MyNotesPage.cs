using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galen_Framework
{
    public class MyNotesPage : BasePage
    {
        string url = "http://testapp.galenframework.com/";

        By AddNoteButton = By.XPath("//button[@type='button']");
        By NoteTitle = By.XPath("//input[@placeholder='Title']");
        By Descrition = By.XPath("//textarea[@placeholder='Description']");

        public MyNotesPage OpenBrowser()
        {
            driver.Url = url;

            return this;
        }

        public MyNotesPage ClickButton()
        {
            driver.FindElement(AddNoteButton).Click();

            return this;
        }

        public MyNotesPage AddNote()
        {
            driver.FindElement(NoteTitle).SendKeys("Note - Title");
            driver.FindElement(Descrition).SendKeys("Note - Description");

            return this;
        }
    }
}
