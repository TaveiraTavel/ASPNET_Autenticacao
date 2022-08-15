using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(ASP_Autenticacao.App_Start.Startup1))]

namespace ASP_Autenticacao.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            /*app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "AppLocationCookie",
                LoginPath = new PathString("ASP_Autenticacao/Login")
            });*/
        }
    }
}
