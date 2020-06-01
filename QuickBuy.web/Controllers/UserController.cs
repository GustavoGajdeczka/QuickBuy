using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.web.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {

        [HttpGet]
        public ActionResult Get() {
            try {
                return Ok();
            } catch (Exception ex) {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("VerifyUser")]
        public ActionResult VerifyUser([FromBody] User user) {
            try {
                if(user.Email == "gustavo@teste.com" && user.Password == "1234") {
                    return Ok(user);
                }
                return BadRequest("Usuario ou senha inválido");
            }catch(Exception ex) {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public ActionResult Post() {
            try {
                return Ok();
            }catch(Exception ex) {
                return BadRequest(ex.ToString());
            }
        }
    }
}
