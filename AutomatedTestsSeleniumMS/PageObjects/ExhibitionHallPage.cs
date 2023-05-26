using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class ExhibitionHallPage
    {
        private IWebDriver webDriver;


        [FindsBy(How = How.CssSelector, Using = "main")]
        private IWebElement exhibtionHallsLists;
        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:7292/ExhibitionHalls");
        }
        public ExhibitionHallPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/div/main/p/a")]
        private IWebElement addExhibitionHallPage;
        public AddExhibitionHallPage GotoAddExhibitionHallPage()
        {
            addExhibitionHallPage.Click();
            return new AddExhibitionHallPage(webDriver);
        }
        public bool ExhibitionHallExists(string exhibitionHallTitle)
        {
            var elements = exhibtionHallsLists.FindElements(By.TagName("div"));
            return elements.Where(element => element.Text.Equals(exhibitionHallTitle)).Count() > 0;

        }
    }
}
