using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        
private readonly StoreContext _ctx;
        public ProductsController(StoreContext ctx){
            this._ctx=ctx;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
           return await _ctx.Products.ToListAsync();

            // return Ok(product);
        }
        [HttpGet("{Id}")]

        public async Task<ActionResult<Product>> GetProduct(int Id)
        {
            return await _ctx.Products.FindAsync(Id);
        }

    }
}