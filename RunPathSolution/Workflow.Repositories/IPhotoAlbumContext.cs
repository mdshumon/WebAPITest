using System;
using System.Collections.Generic;
using System.Text;
using Workflow.WebAPI;

namespace Workflow.Repositories
{
    public interface IPhotoAlbumContext 
    {
         IPhotos Photos { get;  }
         IAlbums Albums { get;  }

    }
}
