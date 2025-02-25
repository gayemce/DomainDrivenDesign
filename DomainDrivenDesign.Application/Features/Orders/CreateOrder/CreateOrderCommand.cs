using DomainDrivenDesign.Domain.Orders;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.CreateOrder;

public sealed class CreateOrderCommand(List<CreateOrderDto> createOrderDtos) : IRequest
{
    public List<CreateOrderDto> CreateOrderDtos { get; } = createOrderDtos;
}

