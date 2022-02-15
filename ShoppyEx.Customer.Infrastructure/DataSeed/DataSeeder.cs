using Microsoft.Extensions.DependencyInjection;
using ShoppyEx.Customer.Core.Domain.Customer;
using ShoppyEx.Customer.Infrastructure.Persistence;

namespace ShoppyEx.Customer.Infrastructure.DataSeed
{
    public static class DataSeeder
    {
        public static void SeedData(ApplicationDbContext context)
        {         
            if (!context.Set<Core.Domain.Customer.Customer>().Any())
            {              
                var customers = new List<Core.Domain.Customer.Customer>();                
                for (char c = 'A'; c <= 'Z'; c++)
                {     
                    var customerId = new CustomerId(Guid.NewGuid());
                    var customer = Core.Domain.Customer.Customer.Create(customerId, $"Company-{c}");
                    customer.AddAddress(Core.Domain.Address.CustomerAddress.Create($"City-{c}", $"Country-{c}", $"Address-1-{c}", $"Address-2-{c}",$"Region-{c}", $"Postal Code-{c}",customerId));
                    customer.AddBillingAddress(Core.Domain.Address.BillingAddress.Create($"City-{c}", $"Country-{c}", $"Address-1-{c}", $"Region-{c}", $"Postal Code-{c}", customerId));
                    customer.AddShippingAddress(Core.Domain.Address.ShippingAddress.Create($"City-{c}", $"Country-{c}", $"Address-1-{c}", $"Region-{c}", $"Postal Code-{c}", customerId));
                    customer.AddCard(Core.Domain.Card.Card.Create($"Visa Card", 1, 2, 2025, true, customerId));
                    customers.Add(customer);
                }
                context.Set<Core.Domain.Customer.Customer>().AddRange(customers);
                context.SaveChanges();
            }
        }

        public static IServiceProvider SeedCustomerApi(
         this IServiceProvider host, bool drop)         
        {
            using (var scope = host.CreateScope())
            {
                var services = scope.ServiceProvider;               
                var context = services.GetRequiredService<ApplicationDbContext>();

                try
                {                  
                    if (context != null)
                    {
                        if (drop) 
                            SeedData(context);
                    }                  
                }
                catch (Exception ex)
                {
                   
                }
            }

            return host;
        }
    }
}

