using ShoppyEx.SharedKernel.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyEx.Order.Core.Domain.Order
{
    public sealed class DeliveryId : StronglyTypedId<DeliveryId>
    {
        public DeliveryId(Guid value) : base(value)
        {
        }
    }
}
