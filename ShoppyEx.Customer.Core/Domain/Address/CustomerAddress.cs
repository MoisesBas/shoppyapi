using ShoppyEx.Customer.Core.Domain.Customer;

namespace ShoppyEx.Customer.Core.Domain.Address
{
    public class CustomerAddress:SupAddress
    {
        public string Address1 { get; private set; }
        public CustomerAddress() { }
        internal CustomerAddress(AddressId id, string city, string country, string address, string address1,
            string region, string postalCode, CustomerId customerId)
            : base(id, city, country, address, region, postalCode, customerId)
        {
            Address1 = address1;
        }
        public static CustomerAddress Create(string city, string country, string address, string address1, string region, string postalCode, CustomerId customerId)
        {
            var addressId = new AddressId(Guid.NewGuid());
            return new CustomerAddress(addressId, city, country, address,address1, region, postalCode, customerId);
        }
    }
}
