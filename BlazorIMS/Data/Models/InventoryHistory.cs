namespace BlazorIMS.Data
{
    public class InventoryHistory : Audit
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; } = new();

        public int Quantity { get; set; }
        public int QuantityBefore { get; set; }
        public int QuantityAfter { get; set; }
        public string? Project { get; set; } = string.Empty;
        public string? CheckedoutBy { get; set; } = string.Empty;
        public DateTime CheckedoutOn { get; set; } = DateTime.Now;

    }
}
