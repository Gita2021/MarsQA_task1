using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA_Specflow
{
    class LoginPage
    {
        private readonly IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickSignInButton()
        {
            IWebElement signInButton = driver.FindElement(By.XPath("//a[@class='item'][text()='Sign In']"));
            signInButton.Click();
        }

        public void AddCredentials(string email, string password)
        {
            Thread.Sleep(2000);
            IWebElement emailElement = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
            emailElement.SendKeys(email);
            IWebElement passwordElement = driver.FindElement(By.XPath("//INPUT[@type='password']"));
            passwordElement.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
            loginButton.Click();
        }

        public bool ValidateLogin()
        {
            Thread.Sleep(4000);
            IWebElement marsLogo = driver.FindElement(By.XPath("//a[contains(text(),'Mars Logo')]"));
            return marsLogo.Text == "Mars Logo";
        }

        public void QuickLogin(String url, String email, String password)
        {
            Navigate(url);
            ClickSignInButton();
            AddCredentials(email, password);
            ClickLoginButton();
        }


    }
}
