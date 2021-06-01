//using MarsQA_Specflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_Specflow.Featurefiles
{
    [Binding]
    public class ProfilePageSteps : IDisposable
    {
        private readonly ProfilePage profilePage;
        private readonly LoginPage loginPage;

        private readonly IWebDriver driver;

        public ProfilePageSteps()
        {
            driver = new ChromeDriver(@"C:\Users\Sudharsan\source\repos");
            profilePage = new ProfilePage(driver);
            loginPage = new LoginPage(driver);
        }


        [Given(@"I am logged in at ""(.*)"" as user ""(.*)"" with password ""(.*)""")]
        public void GivenIAmLoggedInAtAsUserWithPassword(string url, string email, string password)
        {
            loginPage.QuickLogin(url, email, password);
            Console.WriteLine("I am in the login page at " + url);
        }

        [Given(@"I am at the Profile page")]
        public void GivenIAmAtTheProfilePage()
        {
            Assert.IsTrue(profilePage.IsValidProfilePage());
            Console.WriteLine("I am at the Profilepage");
        }

        [When(@"I click on Add New button")]
        public void WhenIClickOnAddNewButton()
        {
            profilePage.ClickOnAddNewButton();
            Console.WriteLine("I click on Add New button");
        }

        [When(@"I Add (.*) and (.*) on Languages tab")]
        public void WhenIAddLanguage(string language, string languageLevel)
        {
            profilePage.AddLanguage(language, languageLevel);

            Console.WriteLine("I Add Language");
        }

        [When(@"I Add (.*) and (.*) on Skills tab")]
        public void WhenIAddAndOnSkillsTab(string skill, string skillLevel)
        {
            profilePage.AddSkill(skill, skillLevel);

            Console.WriteLine("I Add Skill");
        }


        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {

            profilePage.ClickOnAddButton();
            Console.WriteLine("I click on Add button");
        }



        [Then(@"Validate that Language is added")]
        public void ThenValidateThatLanguageIsAdded()
        {
            profilePage.ValidateLanguageIsAdded();
            Console.WriteLine("Validate that Language is added");
        }

        [Then(@"Validate that Skill is added")]
        public void ThenValidateThatSkillIsAdded()
        {

            Console.WriteLine("Validate that Skill is added");
        }

        [Given(@"I click on Skills tab")]
        public void GivenIClickOnSkillsTab()
        {
            profilePage.ClickOnSkillTab();
            Console.WriteLine("I click on Skills tab");
        }


        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
