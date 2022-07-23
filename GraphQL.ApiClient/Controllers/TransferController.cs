using GraphQL.ApiClient.Services.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.ApiClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TransferController(ITransferService transferService, IWebHostEnvironment hostEnvironment)
        {
            _transferService = transferService;
            _hostEnvironment = hostEnvironment;
        }
        [HttpGet, Route("ReturnHtml")]
        public async Task<IActionResult> ReturnHtml()
        {
            var transfers = await _transferService.GetTransfers();
            var resultStr = transfers.ToString();

            string path = Path.Combine(_hostEnvironment.WebRootPath, "index.html");
            var content = await System.IO.File.ReadAllTextAsync(path);
            var result = string.Format(content, resultStr);
            return Ok(result);
        }
    }
}
