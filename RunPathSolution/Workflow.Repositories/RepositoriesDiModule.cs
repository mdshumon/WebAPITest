using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.Repositories
{
    public sealed class RepositoriesDiModule
    {
        public static void Load(IServiceCollection service)
        {
            service.AddTransient<IPhotoAlbumContext, PhotoAlbumContext>();
            service.AddTransient<IRepository, Repositories>();

        }

    }
}
