
using ShoppyEx.Customer.Core.Domain.Customer;

namespace ShoppyEx.Customer.Core.Domain.Address
{
    public class BillingAddress:SupAddress
    {
        public BillingAddress() { }
        internal BillingAddress(AddressId id, string city, string country, string address, string region, string postalCode, CustomerId customerId)
            : base(id, city, country, address, region, postalCode, customerId)
        {

        }
        public static BillingAddress Create(string city, string country, string address, string region, string postalCode, CustomerId customerId)
        {
            var addressId = new AddressId(Guid.NewGuid());
            return new BillingAddress(addressId, city, country, address, region, postalCode, customerId);
        }
    }
}
