using MediatR;

namespace DomainDrivenDesign.Application.Features.Products.CreateProduct;

public sealed record CreateProductCommand(
    string Name,
    int Quantity,
    decimal Amount,
    string Currency,
    Guid CategoryId) : IRequest;
