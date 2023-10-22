namespace FinancialTracker.Shared;

public class Budget : BaseSettingsEntity
{
    public Guid UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
