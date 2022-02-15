namespace ShoppyEx.Order.Infrastructure.IoC
{
    public static class ServicesInjectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));           
            services.AddScoped<IOrderUnitOfWork, OrderUnitOfWork>();
            services.AddSingleton<IEventSerializer, EventSerializer>();
        }
    }
}
