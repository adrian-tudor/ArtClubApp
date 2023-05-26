using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class ManagePage
    {
        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:7292/Identity/Account/Manage");
        }

        public ManagePage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Input_PhoneNumber")]
        private IWebElement userPhoneNumber;

        [FindsBy(How = How.Id, Using = "profile")]
        private IWebElement manageProfileButton;

        [FindsBy(How = How.Id, Using = "update-profile-button")]
        private IWebElement updateProfileButton;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement manageEmailButton;

        [FindsBy(How = How.Id, Using = "change-password")]
        private IWebElement managePasswordButton;

        [FindsBy(How = How.Id, Using = "personal-data")]
        private IWebElement managePersonalDataButton;
        public ManageProfilePage GotoManageProfilePage()
        {
            manageProfileButton.Click();
            return new ManageProfilePage(webDriver);
        }
        public ManageEmail GotoManageEmailPage()
        {
            manageEmailButton.Click();
            return new ManageEmail(webDriver);
        }
        public ManagePassword GotoManagePasswordPage()
        {
            managePasswordButton.Click();
            return new ManagePassword(webDriver);
        }
        public ManagePersonalData GotoManagePersonalDataPage()
        {
            managePersonalDataButton.Click();
            return new ManagePersonalData(webDriver);
        }

        public void Profile(string phoneNumber)
        {
            userPhoneNumber.Clear();
            userPhoneNumber.SendKeys(phoneNumber);
            updateProfileButton.Click();
        }

    }
}
