using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class RegisterPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Input_Email")]
        private IWebElement userNameTextBox;

        [FindsBy(How = How.Id, Using = "Input_Password")]
        private IWebElement passwordTextBox;

        [FindsBy(How = How.Id, Using = "Input_ConfirmPassword")]
        private IWebElement passwordConfirmTextBox;

        [FindsBy(How = How.Id, Using = "registerSubmit")]
        private IWebElement registerButton;

        public RegisterPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Register(string userName, string password)
        {
            userNameTextBox.Clear();
            userNameTextBox.SendKeys(userName);
            passwordTextBox.Clear();
            passwordTextBox.SendKeys(password);
            passwordConfirmTextBox.Clear();
            passwordConfirmTextBox.SendKeys(password);
            registerButton.Click();
        }

    }
}
