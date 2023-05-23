using BlazorIMS.Data;

namespace BlazorIMS.Services
{
    public class AuditService
    {
        public void ForCreate(Audit audit, string createdById)
        {
            var now = DateTime.Now;
            audit.CreatedById = createdById;
            audit.CreatedOn = now;
            audit.LastModifiedById = createdById;
            audit.LastModifiedOn = now;
        }

        public void ForEdit(Audit audit, string lastModifiedById)
        {
            audit.LastModifiedById = lastModifiedById;
            audit.LastModifiedOn = DateTime.Now;
        }
    }
}
