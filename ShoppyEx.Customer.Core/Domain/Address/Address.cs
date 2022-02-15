
using ShoppyEx.Customer.Core.Domain.Customer;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Customer.Core.Domain.Address
{
    public abstract class SupAddress :Entity<AddressId>
    {
       public string Address { get; private set; }
       public string City { get; private set;}
       public string Region { get; private set; }
       public string PostalCode { get; private set; }
       public string Country { get; private set; }       
        public Customer.Customer Customer { get; private set; }
        public CustomerId CustomerId { get; private set; }
        public SupAddress() { }
        internal SupAddress(AddressId id, string city, string country, string address, string region, string postalCode, CustomerId customerId)
        {
            Id = id;
            City = city;
            Country = country; 
            Address = address;
            Region = region;
            PostalCode = postalCode;
            CustomerId = customerId;
        }
           
    }
}