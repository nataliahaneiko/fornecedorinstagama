using InstaGama.Application.AppFornecedor;
using InstaGama.Application.AppFornecedor.Interfaces;
using InstaGama.Application.AppUser;
using InstaGama.Application.AppUser.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InstaGama.Repositories.IoC.Application
{
    internal class ApplicationBootstraper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IFornecedorAppService, FornecedorAppService>();
        }
    }
}
