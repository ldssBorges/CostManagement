using CostManagement.Domain.Shared.Entities;

namespace CostManagement.Domain.Entities;

public class OrderItem : Entity
{
    public OrderItem(
        Guid productId, 
        decimal unitPrice, 
        decimal quantity)
    {
        ProductId = productId;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public Guid ProductId { get; private set; }
    public decimal UnitPrice { get; private set; }
    public decimal Quantity { get; private set; }
}
