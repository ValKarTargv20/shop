using Microsoft.Extensions.DependencyInjection;
using shop.ApplicationServices.Services;
using shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaiceship.Test
{
    public abstract class TestBase : IDisposable
    {
        protected IServiceProvider _serviceProvider;
        protected TestBase()
        {
            var services = new ServiceCollection();
            SetupServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }
        public virtual void SetupServices(IServiceCollection services)
        {
            services.AddScoped<ISpaceshipService, SpaceshipServices>();
        }
        public void Dispose()
        {
        }
        /*protected T Svc<T>()
        {
            return ServiceProvider.GetService<T>;
        }*/
    }
}
