﻿using AutomatedTestsSeleniumMS.PageObjects;
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

    public class PassLoginTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserLogin_WithGivenDataReturnsTrue()
        {

            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");
        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
