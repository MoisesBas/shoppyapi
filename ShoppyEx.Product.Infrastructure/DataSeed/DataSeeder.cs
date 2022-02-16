using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShoppyEx.Product.Core.Domain.Brand;
using ShoppyEx.Product.Core.Domain.Product;
using ShoppyEx.Product.Core.Domain.Type;
using ShoppyEx.Product.Infrastructure.Persistence;
using System.Dynamic;
using System.Linq;


namespace ShoppyEx.Product.Infrastructure.DataSeed
{
    public static class DataSeeder
    {
        public static void SeedData(ApplicationDbContext context)
        {
            if (!context.Set<ProductBrand>().Any())
            {
                var data = File.ReadAllText("../ShoppyEx.Product.Infrastructure/DataSeed/brands.json");
                var brands = JsonConvert.DeserializeObject<List<ExpandoObject>>(data, new ExpandoObjectConverter());

                var items = new List<ProductBrand>();
                foreach (var item in from br in brands
                                     let item = ProductBrand.Create(new ProductBrandId(Guid.Parse(((dynamic)br).Id)), ((dynamic)br).Name)
                                     select item)
                {
                    items.Add(item);
                    
                }
                context.Set<ProductBrand>().AddRange(items);
                context.SaveChanges();

            }

            if (!context.Set<ProductType>().Any())
            {
                var items = new List<ProductType>();
                var data = File.ReadAllText("../ShoppyEx.Product.Infrastructure/DataSeed/types.json");
                var types = JsonConvert.DeserializeObject<List<ExpandoObject>>(data, new ExpandoObjectConverter());

                foreach (var item in from br in types
                                     let item = ProductType.Create(new ProductTypeId(Guid.Parse(((dynamic)br).Id)), ((dynamic)br).Name)
                                     select item)
                {
                    items.Add(item);
                }
                context.Set<ProductType>().AddRange(items);
                context.SaveChanges();
            }

            if (!context.Set<Core.Domain.Product.Product>().Any())
            {
                var data = File.ReadAllText("../ShoppyEx.Product.Infrastructure/DataSeed/products.json");
                var products = JsonConvert.DeserializeObject<List<ExpandoObject>>(data, new ExpandoObjectConverter());

                var items = new List<Core.Domain.Product.Product>();
                foreach (var item in from br in products
                                     let item = Core.Domain.Product.Product.Create(new ProductId(Guid.NewGuid()), ((dynamic)br).Name
                                     , ((dynamic)br).Description, ((dynamic)br).Price, ((dynamic)br).PictureUrl,
                                     new ProductTypeId(Guid.Parse(((dynamic)br).ProductTypeId)), new ProductBrandId(Guid.Parse(((dynamic)br).ProductBrandId)))
                                     select item)
                {
                    items.Add(item);
                }
                context.Set<Core.Domain.Product.Product>().AddRange(items);
                context.SaveChanges();
            }

           

        }

        public static IServiceProvider SeedProductApi(
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

