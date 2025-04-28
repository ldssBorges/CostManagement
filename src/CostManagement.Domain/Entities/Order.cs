using CostManagement.Domain.Shared.Entities;
using CostManagement.Domain.Shared.Exceptions;

namespace CostManagement.Domain.Entities
{
    public class Order : Entity
    {

        public Order(
          Guid customerId)
        {
            CustomerId = customerId;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }

        public List<OrderItem> _itens = [];

        public Guid CustomerId { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public decimal Amount { get; private set; }

        public IReadOnlyList<OrderItem> Itens => _itens.AsReadOnly();

        public void CalculateAmount()
        {
            if (_itens.Count == 0)
                throw new DomainException("Houve um erro ao calcular o valor total.");

            Amount = _itens.Sum(x => x.UnitPrice * x.Quantity);
        }

        public void AddItens(IEnumerable<OrderItem> orderItems)
        {
            foreach (var item in orderItems)
            {
                AddItem(item);
            }
        }

        public void AddItem(OrderItem orderItem)
        {
            _itens.Add(orderItem);
        }
    }
}
