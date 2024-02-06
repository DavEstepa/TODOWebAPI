using TODOWebAPI.Domain.Constants;

namespace TODOWebAPI.Configurations
{
    public static class CORSConfig
    {
        public static void AddCORS(this IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy(AppSettings.CORS_POLICY_NAME_VALUE, builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
        }
    }
}
