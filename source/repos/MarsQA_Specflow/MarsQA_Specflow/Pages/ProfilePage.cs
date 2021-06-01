using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_Specflow
{
    class ProfilePage
    {
        private readonly IWebDriver driver;
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnAddNewButton()
        {
            Thread.Sleep(7000);
            IWebElement addNew = driver.FindElement(By.XPath("//*[text()='Add New']"));

            addNew.Click();
        }

        public void AddLanguage(String language, String level)
        {
            Thread.Sleep(5000);
            IWebElement addLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguage.SendKeys(language);

            var languageLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            //create selectelement object
            var selectElement = new SelectElement(languageLevelDropdown);

            selectElement.SelectByValue(level);
        }

        public void AddSkill(String Skill, String level)
        {
            Thread.Sleep(3000);

            IWebElement addskill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addskill.SendKeys(Skill);
            Thread.Sleep(5000);
            var skillLevelDropDown = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            //create selectelement object
            var selectElement = new SelectElement(skillLevelDropDown);

            selectElement.SelectByValue(level);

        }

        public void ClickOnSkillTab()
        {
            Thread.Sleep(3000);
            IWebElement skillstab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();
        }
        public void ClickOnAddButton()
        {
            Thread.Sleep(3000);
            IWebElement add = driver.FindElement(By.XPath("//input[@value='Add']"));
            add.Click();
        }

        public bool IsValidProfilePage()
        {
            Thread.Sleep(5000);
            IWebElement shareskill = driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
            return shareskill.Text == "Share Skill";
        }

        public bool ValidateLanguageIsAdded()
        {
            IWebElement Language = driver.FindElement(By.XPath("//th[contains(text(),'Language')]"));
            return Language.Text == "Spanish";

        }
        public bool ValidateSkillIsAdded()
        {
            Thread.Sleep(5000);
            IWebElement Skills = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            return Skills.Text == "C";

        }


    }
}
