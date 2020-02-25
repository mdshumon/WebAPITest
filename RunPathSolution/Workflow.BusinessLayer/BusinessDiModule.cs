using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.BusinessLayer
{
    public sealed class BusinessDiModule
    {
        public static void Load(IServiceCollection service)
        {
            service.AddTransient<IBusinessCore, BusinessCore>();
        }
    }
}
