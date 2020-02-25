using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workflow.Models.ViewModels;
using Workflow.Repositories;

namespace Workflow.BusinessLayer
{
    public interface IBusinessCore
    {
        Task<PhotoAlbumVm> GetUserPhotoAlbymByIdAsync(int id);
    }
}
