using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;

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
    public ICollection<OrderLine> OrderLines { get; private set; } = new List<OrderLine>();

    public void CreateOrder(List<CreateOrderDto> createOrderDtos)
    {
        foreach (var item in createOrderDtos)
        {
            if(item.Quantity < 1)
            {
                throw new ArgumentException("The order quantity cannot be less than one unit.");
            }

            OrderLine orderLine = new(
                Guid.NewGuid(),
                Id,
                item.ProductId,
                item.Quantity,
                new(item.Amount, Currency.FromCode(item.Currency)));

            OrderLines.Add(orderLine);
        }
    }

    public void RemoveOrderLine(Guid orderLineId)
    {
        var orderLine = OrderLines.FirstOrDefault(p => p.Id == orderLineId);

        if(orderLine is null)
        {
            throw new ArgumentException("The order item you want to delete was not found.");
        }

        OrderLines.Remove(orderLine);
    }
}
