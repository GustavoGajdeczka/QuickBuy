using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.web.Controllers
{
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private IHttpContextAccessor _httpContextAccessor;
        private IHostingEnvironment _hostingEnvironment;
        public ProductController(IProductRepository productRepository, 
                                    IHttpContextAccessor httpContextAccessor,
                                        IHostingEnvironment hostingEnvironment) {
            _productRepository = productRepository;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        public IActionResult Get() {
            try {
                return Ok(_productRepository.GetAll());
            }catch (Exception ex) {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]Product product) {
            try {
                _productRepository.Create(product);
                return Created("api/product", product);
            }catch (Exception ex) {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("SendFile")]
        public IActionResult SendFile() {
            try {
                var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["sendFile"];
                var fileName = formFile.FileName;
                var extension = fileName.Split(".").Last();
                var compactNameArray = Path.GetFileNameWithoutExtension(fileName).Take(10).ToArray();
                var newFileName = new string(compactNameArray).Replace(" ", ".");
                newFileName = $"{newFileName}_{DateTime.Now.Year}" +
                    $"{DateTime.Now.Month}" +
                    $"{DateTime.Now.Day}-" +
                    $"{DateTime.Now.Hour}" +
                    $"{DateTime.Now.Minute}" +
                    $"{DateTime.Now.Second}.{extension}";
                var fileFolder = _hostingEnvironment.WebRootPath + "\\files\\";
                var completeName = fileFolder + newFileName;

                using (var fileStream = new FileStream(completeName, FileMode.Create)) {
                    formFile.CopyTo(fileStream);
                };

                return Json(newFileName);

            } catch (Exception ex) {
                return BadRequest(ex.ToString());
            }
        }
    }
}
