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
    }
}
