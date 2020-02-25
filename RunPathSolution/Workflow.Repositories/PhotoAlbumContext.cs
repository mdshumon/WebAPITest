using System;
using Workflow.WebAPI;

namespace Workflow.Repositories
{
    public class PhotoAlbumContext : IPhotoAlbumContext
    {

        readonly IPhotos iPhotos;
        readonly IAlbums iAlbums;
        public PhotoAlbumContext(IPhotos iPhotosP, IAlbums iAlbumsP)
        {
            this.iPhotos = iPhotosP;
            this.iAlbums = iAlbumsP;
        }

        public IPhotos Photos
        {
            get
            {
                return iPhotos;
            }
        }

        public IAlbums Albums 
        {
            get
            {
                return iAlbums;
            }
         }

    }
}
