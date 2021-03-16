﻿using MagicDemo.Services;
using Microsoft.Extensions.DependencyInjection;
using Shiny;

namespace MagicDemo
{
    public partial class MainStartup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            services.AddSingleton<IAppSettings, AppSettings>();
        }
    }
}
