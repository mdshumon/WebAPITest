using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Workflow.BusinessLayer;
using Workflow.Models.ViewModels;
using Workflow.WebAPI;

namespace RunPath.Web.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoAlbumController : ControllerBase
    {

        private readonly IBusinessCore iBusinessCore;
        public PhotoAlbumController(IBusinessCore iBusinessCoreP)
        {
            this.iBusinessCore = iBusinessCoreP;
        }

        [HttpGet]
        public async Task<PhotoAlbumVm> GetuserPhotos(int userId)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(userId)))
                return await iBusinessCore.GetUserPhotoAlbymByIdAsync(userId);
            return null;
        }
    }
}
