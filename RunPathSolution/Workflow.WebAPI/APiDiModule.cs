using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.WebAPI
{
    public sealed class APiDiModule
    {

        public static void Load(IServiceCollection service)
        {
            service.AddTransient<IAlbums, MapALbums>();
            service.AddTransient<IPhotos, MapPhotos>();
        }
    }
}
