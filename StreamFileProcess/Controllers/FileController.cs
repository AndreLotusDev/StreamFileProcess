using Microsoft.AspNetCore.Mvc;
using StreamFileProcess.Attributes;
using StreamFileProcess.Services;

namespace StreamFileProcess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        [HttpPost("upload-stream-multipartreader")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status415UnsupportedMediaType)]
        [MultipartFormData]
        [DisableFormValueModelBinding]
        public async Task<IActionResult> Upload()
        {
            var fileUploadSummary = await new UploadService().UploadFileAsync(HttpContext.Request.Body, Request.ContentType);
            return CreatedAtAction(nameof(Upload), fileUploadSummary);
        }
    }
}
