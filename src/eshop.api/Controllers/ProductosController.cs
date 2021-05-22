using System.Linq;
using AutoMapper;
using eshop.api.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace eshop.api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductosController : ControllerBase
    {
        public AppDbContext AppDbContext { get; }
        public IMapper Mapper { get; }
        public ProductosController(AppDbContext appDbContext, IMapper mapper)
        {
            this.Mapper = mapper;
            this.AppDbContext = appDbContext;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var productos = AppDbContext.Productos.ToList();
            if(productos == null) return BadRequest();
            return Ok(productos);
        }
    }
}