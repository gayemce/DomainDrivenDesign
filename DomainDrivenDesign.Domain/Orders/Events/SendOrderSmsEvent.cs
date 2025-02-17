using MediatR;

namespace DomainDrivenDesign.Domain.Orders.Events;

public sealed class SendOrderSmsEvent : INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //SMS sending process
        return Task.CompletedTask;
    }
}
