using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace loginseleniumeg2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://geotab1.arivani.com/login/");
            driver.FindElement(By.Name("username")).SendKeys("incharlottenow@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("save_btn")).Click();

            //driver.Quit();
        }
    }
}
