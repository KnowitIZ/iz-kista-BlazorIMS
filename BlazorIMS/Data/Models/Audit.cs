using Microsoft.AspNetCore.Identity;

namespace BlazorIMS.Data
{
    public abstract class Audit
    {
        public string? CreatedById { get; set; } = string.Empty;
        public IdentityUser? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        
        public string? LastModifiedById { get; set; } = string.Empty;
        public IdentityUser? LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
    }
}
