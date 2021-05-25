using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    //Attribute --> Class Controllerdir.
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //ProdcutManager ve isterler değişebilir o yüzden  bu şekilde kurucu sınıofa product service gönderiyoruz.
        //Ipordcuty service injection
        //IoC Container yapacakmışızzzz. Inversion of Control.
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            Thread.Sleep(1000);
            //Swagger
            //Dependency chain--

            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            //Swagger
            //Dependency chain--

            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

        [HttpGet("getbybrand")]
        public IActionResult GetByBrand(int id)
        {

            //Swagger
            //Dependency chain--

            var result = _carService.GetAllByBrandId(id);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }


        [HttpGet("getbycolor")]
        public IActionResult GetByColor(int id)
        {

            //Swagger
            //Dependency chain--

            var result = _carService.GetAllByColorId(id);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result); //200 Başarılı dön
            }

            return BadRequest(result);
        }


    }
}