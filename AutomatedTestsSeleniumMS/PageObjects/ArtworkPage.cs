using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class ArtworkPage
    {
        private IWebDriver webDriver;


        [FindsBy(How = How.CssSelector, Using = "main")]
        private IWebElement artworksLists;
        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:7292/Artworks");
        }
        public ArtworkPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/div/main/p/a")]
        private IWebElement addArtworkButton;
        public AddArtworkPage GotoAddArtworkPage()
        {
            addArtworkButton.Click();
            return new AddArtworkPage(webDriver);
        }
        public bool ArtworkExists(string artworkTitle)
        {
            var elements = artworksLists.FindElements(By.TagName("div"));
            return elements.Where(element => element.Text.Equals(artworkTitle)).Count() > 0;

        }
    }
}
