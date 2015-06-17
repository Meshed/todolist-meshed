using System.Web.Http;
using System.Web.Routing;

namespace todolist_meshedService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();
        }
    }
}