using Microsoft.EntityFrameworkCore;
using Backend.DatabaseContexts;
using Backend.DTOS;
using Backend.Entities;

using System.Runtime.CompilerServices;

namespace Backend.Services.OrderService;

public class OrderServicecs : IOrderService
{
    private readonly DatabaseContext _contexts;
    public OrderServicecs(DatabaseContext context)
    {
        _contexts = context;
    }
    public async Task<CreateOrderDto> Create(CreateOrderDto dto)
    {
        var orderToCreate = new Order
        {
            ItemName=dto.ItemName,
            ItemQty=dto.ItemQty,    
            OrderAddress=dto.OrderAddress,
            OrderDelivery=dto.OrderDelivery,
            PhoneNumber=dto.PhoneNumber,
        };
        _contexts.OrderTbl.Add(orderToCreate);
        await _contexts.SaveChangesAsync();
        return dto;
    }
    public async Task<IEnumerable<OrderGetDto>> GetAllOrder()
    {
        var orders = await _contexts.OrderTbl.AsNoTracking().ToListAsync();

        var ordersToReturn = orders.Select(o => new OrderGetDto
        {
            Id=o.ItemCode,
            ItemName = o.ItemName,
            ItemQty = o.ItemQty,
            OrderAddress = o.OrderAddress,
            OrderDelivery = o.OrderDelivery,
            PhoneNumber = o.PhoneNumber,

        });

        return ordersToReturn;
    }
    public async Task EditOrder(int orderId,EditOrderDto dto)
    {
        var order = await _contexts.OrderTbl.FindAsync(orderId) ?? throw new ArgumentException(null, nameof(orderId));
        order.OrderAddress = dto.OrderAddress;
        order.OrderDelivery = dto.OrderDelivery;
        await _contexts.SaveChangesAsync();
    }
}
