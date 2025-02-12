using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;

namespace DomainDrivenDesign.Domain.Categories;
public sealed class Category : Entity
{
    public Category(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
    public ICollection<Product> Products {  get; set; }
}
