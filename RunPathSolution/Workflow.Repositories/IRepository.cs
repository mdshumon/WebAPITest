using System;
using System.Collections.Generic;
using System.Text;
using Workflow.WebAPI;

namespace Workflow.Repositories
{
    public interface IRepository
    {
        IPhotoAlbumContext PhotoAlbumContext { get; }

    }
}
