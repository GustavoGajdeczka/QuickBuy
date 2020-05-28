using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entity
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public override void Validate() {
            if (string.IsNullOrEmpty(Email)) {
                AddMessage("ERRO: email não informado");
            }
            if (string.IsNullOrEmpty(Password)) {
                AddMessage("ERRO: senha não informada");
            }
        }
    }
}
