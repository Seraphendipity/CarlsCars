using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CC {
    public static class InitializationSeed {
        public static void Initialize(IServiceProvider serviceProvider, bool bReset) {
            // DISCUSS: Service Providers
            // Need to research into this and what is actually is doing. I get it is a DI and container, passing it over...ye?:
            //      https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-guidelines
            //      https://www.stevejgordon.co.uk/aspnet-core-dependency-injection-what-is-the-iserviceprovider-and-how-is-it-built

            // CONTEXT CONNECTION
            // Establishing the context -- the variable associated with the code-side representation of the database.

            using(var context = new CarsContext(serviceProvider.GetRequiredService<DbContextOptions<CarsContext>>())) {

                if (bReset == true || !context.Car.Any()) {
                    context.Car.AddRange(
                        CarsService.GenerateCars().CarListing
                    );
                    context.SaveChanges();
                }
            }
            return;
        }

    }
}