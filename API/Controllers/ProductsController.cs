using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly StoreContext _context;

        public ProductsController(ILogger<ProductsController> logger, StoreContext context)
        {
            _logger = logger;
            _context = context;
        }
        //the first endpoint on this project
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
           return await _context.Products.ToListAsync();
          
        }

       [HttpGet("{id}")]
       public async Task<ActionResult<Product>> GetProductById(int id)
       {
           //var result = _context.Products.Where(x => x.Id == id);
           return await _context.Products.FindAsync(id);
          
       }
    }
}