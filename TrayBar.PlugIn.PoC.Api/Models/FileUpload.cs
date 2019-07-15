using System.IO;

namespace TrayBar.PlugIn.PoC.Api.Models
{
    public class FileUpload
    {
        public string Name { get; set; }

        public string Extension { get; set; }

        public Stream Stream { get; set; }
    }
}