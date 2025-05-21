

using Domain.Contracts;
using Persistance.Data.Contexts;
using System.Text.Json;

namespace Persistance.DataSeeding
{
    public class DbInitialzer(StoreDbContext _context) : IDbInitializer
    {
        public async Task InitialzeAsync()
        {
            try
            {

                //if((await _context.Database.GetPendingMigrationsAsync()).Any())
                // await _context.Database.MigrateAsync();

                if (!_context.Set<ProductBrand>().Any())
                {
                    var data = await File.ReadAllTextAsync(@"..\Infrastucture\Persistance\DataSeeding\brands.json");
                    var objects = JsonSerializer.Deserialize<List<ProductBrand>>(data);

                    if (objects is not null && objects.Any())

                    {
                        _context.Set<ProductBrand>().AddRange(objects);
                        _context.SaveChanges();


                    }
                }
                if (!_context.Set<ProductTypes>().Any())
                {
                    var data = await File.ReadAllTextAsync(@"..\Infrastucture\Persistance\DataSeeding\types.json");
                    var objects = JsonSerializer.Deserialize<List<ProductTypes>>(data);

                    if (objects is not null && objects.Any())

                    {
                        _context.Set<ProductTypes>().AddRange(objects);
                        _context.SaveChanges();


                    }
                }
                if (!_context.Set<Product>().Any())
                {
                    var data = await File.ReadAllTextAsync(@"..\Infrastucture\Persistance\DataSeeding\products.json");
                    var objects = JsonSerializer.Deserialize<List<Product>>(data);

                    if (objects is not null && objects.Any())

                    {
                        _context.Set<Product>().AddRange(objects);
                        _context.SaveChanges();


                    }
                }
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            
            }
        }


     
    
    }
}

