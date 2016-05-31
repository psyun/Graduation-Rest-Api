using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using HDO2O.API.App_Start;

[assembly: OwinStartup(typeof(HDO2O.API.Startup))]

namespace HDO2O.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            IocContainer.Configure();
        }
    }
}
