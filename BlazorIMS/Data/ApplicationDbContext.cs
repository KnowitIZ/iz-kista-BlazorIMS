using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorIMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet<CheckoutRequest> CheckoutRequests => Set<CheckoutRequest>();
        public DbSet<Checkout> Checkouts => Set<Checkout>();
        public DbSet<InventoryHistory> InventoryHistories => Set<InventoryHistory>();

    }
}