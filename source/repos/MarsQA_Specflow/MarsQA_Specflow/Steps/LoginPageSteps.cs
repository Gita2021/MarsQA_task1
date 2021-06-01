//using MarsQA_Specflow.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_Specflow.Featurefiles
{
    [Binding]
    public class LoginPageSteps : IDisposable
    {

        private readonly LoginPage loginPage;
        private readonly IWebDriver driver;

        public LoginPageSteps()
        {
            driver = new ChromeDriver(@"C:\Users\Sudharsan\source\repos");
            loginPage = new LoginPage(driver);
        }

        [Given(@"I am in the login page at ""(.*)""")]
        public void GivenIAmInTheLoginPage(string loginPageUrl)
        {
            loginPage.Navigate(loginPageUrl);
            Console.WriteLine("I am at the loginpage");
        }

        [When(@"I click the Sign In button")]
        public void WhenIClickTheSignInButton()
        {
            loginPage.ClickSignInButton();
            Console.WriteLine("I click the Sign In button");
        }

        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterEmailAndPassword(string email, string password)
        {
            loginPage.AddCredentials(email, password);
            Console.WriteLine("I enter emailaddress and password");
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
            Console.WriteLine("I click the Login button ");
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            loginPage.ValidateLogin();
            Console.WriteLine("I should be logged in successfully");
        }

        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
