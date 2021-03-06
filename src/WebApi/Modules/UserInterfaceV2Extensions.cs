namespace WebApi.Modules
{
    using Application.Boundaries.GetAccount;
    using Application.UseCases;
    using Domain.Accounts;
    using Microsoft.Extensions.DependencyInjection;
    using UseCases.V2.GetAccount;

    public static class UserInterfaceV2Extensions
    {
        public static IServiceCollection AddPresentersV2(this IServiceCollection services)
        {
            services.AddScoped<GetAccountDetailsPresenterV2, GetAccountDetailsPresenterV2>();
            services.AddScoped<IGetAccountUseCaseV2>(
                ctx => new GetAccountUseCase(
                    ctx.GetRequiredService<GetAccountDetailsPresenterV2>(),
                    ctx.GetRequiredService<IAccountRepository>()));

            return services;
        }
    }
}
