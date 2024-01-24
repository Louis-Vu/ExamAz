using Microsoft.AspNetCore.Mvc;
using Backend.DTOS;

namespace Backend.Services.OrderService
{
    public interface IOrderService
    {
        Task<CreateOrderDto> Create(CreateOrderDto dto);
        Task<IEnumerable<OrderGetDto>> GetAllOrder();
        Task EditOrder(int orderId, EditOrderDto dto);
    }
}
