using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Users;
using DomainDrivenDesign.Domain.Users.Events;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.CreateUser;

internal sealed class CreateUserCommandHander : IRequest<CreateCategoryCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;

    public CreateUserCommandHander(IUserRepository userRepository, IUnitOfWork unitOfWork, IMediator mediator)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.CreateAsync(
            request.Name,
            request.Email,
            request.Password,
            request.Country,
            request.City,
            request.Street,
            request.FullAddress,
            request.PostalCode,
            cancellationToken);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        await _mediator.Publish(new UserDomainEvent(user));
    }
}
