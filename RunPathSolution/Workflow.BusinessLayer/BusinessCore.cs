using System;
using System.Collections.Generic;
using System.Text;
using Workflow.Models.ViewModels;
using Workflow.Repositories;
using System.Linq;
using Workflow.Config;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Workflow.BusinessLayer
{
    public class BusinessCore : IBusinessCore
    {
        readonly IRepository iRepository;
        readonly ConfigReader.AppSettings settings = null;
        PhotoAlbumVm photoAlbumVm = new PhotoAlbumVm();
        const string ALBUMURL = "albums";
        const string PHOTOURL = "photos";
        public BusinessCore(IRepository iRepositoryp, IOptions<ConfigReader.AppSettings> settingsP)
        {
            this.iRepository = iRepositoryp;
            this.settings = settingsP.Value;
        }
        public async Task<PhotoAlbumVm> GetUserPhotoAlbymByIdAsync(int userId)
        {
            var alb = await iRepository.PhotoAlbumContext.Albums.GetAllAlbumsAsync(this.settings.serverBaseURL + ALBUMURL);
            var photo = await iRepository.PhotoAlbumContext.Photos.GetAllPhotosAsync(this.settings.serverBaseURL + PHOTOURL);
            photoAlbumVm.Albums = alb.Where(x => x.userId == userId).ToList();
            photoAlbumVm.Photos = photo.Where(x => photoAlbumVm.Albums.Any(y => y.id == x.albumId)).ToList();
            return photoAlbumVm;
        }
    }
}
