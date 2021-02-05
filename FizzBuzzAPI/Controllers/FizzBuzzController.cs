using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly FizzBuzzDBContext _context;

        public FizzBuzzController(FizzBuzzDBContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public List<FizzBuzzStore> FizzBuzz()
        {
            return _context.FizzBuzzStores.ToList();
        }
    }
}
