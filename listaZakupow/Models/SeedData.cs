using Microsoft.EntityFrameworkCore;
using listaZakupow.Data;
namespace listaZakupow.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new listaZakupowContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<listaZakupowContext>>()))
            {
                if (context == null || context.Produkt == null)
                {
                    throw new ArgumentNullException("Null");
                }


                if (context.Produkt.Any())
                {
                    return;
                }

                context.Produkt.AddRange(
                    new Produkt
                    {
                        Opis = "kajzerka",
                        Rodzaj = "pieczywo",
                        Data = DateTime.Parse("2023-2-12"),
                        Zrobione = true,

                    },
                    new Produkt
                    {
                        Opis = "jablko",
                        Rodzaj = "owoc",
                        Data = DateTime.Parse("2023-3-12"),
                        Zrobione = true,

                    }
                    );
                context.SaveChanges();

            }
        }
    }
    }

