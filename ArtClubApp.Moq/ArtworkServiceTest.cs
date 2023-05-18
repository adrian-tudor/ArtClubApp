using ArtClubApp.Controllers;
using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Moq;

namespace ArtClubApp.Moq;

public class ArtworkServiceTest
{
    [Fact]
    public void Test_Get_Artwork_By_Id()
    {
        //Arrange
        var artwork = new Artwork
        {
            Artwork_Id = 4,
            Title = "Mona Lisa",
            Genre = "Renaissance",
            Author = "Leonardo Da Vinci",
            Rent = 200
        };
        var artworkRepository = new Mock<IArtworkRepository>();
        artworkRepository.Setup(x => x.GetArtworkById(It.IsAny<int>())).Returns(artwork);
        var controller = new ArtworksController(artworkRepository.Object);
        //Act
        var getArtworkById = controller.GetArtworkById(4);
        //Assert
        Assert.NotNull(getArtworkById);
    }

    [Fact]
    public void Test_Artwork_Creation_ReturnsViewResultNullModel()
    {
        // Arrange
        IArtworkRepository context = null;
        var controller = new ArtworksController(context);

        // Act
        var result = controller.Create();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        Assert.Null(viewResult.ViewData.Model);
    }

    [Fact]
    public void Test_Create_Artwork_ValidModelState()
    {
        // Arrange
        var a = new Artwork
        {
            Artwork_Id = 6,
            Title = "Medusa",
            Genre = "Baroque",
            Author = "Caravaggio",
            Rent = 250
        };
        var mockRepository = new Mock<IArtworkRepository>();
        mockRepository.Setup(repo => repo.Create(It.IsAny<Artwork>()));
        var controller = new ArtworksController(mockRepository.Object);
        

        // Act
        var result = controller.Create(a);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Null(redirectToActionResult.ControllerName);
        Assert.Equal("Details", redirectToActionResult.ActionName);
        mockRepository.Verify();
    }
}

