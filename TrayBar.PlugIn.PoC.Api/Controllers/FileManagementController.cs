using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using TrayBar.PlugIn.PoC.Api.Filters;
using TrayBar.PlugIn.PoC.Api.Handlers;

namespace TrayBar.PlugIn.PoC.Api.Controllers
{
    public class FileManagementController : ApiController
    {
        private readonly MultipartMemoryStreamProvider multipartFormDataStreamProvider;
        private readonly FileUploadHandler fileUploadHandler;
        private readonly string serverPath;

        public FileManagementController()
        {
            this.serverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Downloads");
            this.multipartFormDataStreamProvider = new MultipartMemoryStreamProvider();
            this.fileUploadHandler = new FileUploadHandler(this.serverPath);
        }

        [HttpGet]
        [Route("DownloadDocument")]
        public async Task<HttpResponseMessage> DownloadDocument(string fileName)
        {
            HttpResponseMessage result;
            try
            {
                result = this.Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new StreamContent(
                    new FileStream(Path.Combine(this.serverPath, fileName), FileMode.Open, FileAccess.Read));

                result.Content.Headers.ContentDisposition =
                    new ContentDispositionHeaderValue("attachment") { FileName = fileName };
            }
            catch (FileNotFoundException)
            {
                return this.Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

            return result;
        }

        [HttpGet]
        [Route("GetDocuments")]
        public async Task<IHttpActionResult> GetDocuments()
        {
            try
            {
                var downloadsDirectory = new DirectoryInfo(this.serverPath);

                var fileNames = downloadsDirectory.GetFiles().Select(file => file.Name).ToList();

                return this.Ok(fileNames);
            }
            catch (Exception)
            {
                return this.InternalServerError();
            }
        }

        [HttpPut]
        [Route("SignDocument")]
        [MimeMultipartAction]
        public async Task<IHttpActionResult> SignDocument()
        {
            var providerResponse =
                await this.Request.Content.ReadAsMultipartAsync(this.multipartFormDataStreamProvider);

            var fileName = await this.fileUploadHandler.ProcessRequest(providerResponse);

            return this.Ok(fileName);
        }
    }
}