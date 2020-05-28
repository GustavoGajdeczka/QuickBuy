using QuickBuy.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ValueObject
{
    public class PaymentForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBoleto 
        { 
            get { return Id == (int)TypePaymentFormEnum.Boleto; }    
        }
        public bool IsCreditCard {
            get { return Id == (int)TypePaymentFormEnum.CreditCard; }
        }
        public bool IsDeposit {
            get { return Id == (int)TypePaymentFormEnum.Deposit; }
        }
        public bool IsUndefined {
            get { return Id == (int)TypePaymentFormEnum.Undefined; }
        }

    }

}
