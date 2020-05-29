using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.web.Controllers
{
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository) {
            _productRepository = productRepository;
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
    }
}
