using AutomatedTestsSeleniumMS.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomatedTestsSeleniumMS
{
    [TestClass]
  
    public class AddArtworkTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void UserAddArtwork_Creates_ArtworkWithGivenDetails()
        {

            Random randomNumber = new Random();
            string artworkTitle = "MyArtworkTitle " + randomNumber.Next(100, 10000000);
            string artworkGenre = "MyArtworkGenre ";
            string artworkAuthor = "MyArtworkAuthor ";
            string artworkRent = "101";
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("adrian1@email.com", "Adrian1#");

            ArtworkPage artworkPage = new ArtworkPage(webDriver);
            artworkPage.GoToPage();
            AddArtworkPage addartworkPage = artworkPage.GotoAddArtworkPage();
            addartworkPage.Save(artworkTitle, artworkGenre, artworkAuthor, artworkRent );

            Assert.IsTrue(artworkPage.ArtworkExists(artworkTitle));

        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
