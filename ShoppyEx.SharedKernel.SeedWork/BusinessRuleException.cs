using System;

namespace ShoppyEx.SharedKernel.SeedWork;

public class BusinessRuleException : Exception
{
    public BusinessRuleException(string message) : base(message) { }
}