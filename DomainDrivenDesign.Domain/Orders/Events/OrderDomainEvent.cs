using MediatR;

namespace DomainDrivenDesign.Domain.Orders.Events;
public sealed class OrderDomainEvent : INotification
{
    public Order Order { get; }
    public OrderDomainEvent(Order order)
    {
        Order = order;
    }
}
