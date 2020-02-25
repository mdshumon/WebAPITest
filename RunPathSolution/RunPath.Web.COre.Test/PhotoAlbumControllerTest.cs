using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using RunPath.Web.Core.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workflow.BusinessLayer;
using Workflow.Models;
using Workflow.Models.ViewModels;
using Workflow.Repositories;
using Workflow.WebAPI;
using Xunit;

namespace RunPath.Web.COre.Test
{
    public class PhotoAlbumControllerTest
    {
        static List<Photos> photos = new List<Photos>() { new Photos() { Album = null, albumId = 1, id = 1, thumbnailUrl = null, title = "test", url = "" } };

        PhotoAlbumVm phoalbum = new PhotoAlbumVm()
        {
            Photos = photos,
            Albums = null
        };

        [Fact]
        public async Task Test1WithUserId_case1()
        {
            int userid = 1;

            var mockRepo = new Mock<IBusinessCore>();
            var controller = new PhotoAlbumController(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetUserPhotoAlbymByIdAsync(userid)).ReturnsAsync(phoalbum).Verifiable();
            var result = await controller.GetuserPhotos(userid) as PhotoAlbumVm;
            Assert.Single(result.Photos);
        }
    }
}
