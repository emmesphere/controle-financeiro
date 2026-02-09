namespace PersonalFinance.Finance.Domain.Common;

/// <summary>
/// Domain Event. It is not queue message. Ex.: TransactionRecorded. BudgetExceeded
/// </summary>
public class DomainEvent
{
    public DateTime EventTime { get; }

    protected DomainEvent()
    {

        EventTime = DateTime.UtcNow;
    }

}
