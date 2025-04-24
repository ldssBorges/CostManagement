using CostManagement.Domain.Shared.Entities;
using CostManagement.Domain.Shared.Exceptions;

namespace CostManagement.Domain.Entities;

public class Product : Entity
{
    public Product(string name, string description, decimal price)
    {
        SetName(name);    
        SetPrice(price);
        OutOfStock = true;
        Description = description;
    }

    public string Name { get; private set; }
    public string Description { get; private set; } = null!;
    public decimal Price { get; private set; }
    public bool OutOfStock { get; private set; }

    public void SetPrice(decimal price)
    {
        if (price <= 0)
        {
            throw new DomainException("Invalid Price");
        }

        Price = price;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new DomainException("Invalid Name");
        }

        Name = name;
    }

    public void SetOutOfStock(bool outOfStock)
    {
        OutOfStock = outOfStock;
    }
}
