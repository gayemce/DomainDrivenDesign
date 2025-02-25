using DomainDrivenDesign.Domain.Orders;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.GetAllOrder;

public sealed record GetAllOrderQuery() : IRequest<List<Order>>;
