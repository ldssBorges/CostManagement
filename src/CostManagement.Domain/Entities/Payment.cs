using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostManagement.Domain.Entities
{
    public class Payment
    {
        public EPaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
