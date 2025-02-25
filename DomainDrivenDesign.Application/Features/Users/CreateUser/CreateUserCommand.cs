using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.CreateUser;
public sealed record CreateUserCommand(
    string Name, 
    string Email, 
    string Password, 
    string Country, 
    string City, 
    string Street, 
    string FullAddress, 
    string PostalCode, 
    CancellationToken cancellationToken = default) : IRequest;
