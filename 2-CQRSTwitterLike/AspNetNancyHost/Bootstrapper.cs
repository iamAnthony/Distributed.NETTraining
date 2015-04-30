using Nancy;
using Nancy.TinyIoc;

namespace AspNetNancyHost
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
        }
    }
}