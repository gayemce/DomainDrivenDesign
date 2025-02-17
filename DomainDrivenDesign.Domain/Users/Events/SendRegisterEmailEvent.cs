using MediatR;

namespace DomainDrivenDesign.Domain.Users.Events;

public sealed class SendRegisterEmailEvent : INotificationHandler<UserDomainEvent>
{
    public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
    {
        //Sending registration email for the user
        return Task.CompletedTask;
    }
}
