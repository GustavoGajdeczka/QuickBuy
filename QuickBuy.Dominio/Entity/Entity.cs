using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entity
{
    public abstract class Entity
    {
        public List<string> _validationMessage { get; set; }
        private List<string> ValidationMessage {
            get { return _validationMessage ?? (_validationMessage = new List<string>()); }
        }

        protected void ClearValidationMessage() {
            ValidationMessage.Clear();
        }
        protected void AddMessage(string message) {
            ValidationMessage.Add(message);
        }
        public abstract void Validate();
        protected bool IsValid { 
            get { return !ValidationMessage.Any();  }
        }
    }
}
