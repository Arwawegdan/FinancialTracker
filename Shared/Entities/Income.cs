namespace FinancialTracker.Shared;

public class Income : BaseSettingsEntity
{
    public Guid UserId { get; set; }
    public decimal Amount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}