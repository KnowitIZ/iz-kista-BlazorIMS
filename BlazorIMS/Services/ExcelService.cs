using BlazorIMS.Data;
using BlazorIMS.ViewModels;
using Microsoft.JSInterop;
using OfficeOpenXml;

namespace BlazorIMS.Services
{
    public class ExcelService
    {
        public List<ExcelViewModel> GetList()
        {
            return new List<ExcelViewModel>();
        }

        //https://www.youtube.com/watch?v=d6R3dvJUnXo
        //https://www.youtube.com/watch?v=ALH7X0nZBkg
        //public ExcelPackage ExportInventory(List<Inventory> items)
        public async Task ExportInventory(IJSRuntime js, List<Inventory> items)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                package.Workbook.Properties.Title = "Inventory";
                package.Workbook.Properties.Author = "";
                package.Workbook.Properties.Subject = "";
                package.Workbook.Properties.Keywords = "";

                var ws = package.Workbook.Worksheets.Add("Inventory");

                //headers
                int col = 1;
                int row = 1;
                
                ws.Cells[row, col++].Value = "Id";
                ws.Cells[row, col++].Value = "Name";
                ws.Cells[row, col++].Value = "Category";
                ws.Cells[row, col++].Value = "Location";
                ws.Cells[row, col++].Value = "Status";
                ws.Cells[row, col++].Value = "Description";
                ws.Cells[row, col++].Value = "DataSheet";
                ws.Cells[row, col++].Value = "Supplier";
                ws.Cells[row, col++].Value = "Comment";
                ws.Cells[row, col++].Value = "Created By";
                ws.Cells[row, col++].Value = "Created On";
                ws.Cells[row, col++].Value = "Last Modified By";
                ws.Cells[row, col++].Value = "Last Modified On";

                //values
                row = 2;
                foreach (var item in items)
                {
                    col = 1;
                    ws.Cells[row, col++].Value = item.Id.ToString();
                    ws.Cells[row, col++].Value = item.Name;
                    ws.Cells[row, col++].Value = item.Category;
                    ws.Cells[row, col++].Value = item.Location;
                    ws.Cells[row, col++].Value = item.Status.ToString();
                    ws.Cells[row, col++].Value = item.Description;
                    ws.Cells[row, col++].Value = item.DataSheet;
                    ws.Cells[row, col++].Value = item.Supplier;
                    ws.Cells[row, col++].Value = item.Comment;
                    ws.Cells[row, col++].Value = item.CreatedBy == null ? "" : item.CreatedBy!.UserName;
                    ws.Cells[row, col++].Value = item.CreatedOn.ToString();
                    ws.Cells[row, col++].Value = item.LastModifiedBy == null ? "" : item.LastModifiedBy!.UserName;
                    ws.Cells[row, col++].Value = item.LastModifiedOn.ToString();

                    row++;
                }

                //autofitcolumns
                ws.Cells[1, 1, items.Count(), 13].AutoFitColumns();

                await js.InvokeVoidAsync(
                    "saveAsFile",
                    "Inventory.xlsx",
                Convert.ToBase64String(package.GetAsByteArray()));
            }
        }
    }
}
