using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galen_Framework
{
    public class BasePage
    {
        public static IWebDriver driver;

        public void InitializeDriver()
        {
            driver = new ChromeDriver("C:\\Chromedriver\\");
        }

        public void closeBrowser()
        {
            driver.Close();
        }

        /// <summary>
        /// Obtain Title of a Page.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public string ObtainTitle(By element)
        {
            string Title = driver.FindElement(element).Text;

            return Title;
        }

        public void Click(By element)
        {
            driver.FindElement(element).Click();
        }

        public void EnterText(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }
    }
}
