using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    //*[@id="download-data"]/button
    public class ManagePersonalData
    {

        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "/html/body/div/main/div/div/div[2]/div/div/form/button")]
        private IWebElement userDownloadDataButton;

       
        public ManagePersonalData(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void DownloadPersonalData()
        {
            userDownloadDataButton.Click();
        }
    }
}
