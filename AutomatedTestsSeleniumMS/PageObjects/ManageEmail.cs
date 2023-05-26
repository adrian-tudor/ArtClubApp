using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    public class ManageEmail
    {

        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Input_NewEmail")]
        private IWebElement userNewEmail;

        [FindsBy(How = How.Id, Using = "change-email-button")]
        private IWebElement updateEmailButton;

        public ManageEmail(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ChangeEmail(string newEmail)
        {
            userNewEmail.Clear();
            userNewEmail.SendKeys(newEmail);
            updateEmailButton.Click();
        }
    }
}
