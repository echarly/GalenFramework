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

        //Titles
        public By NotesTitle = By.XPath("//div[@id='my-notes-page']//h2");
        public By AddNoteTitle = By.XPath("//div[@id='ad-note-page']//h2");

        public MyNotesPage OpenBrowser()
        {
            driver.Url = url;

            return this;
        }

        public MyNotesPage ClickButton()
        {
            Click(AddNoteButton);

            return this;
        }

        public MyNotesPage AddNote()
        {
            EnterText(NoteTitle, "Note - Title");
            EnterText(NoteTitle, "Note - Description");

            return this;
        }
    }
}
