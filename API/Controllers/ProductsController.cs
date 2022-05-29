using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : Controller
{
  private readonly ILogger<ProductsController> _logger;
  private readonly StoreContext _context;

  public ProductsController(StoreContext context, ILogger<ProductsController> logger)
  {
    _context = context;
    _logger = logger;
  }

  [HttpGet]
  public async Task<ActionResult<List<Product>>> GetProducts()
  {
    return await _context.Products.ToListAsync<Product>();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<Product>> GetProduct(Guid id)
  {
    return await _context.Products.FindAsync(id);
  }

}
