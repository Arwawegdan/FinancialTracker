namespace FinancialTracker.Shared;

public class User : BaseSettingsEntity
{
    public string? Password { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
}