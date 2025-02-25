using DomainDrivenDesign.Domain.Users;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.GetAllUser;

public sealed record GetAllUserQuery(): IRequest<List<User>>;
