using AutomatedTestsSeleniumMS.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutomatedTestsSeleniumMS
{
    public class UserChangePasswordTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserChangesPasswordWithGivenDetails()
        {
            string oldPassword = "Adrian1#";
            string newPassword = "Adrian1#";
            string confirmPassword = "Adrian1#";
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            ManagePage managePage = new ManagePage(webDriver);
            managePage.GoToPage();
            ManagePassword managePasswordPage = managePage.GotoManagePasswordPage();
            managePasswordPage.ChangePassword(oldPassword, newPassword, confirmPassword);


        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }

    }
}
