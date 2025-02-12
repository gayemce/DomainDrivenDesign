using DomainDrivenDesign.Domain.Abstractions;

namespace DomainDrivenDesign.Domain.Orders;
public sealed class Order : Entity
{
    public Order(Guid id, string orderNumber, DateTime createdDate, OrderStatusEnum status) : base(id)
    {
        OrderNumber = orderNumber;
        CreatedDate = createdDate;
        Status = status;
    }

    public string OrderNumber { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public ICollection<OrderLine> OrderLines { get; private set; }
}
