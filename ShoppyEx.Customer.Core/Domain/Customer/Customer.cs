
using ShoppyEx.Customer.Core.Domain.Customer.Events;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Customer.Core.Domain.Customer
{
    public class Customer: AggregateRoot<CustomerId>
    {
        private readonly List<Address.BillingAddress> _billingAddress = new();
        private readonly List<Address.ShippingAddress> _shippingAddress = new();
        private readonly List<Address.CustomerAddress> _customerAddress = new();
        private readonly List<Card.Card> _cards = new();
        public string Name { get; private set; } 
        public IEnumerable<Address.BillingAddress> BillingAddress => _billingAddress.AsReadOnly();
        public IEnumerable<Address.ShippingAddress> ShippingAddress => _shippingAddress.AsReadOnly();
        public IEnumerable<Address.CustomerAddress> CustomerAddress => _customerAddress.AsReadOnly();
        public IEnumerable<Card.Card> Cards => _cards.AsReadOnly();
        protected Customer() {
           
        }       

        internal Customer(CustomerId id, string name)
        {
            Id = id;
            Name = name;           
            AddDomainEvent(new CustomerCreateEvent(id, Name));
        }
        public static Customer Create(CustomerId id, string name)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));                
            return new Customer(id, name);                      
        } 
        public void AddBillingAddress(Address.BillingAddress address) 
        {
            _billingAddress.Add(address);
        }
        public void AddShippingAddress(Address.ShippingAddress address)
        {
            _shippingAddress.Add(address);
        }
        public void AddAddress(Address.CustomerAddress address)
        {
            _customerAddress.Add(address);
        }
        public void AddCard(Card.Card card)
        {
            _cards.Add(card);
        }
    }
}
