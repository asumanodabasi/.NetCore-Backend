using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //IoC Container-->Inversion of Control=degisimin kontrolu :icinde ihtiyac duyulan newlemeleri tutar conteynır gibi.yani bi configuration
        IProductService _productService;   
        //loosely coupled -->gevsek bagımlılık soyuta bagimli
        // managerı servisi degistirirsek bi problem olmaz yani asagıdaki kodla bunu saglamis olduk
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult  GetAll()
        {  
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

           return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       [HttpPost("add")]
       public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
