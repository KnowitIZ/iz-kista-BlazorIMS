using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace BlazorIMS.Services
{
    //https://www.youtube.com/watch?v=FzwRxmy7eV4
    public class QrCodeGeneratorService
    {
        public QrCodeGeneratorService()
        {
            
        }
        public string Genereate(string inData)
        {
            string qrString = string.Empty;

            if (!string.IsNullOrEmpty(inData))
            {
                using (var ms = new MemoryStream())
                {
                    var generator = new QRCodeGenerator();
                    var data = generator.CreateQrCode(inData, QRCodeGenerator.ECCLevel.Q);
                    var qrCode = new QRCode(data);
                    using (Bitmap bitmap = qrCode.GetGraphic(20))
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        qrString = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            return qrString;
        }
    }
}
