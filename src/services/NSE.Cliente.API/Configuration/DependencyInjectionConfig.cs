using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NSE.Clientes.API.Application.Commands;
using NSE.Core.Mediator;

namespace NSE.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();
        }
    }
}