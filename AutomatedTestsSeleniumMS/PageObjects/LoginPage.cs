﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class LoginPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Input_Email")]
        private IWebElement userNameTextBox;

        [FindsBy(How = How.Id, Using = "Input_Password")]
        private IWebElement passwordTextBox;

        [FindsBy(How = How.Id, Using = "login-submit")]
        private IWebElement loginButton;

        [FindsBy(How = How.Id, Using = "forgot-password")]
        private IWebElement forgotpasswordButton;
        public LoginPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Login(string userName, string password)
        {
            userNameTextBox.Clear();
            userNameTextBox.SendKeys(userName);
            passwordTextBox.Clear();
            passwordTextBox.SendKeys(password);
            loginButton.Click();
        }

        public void ForgotPassword()
        {
           forgotpasswordButton.Click();
        }

    }
}
