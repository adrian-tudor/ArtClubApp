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
    public class AddEventTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserAddEvent_Creates_EventWithGivenDetails()
        {

            Random randomNumber = new Random();
            string eventName = "MyEventName " + randomNumber.Next(100, 10000000);
            string eventLocation = "MyEventLocation ";
            string eventTime = "2222222222222 ";
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            EventPage eventPage = new EventPage(webDriver);
            eventPage.GotoAddEventPage();
            AddEventPage addEventPage = eventPage.GotoAddEventPage();
            addEventPage.Save(eventName, eventLocation, eventTime);

            Assert.IsTrue(eventPage.EventExists(eventName));

        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
