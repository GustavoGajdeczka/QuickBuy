using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string  CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FullAdress { get; set; }
        public int AdressNumber { get; set; }
        public PaymentForm PaymentForm { get; set; }
        public int PaymentFormId { get; set; }


        public ICollection<ItemOrder> ItemOrders { get; set; }


    }
}
