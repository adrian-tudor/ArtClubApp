using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class EditArtworkPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Title")]
        private IWebElement artworkTitle;

        [FindsBy(How = How.Id, Using = "Genre")]
        private IWebElement artworkGenre;

        [FindsBy(How = How.Id, Using = "Author")]
        private IWebElement artworkAuthor;

        [FindsBy(How = How.Id, Using = "Rent")]
        private IWebElement artworkRent;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div[1]/div/form/div[5]/input")]
        private IWebElement saveButton;
        public EditArtworkPage(IWebDriver driver)
        {
            this.webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Save(string artworkTitle, string artworkGenre, string artworkAuthor, string artworkRent)
        {
            this.artworkTitle.Clear();
            this.artworkTitle.SendKeys(artworkTitle);
            this.artworkGenre.Clear();
            this.artworkGenre.SendKeys(artworkGenre);
            this.artworkAuthor.Clear();
            this.artworkAuthor.SendKeys(artworkAuthor);
            this.artworkRent.Clear();
            this.artworkRent.SendKeys(artworkRent);
            saveButton.Click();
        }
    }
}
