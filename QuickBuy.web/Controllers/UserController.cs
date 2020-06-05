using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contracts;
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
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

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
                var userReturn = _userRepository._Get(user.Email, user.Password);
                if(userReturn != null) {
                    return Ok(userReturn);
                }
                return BadRequest("Usuario ou senha inválido");
            }catch(Exception ex) {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] User user) {
            try {
                var registeredUser = _userRepository._Get(user.Email);
                if (registeredUser != null) {
                    return BadRequest("Usuario já cadastrado");
                }
                _userRepository.Create(user);
                return Ok();
            }catch(Exception ex) {
                return BadRequest(ex.ToString());
            }
        }
    }
}
