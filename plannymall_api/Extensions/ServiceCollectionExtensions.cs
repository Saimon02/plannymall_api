using plannymall_api.Data.PostgreSql.PasswordResetTokenData.Interface;
using plannymall_api.Data.PostgreSql.PasswordResetTokenData.Repository;
using plannymall_api.Data.PostgreSql.RefreshTokenData.Interface;
using plannymall_api.Data.PostgreSql.RefreshTokenData.Repository;
using plannymall_api.Interfaces.Models;
using plannymall_api.Postgresql;

namespace plannymall_api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPostgresUser, PostgresUserRepo>();
            services.AddScoped<IRefreshToken, PostgresRefreshTokenRepo>();
            services.AddScoped<IPasswordResetTokenData, PostgresPasswordResetTokenDataRepo>();

            return services;
        }
    }
}
