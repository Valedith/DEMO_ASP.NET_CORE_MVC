using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DEMO_ASP.NET_CORE_MVC.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext (DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<DEMO_ASP.NET_CORE_MVC.Models.Recipe> Recipe { get; set; }
        protected override void OnModelCreating(ModelBuilder bldr)
        {
            base.OnModelCreating(bldr);

            bldr.Entity<Recipe>()
              .HasData(new Recipe
              {
                  ID = 1,
                  RecipeName = "French fries",
                  Quantity = 41,
                  isAvailable = true,
                  RegisterDate = DateTime.ParseExact("28/09/2018", "dd/MM/yyyy", null)
              },
              new Recipe
              {
                  ID = 2,
                  RecipeName = "Spaghetti",
                  Quantity = 31,
                  isAvailable = true,
                  RegisterDate = DateTime.ParseExact("12/12/2016", "dd/MM/yyyy", null)
              },
              new Recipe
              {
                  ID = 3,
                  RecipeName = "Pizza",
                  Quantity = 0,
                  isAvailable = false,
                  RegisterDate = DateTime.ParseExact("20/06/2017", "dd/MM/yyyy", null)
              },
              new Recipe
              {
                  ID = 4,
                  RecipeName = "Curry",
                  Quantity = 50,
                  isAvailable = true,
                  RegisterDate = DateTime.ParseExact("16/08/2012", "dd/MM/yyyy", null)
              },
              new Recipe
              {
                  ID = 5,
                  RecipeName = "Baguette",
                  Quantity = 60,
                  isAvailable = true,
                  RegisterDate = DateTime.ParseExact("07/07/2013", "dd/MM/yyyy", null)
              },
              new Recipe
              {
                  ID = 6,
                  RecipeName = "Mashed potato",
                  Quantity = 57,
                  isAvailable = true,
                  RegisterDate = DateTime.ParseExact("13/06/2015", "dd/MM/yyyy", null)
              },
              new Recipe
              {
                  ID = 7,
                  RecipeName = "Lasagna",
                  Quantity = 0,
                  isAvailable = false,
                  RegisterDate = DateTime.ParseExact("05/05/2011", "dd/MM/yyyy", null)
              },
              new Recipe
              {
                  ID = 8,
                  RecipeName = "Ravioli",
                  Quantity = 88,
                  isAvailable = true,
                  RegisterDate = DateTime.ParseExact("22/01/2018", "dd/MM/yyyy", null)
              }
              );
        }

    }
}
