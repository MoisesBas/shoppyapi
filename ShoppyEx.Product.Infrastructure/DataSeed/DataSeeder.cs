using Microsoft.Extensions.DependencyInjection;
using ShoppyEx.Product.Core.Domain.Category;
using ShoppyEx.Product.Core.Domain.Product;
using ShoppyEx.Product.Core.Domain.Tag;
using ShoppyEx.Product.Infrastructure.Persistence;

namespace ShoppyEx.Product.Infrastructure.DataSeed
{
    public static class DataSeeder
    {
        public static void SeedData(ApplicationDbContext context)
        {

            for (char c = 'A'; c <= 'Z'; c++)
            {
                var categoryId = new CategoryId(Guid.NewGuid());
                var category = Category.Create(categoryId, $"category-{c}");
                context.Set<Category>().Add(category);

                var tagId = new TagId(Guid.NewGuid());
                var tag = Tag.Create(tagId, $"tag-{c}");
                context.Set<Tag>().Add(tag);

                var productId = new ProductId(Guid.NewGuid());
                var product = Core.Domain.Product.Product.Create(productId, $"Product-{c}", Convert.ToDecimal(100), $"Shoppx-Product-{c}", 1000,1000,"tesfskfdsdfsdfdf", categoryId, tagId);
                context.Set<Core.Domain.Product.Product>().Add(product);
            }
            context.SaveChanges();

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

