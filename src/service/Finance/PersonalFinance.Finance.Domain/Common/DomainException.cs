namespace PersonalFinance.Finance.Domain.Common;

/// <summary>
/// Domain exceptions. Ex.: Account is closed, Value cannot be zero, budget can't be negative value.
/// </summary>
public class DomainException : Exception
{
    public DomainException(string message) : base(message)
    {

    }

}
