using MediatR;

namespace DomainDrivenDesign.Domain.Orders.Events;
public sealed class SendOrderEmailEvent : INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //Mail sending process
        return Task.CompletedTask;
    }
}
