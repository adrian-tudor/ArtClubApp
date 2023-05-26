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

    public class AddExhibitionHallTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserAddExhibitionHall_Creates_ExhibitionHallWithGivenDetails()
        {

            Random randomNumber = new Random();
            string exhibitionHallName = "MyHallName " + randomNumber.Next(100, 10000000);
            string exhibitionHallLocation = "MyHallLocation";
            string exhibitionHallRent = "102";

            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            ExhibitionHallPage exhibitionHallPage = new ExhibitionHallPage(webDriver);
            exhibitionHallPage.GoToPage();
            AddExhibitionHallPage addExhibitionHall = exhibitionHallPage.GotoAddExhibitionHallPage();
            addExhibitionHall.Save(exhibitionHallName,exhibitionHallLocation, exhibitionHallRent);

            Assert.IsTrue(exhibitionHallPage.ExhibitionHallExists(exhibitionHallName));

        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
