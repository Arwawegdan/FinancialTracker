namespace FinancialTracker.Shared;

public class Currency : BaseSettingsEntity
{
    public decimal ExchangeRate { get; set; }
    public bool IsLocal { get; set; }
}