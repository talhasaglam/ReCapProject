using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            //Swagger
            //Dependency chain--

            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön ve datanın kendisini de yollayabiliriz istersek. result.data
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            //Swagger
            //Dependency chain--

            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

    }
}