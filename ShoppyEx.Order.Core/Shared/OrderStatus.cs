using System.Runtime.Serialization;

namespace ShoppyEx.Order.Core.Shared;
public enum OrderStatus
{
    [EnumMember(Value = "Pending")]
    Pending,

    [EnumMember(Value = "PaymentReceived")]
    PaymentReceived,

    [EnumMember(Value = "PaymentFailed")]
    PaymentFailed
}