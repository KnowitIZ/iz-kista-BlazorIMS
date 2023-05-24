using System.ComponentModel.DataAnnotations;

namespace BlazorIMS.Data
{
    public class Inventory : Audit
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a {0}")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a {0}")]
        public string Category { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a {0}")]
        public string Location { get; set; } = string.Empty;
        public InventoryStatus Status { get; set; } = InventoryStatus.Available;
        //[Required(ErrorMessage = "Please enter a {0}")]
        public string Description { get; set; } = string.Empty;
        public string? DataSheet { get; set; } = string.Empty;

        public string? Supplier { get; set; } = string.Empty;
        public string? Comment { get; set; } = string.Empty;

    }
}
