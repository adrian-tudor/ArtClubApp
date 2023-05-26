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
    public class UserDownloadPersonalDataTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserDownloadsPersonalData()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            ManagePage managePage = new ManagePage(webDriver);
            managePage.GoToPage();
            ManagePersonalData managePersonalData = managePage.GotoManagePersonalDataPage();
            managePersonalData.DownloadPersonalData();


        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }

    }
}
