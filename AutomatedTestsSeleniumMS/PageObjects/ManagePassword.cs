using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    public class ManagePassword
    {

        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Input_OldPassword")]
        private IWebElement userOldPassword;

        [FindsBy(How = How.Id, Using = "Input_NewPassword")]
        private IWebElement userNewPassword;

        [FindsBy(How = How.Id, Using = "Input_ConfirmPassword")]
        private IWebElement userConfirmNewPassword;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div/div/div[1]/ul/li[3]/a")]
        private IWebElement updatePasswordButton;
        public ManagePassword(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ChangePassword(string oldPassword, string newPassword, string confirmPassword )
        {
            userOldPassword.Clear();
            userOldPassword.SendKeys(oldPassword);
            userNewPassword.Clear();
            userNewPassword.SendKeys(newPassword);
            userConfirmNewPassword.Clear();
            userConfirmNewPassword.SendKeys(confirmPassword);
            updatePasswordButton.Click();
        }
    }
}
