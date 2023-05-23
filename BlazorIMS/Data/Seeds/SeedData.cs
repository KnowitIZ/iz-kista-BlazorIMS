using Microsoft.EntityFrameworkCore;

namespace BlazorIMS.Data.Seeds
{
    public static class SeedData
    {
        public static void EnsurePopulated(ApplicationDbContext context)
        {
            //if (!context.Inventories.Any())
            //{
            //    var random = new Random();
            //    var now = DateTime.Now;
            //    var locations = new List<string>();
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        locations.Add("Location " + i.ToString());
            //    }

            //    var categories = new List<string>();
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        categories.Add("Category " + i.ToString());
            //    }

            //    var list = new List<Inventory>();
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        for (int i = 1; i <= 100; i++)
            //        {
            //            var x = c * i;
            //            var inv = new Inventory();
            //            //inv.Id = x;
            //            inv.Name = "Name " + x.ToString();
            //            inv.Category = categories[random.Next(categories.Count)];
            //            inv.Location = locations[random.Next(locations.Count)];
            //            inv.Status = x % 10 == 0 ? InventoryStatus.CheckedOut : InventoryStatus.Available;
            //            inv.Description = "Description " + x.ToString();
            //            inv.CreatedOn = now;
            //            inv.CreatedBy = "Seed";
            //            inv.LastModifiedOn = now;
            //            inv.LastModifiedBy = "Seed";

            //            list.Add(inv);
            //        }
            //    }

            //    context.Inventories.AddRange(list);
            //    context.SaveChanges();
            //}
        }
    }
}