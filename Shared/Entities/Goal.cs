namespace FinancialTracker.Shared;

public class Goal : BaseSettingsEntity
{
    public Guid UserId { get; set; }
    public string? Notes { get; set; }
    public DateTime TargetDate { get; set; }
}
