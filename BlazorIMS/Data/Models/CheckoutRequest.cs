namespace BlazorIMS.Data
{
    public class CheckoutRequest : Audit
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}
