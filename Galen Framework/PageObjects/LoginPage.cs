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

        //Text
        public By LoginTitle = By.XPath("//div[@class='dialog-panel']//h2");
        public By welcomeTitle = By.XPath("//div[@class='jumbotron']//h1");

        public LoginPageObject OpenBrowser()
        {
            driver.Url = url;

            return this;
        }

        public LoginPageObject ClickLogin()
        {
            Click(LoginButton);
            return this;
        }

        public LoginPageObject LoginValidUser(string username, string password)
        {
            EnterText(txtUserName, username);
            EnterText(txtPassword, password);
            Click(btnLoginPage);

            return this;
        }

    }
}