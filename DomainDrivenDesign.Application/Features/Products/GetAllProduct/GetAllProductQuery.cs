using DomainDrivenDesign.Domain.Products;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Products.GetAllProduct;
public sealed record GetAllProductQuery() : IRequest<List<Product>>;
