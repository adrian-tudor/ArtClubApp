using AutomatedTestsSeleniumMS.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS
{
    [TestClass]

    public class RegisterTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserRegister_WithGivenData()
        {
            Random randomNumber = new Random();
            string userName = "User" + randomNumber.Next(100, 10000000) + "@email.com";
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            RegisterPage registerPage = homePage.GoToRegisterPage();
            registerPage.Register(userName, "Adrian1#");
        }


        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
