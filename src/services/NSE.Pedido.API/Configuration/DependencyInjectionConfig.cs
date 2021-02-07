using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NSE.Core.Mediator;
using NSE.Pedidos.Domain.Vouchers;
using NSE.Pedidos.Infra.Data;
using NSE.Pedidos.Infra.Data.Repository;
using NSE.WebAPI.Core.Usuario;

namespace NSE.Pedidos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            // Commands

            // Events

            // Application
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Data
            services.AddScoped<IVoucherRepository, VoucherRepository>();
            services.AddScoped<PedidosContext>();
        }
    }
}