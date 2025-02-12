using DomainDrivenDesign.Domain.Abstractions;

namespace DomainDrivenDesign.Domain.Orders;
public sealed class Order : Entity
{
    public Order(Guid id) : base(id)
    {
    }

    public string OrderNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderStatusEnum Status { get; set; }
    public ICollection<OrderLine> OrderLines { get; set; }
}
