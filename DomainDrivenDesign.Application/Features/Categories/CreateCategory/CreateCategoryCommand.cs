using MediatR;

namespace DomainDrivenDesign.Application.Features.Categories.CreateCategory;
public sealed record CreateCategoryCommand(
    string Name): IRequest;
