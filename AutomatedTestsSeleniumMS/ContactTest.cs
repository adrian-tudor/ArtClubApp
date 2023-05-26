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

    public class ContactTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserContactTestWithGivenDetails()
        {

            Random randomNumber = new Random();
            string inputEmail = "aa " + randomNumber.Next(100, 10000000) + "@mail.com";
            string inputSubject = "There are no problems whit the application ";
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            ContactPage contactPage = new ContactPage(webDriver);
            contactPage.GoToPage();
            contactPage.Save(inputEmail, inputSubject);


        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
