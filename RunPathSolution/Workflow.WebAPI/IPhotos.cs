using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workflow.Models;

namespace Workflow.WebAPI
{
    public interface IPhotos
    {
        Task<List<Photos>> GetAllPhotosAsync(string url);
    }
}
