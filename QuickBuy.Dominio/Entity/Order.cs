using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuickBuy.Domain.Entity
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string  CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FullAdress { get; set; }
        public int AdressNumber { get; set; }
        public int PaymentFormId { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }


        public virtual ICollection<ItemOrder> ItemOrders { get; set; }

        public override void Validate() {
            ClearValidationMessage();
            if (!ItemOrders.Any()) {
                AddMessage("ERROR: Pedido não pode ficar vazio");
            }
            if (string.IsNullOrEmpty(CEP)) {
                AddMessage("ERROR: CEP não pode ficar vazio");
            }
            if (PaymentFormId == 0) {
                AddMessage("ERROR: forma de pagamento não informada");
            }
        }


    }
}
