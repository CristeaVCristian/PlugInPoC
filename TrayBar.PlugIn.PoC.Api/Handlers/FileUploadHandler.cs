using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TrayBar.PlugIn.PoC.Api.Models;

namespace TrayBar.PlugIn.PoC.Api.Handlers
{
    public class FileUploadHandler
    {
        private readonly string serverPath;

        public FileUploadHandler(string serverPath)
        {
            this.serverPath = serverPath;

            if (!Directory.Exists(this.serverPath))
            {
                Directory.CreateDirectory(this.serverPath);
            }
        }

        public async Task<string> ProcessRequest(MultipartMemoryStreamProvider memoryStreamProvider)
        {
            var fileEntity = new FileUpload();
            var fileName = new StringBuilder();

            foreach (var content in memoryStreamProvider.Contents)
                if (!string.IsNullOrEmpty(content.Headers?.ContentDisposition?.FileName))
                {
                    fileEntity.Stream = await content.ReadAsStreamAsync();
                    fileEntity.Extension = Path.GetExtension(
                        content.Headers.ContentDisposition.FileName.TrimEnd('"').TrimStart('"'));
                }
                else if (content.Headers?.ContentDisposition != null)
                {
                    fileName.Append(await content.ReadAsStringAsync());
                }

            fileEntity.Name = ComputeSha256Hash(fileName.ToString()) + fileEntity?.Extension;

            using (var fs = File.Create(Path.Combine(this.serverPath, fileEntity.Name)))
            {
                fileEntity.Stream?.CopyTo(fs);
            }

            return fileEntity.Name;
        }

        private static string ComputeSha256Hash(string rawData)
        {
            var builder = new StringBuilder();
            using (var sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                foreach (var unit in bytes) builder.Append(unit.ToString("x2"));

                return builder.ToString();
            }
        }
    }
}