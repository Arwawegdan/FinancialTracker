namespace FinancialTracker.Shared;

public class Expenses : BaseSettingsEntity
{
    public Guid UserId { get; set; }
    public string? Notes { get; set; }
    public ExpensesType ExpensesType { get; set; }
    public decimal Amount { get; set; }
    public Currency? Currency { get; set; }
    public Guid CurrencyId { get; set; }
}