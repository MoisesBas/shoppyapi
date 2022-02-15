using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Customer.Core.Domain.Card
{   
    public sealed class CardId : StronglyTypedId<CardId>
    {
        public CardId(Guid value) : base(value)
        {
        }
    }
}
