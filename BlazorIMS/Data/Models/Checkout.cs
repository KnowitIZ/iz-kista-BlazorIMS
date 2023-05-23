using Microsoft.AspNetCore.Identity;

namespace BlazorIMS.Data
{
    public class Checkout : Audit
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public Inventory? Inventory { get; set; }
        public string CheckedOutById { get; set; }
        public IdentityUser? CheckedOutBy { get; set; }
    }
}
