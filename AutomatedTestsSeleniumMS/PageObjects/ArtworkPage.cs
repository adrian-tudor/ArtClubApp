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

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/table/tbody/tr[1]/td[5]/a[1]")]
        private IWebElement editArtworkButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/table/tbody/tr[1]/td[4]/a[2]")]
        private IWebElement detailsArtworkButton;
        public AddArtworkPage GotoAddArtworkPage()
        {
            addArtworkButton.Click();
            return new AddArtworkPage(webDriver);
        }

        public EditArtworkPage GotoEditArtworkPage()
        {
            editArtworkButton.Click();
            return new EditArtworkPage(webDriver);
        }

        public ArtworkPageDetails GotoArtworkDetailsPage()
        {
            detailsArtworkButton.Click();
            return new ArtworkPageDetails(webDriver);
        }

        public bool ArtworkExists(string artworkTitle)
        {
            var elements = artworksLists.FindElements(By.TagName("div"));
            return elements.Where(element => element.Text.Equals(artworkTitle)).Count() > 0;

        }
    }
}
