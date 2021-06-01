using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //launch MarsQA portal
            IWebDriver driver = new ChromeDriver(@"C:\SeleniumRepo");
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //maximise window
            driver.Manage().Window.Maximize();

            //click on Sign In button
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signIn.Click();

            //identify & enter username
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("gitabtechit@gmail.com");

            //identify & enter password
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("Keerthi19121983");

            //click Remember Me
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input")).Click();
            
            //click login
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
            
            //create TM 
            //click administra

            //edit TM

            //delete TM
        }
    }
}
