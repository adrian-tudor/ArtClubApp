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

    public class UserProfileTest
    {
        private IWebDriver webDriver;
 
        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserChangesPhoneNumberWithGivenDetails()
        {

            Random randomNumber = new Random();
            string phoneNumber = "0" + randomNumber.Next(100, 10000000);
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            ManagePage managePage = new ManagePage(webDriver);
            managePage.GoToPage();
            ManageProfilePage manageProfilePage = managePage.GotoManageProfilePage();
            manageProfilePage.Profile(phoneNumber);


        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
