using Backend.DatabaseContexts;
using Backend.DTOS;
using Backend.Services.OrderService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly DatabaseContext _context;
    private readonly IOrderService _orderService;
    public OrderController(DatabaseContext context,IOrderService orderService)
    {
        _orderService = orderService;
        _context = context;
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateOrderDto dto)
    {
  
        var orderToReturn = await _orderService.Create(dto);

        return Created("", orderToReturn);
    }

    [HttpGet]
    public async Task<IActionResult> GetOrdersForCustomer()
    {
  
        var ordersToReturn = await _orderService.GetAllOrder();
        return Ok(ordersToReturn);
    }
    [HttpPut("{id:int}")]
    public async Task<IActionResult> EditOrder([FromRoute] int id, [FromBody] EditOrderDto dto)
    {
        var order = await _context.OrderTbl.AsNoTracking().FirstOrDefaultAsync(o => o.ItemCode == id);
        if (order is null) return NotFound();

        await _orderService.EditOrder(id, dto);
        return NoContent();
    }
}
