﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenThanhLam_lab456.Startup))]
namespace NguyenThanhLam_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
