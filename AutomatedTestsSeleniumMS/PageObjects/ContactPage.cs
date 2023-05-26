using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class ContactPage
    {
        private IWebDriver webDriver;

        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:7292/Contacts/Create");
        }
        public ContactPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement inputEmail;

        [FindsBy(How = How.Id, Using = "Subject")]
        private IWebElement inputSubject;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div[1]/div/form/div[3]/input")]
        private IWebElement submitButton;
  

        public void Save(string inputEmail, string inputSubject)
        {
            this.inputEmail.Clear();
            this.inputEmail.SendKeys(inputEmail);
            this.inputSubject.Clear();
            this.inputSubject.SendKeys(inputSubject);
    
            submitButton.Click();
        }
    }
}
