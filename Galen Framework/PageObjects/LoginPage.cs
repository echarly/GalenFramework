using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galen_Framework
{
    public class LoginPageObject : BasePage
    {
        string url = "http://testapp.galenframework.com/";

        By LoginButton = By.XPath("//button[@type='button']");
        By txtUserName = By.Name("login.username");
        By txtPassword = By.Name("login.password");
        By btnLoginPage = By.XPath("//button[@type='button']");
        By btnCancel = By.CssSelector(".button-cancel");

        public LoginPageObject OpenBrowser()
        {
            driver.Url = url;

            return this;
        }

        public LoginPageObject ClickLogin()
        {
            driver.FindElement(LoginButton).Click();
            return this;
        }

        public LoginPageObject LoginValidUser(string username, string password)
        {
            driver.FindElement(txtUserName).SendKeys(username);
            driver.FindElement(txtPassword).SendKeys(password);
            driver.FindElement(btnLoginPage).Click();

            return this;
        }
    }
}
