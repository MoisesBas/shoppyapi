
using ShoppyEx.Customer.Core.Domain.Customer.Events;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Customer.Core.Domain.Customer
{
    public class Customer: AggregateRoot<CustomerId>
    {      
        private readonly List<Address.CustomerAddress> _customerAddress = new();
        private readonly List<Card.Card> _cards = new();
        public string Name { get; private set; }  
        public Guid? UserId { get; private set; }
        public IEnumerable<Address.CustomerAddress> CustomerAddress => _customerAddress.AsReadOnly();
        public IEnumerable<Card.Card> Cards => _cards.AsReadOnly();
        protected Customer() {
           
        }       

        internal Customer(CustomerId id, string name, Guid? userId)
        {
            Id = id;
            Name = name;  
            UserId = userId;
            AddDomainEvent(new CustomerCreateEvent(id, Name));
        }
        public static Customer Create(CustomerId id, string name, Guid? userId)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));                
            return new Customer(id, name,userId);                      
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
