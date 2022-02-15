using ShoppyEx.Customer.Core.Domain.Customer;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Customer.Core.Domain.Card
{
    public class Card: Entity<CardId>
    {
        public string CreditCard { get; private set; }
        public int CreditCardTypeID { get; private set; }
        public int CardExpMo { get; private set; }
        public int CardExpYr { get; private set; }
        public CustomerId CustomerId { get; private set; }
        public bool IsPrimary { get; private set; }
        public Customer.Customer Customer { get; private set; }
        public Card() { }
        internal Card(CardId id, string creditCard, 
            int creditCardTypeID, 
            int cardExpMo, 
            int cardExpYr, 
            bool isPrimary, 
            CustomerId customerId)
        {
            Id = id;
            CreditCard = creditCard;
            CreditCardTypeID = creditCardTypeID;
            CardExpMo = cardExpMo;
            CardExpYr = cardExpYr;
            CustomerId = customerId;
            IsPrimary = isPrimary;
        }
        public static Card Create(string creditCard,

            int creditCardTypeID,
            int cardExpMo,
            int cardExpYr,
            bool isPrimary,
            CustomerId customerId)
        {
            var cardId = new CardId(Guid.NewGuid());
            return new Card(cardId, creditCard,
            creditCardTypeID,
            cardExpMo,
            cardExpYr,
            isPrimary,
            customerId);
        }
    }
}
