using CostManagement.Domain.Shared.Entities;
using CostManagement.Domain.Shared.Exceptions;

namespace CostManagement.Domain.Entities;

public class Product : Entity
{
    public Product(
        string name,
        string description,
        decimal value
        )
    {
        SetName(name);
        SetDescription(description);
        SetValue(value);
    }

    public string Name { get; private set; }

    public string Description { get; private set; } = null!;

    public decimal Value { get; private set; }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length > 255)
            throw new DomainException("Nome Inválido");

        Name = name;
    }

    public void SetValue(decimal value)
    {
        if(value !< 0)
        {
            throw new DomainException("Valor nao pode ser menor que 0.");
        }

        Value = value;
    }

    public void SetDescription(string description)
    {
        if (description.Length > 255)
            throw new Exception("Description inválida");

        Description = description;
    }
}