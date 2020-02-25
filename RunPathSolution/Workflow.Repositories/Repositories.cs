using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.Repositories
{
    public class Repositories : IRepository
    {
        readonly IPhotoAlbumContext iPhotoAlbumContext;
        public Repositories(IPhotoAlbumContext iPhotoAlbumContextp)
        {
            this.iPhotoAlbumContext = iPhotoAlbumContextp;
        }

        public IPhotoAlbumContext PhotoAlbumContext
        {
            get
            {
                return iPhotoAlbumContext;
            }
        }
    }
}
