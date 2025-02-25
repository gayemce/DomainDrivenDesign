using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Products.CreateProduct;

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await _productRepository.CreateAsync(
            request.Name,
            request.Quantity,
            request.Amount,
            request.Currency,
            request.CategoryId,
            cancellationToken);

        await _unitOfWork.SaveChangeAsync(cancellationToken);
    }
}
