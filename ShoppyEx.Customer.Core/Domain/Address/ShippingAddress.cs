
using ShoppyEx.Customer.Core.Domain.Customer;

namespace ShoppyEx.Customer.Core.Domain.Address
{
    public class ShippingAddress : SupAddress
    {
        public ShippingAddress() { }
        internal ShippingAddress(AddressId id, string city, string country, string address, string region, string postalCode, CustomerId customerId)
            :base(id, city, country, address, region,postalCode,customerId) 
        {
            
        }
        public static ShippingAddress Create(string city, string country, string address, string region, string postalCode, CustomerId customerId)
        {
            var addressId = new AddressId(Guid.NewGuid());
            return new ShippingAddress(addressId,city, country, address, region, postalCode, customerId);
        }
    }
}
