using AutomatedTestsSeleniumMS.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS
{
    [TestClass]

    public class EditArtworkTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserEditsArtworkWithGivenDetails()
        {

            Random randomNumber = new Random();
            string artworkTitle = "MyArtworkTitle " + randomNumber.Next(100, 10000000);
            string artworkGenre = "MyArtworkGenre ";
            string artworkAuthor = "MyArtworkAuthor ";
            string artworkRent = "100001";
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            ArtworkPage artworkPage = new ArtworkPage(webDriver);
            artworkPage.GoToPage();
            EditArtworkPage editartworkPage = artworkPage.GotoEditArtworkPage();
            editartworkPage.Save(artworkTitle, artworkGenre, artworkAuthor, artworkRent);

            Assert.IsTrue(artworkPage.ArtworkExists(artworkTitle));

        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
