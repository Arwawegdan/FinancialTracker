namespace FinancialTracker.Shared;
public class BaseSettingValidator<TEntity> : AbstractValidator<TEntity>
    where TEntity : BaseSettingsEntity
{
    public BaseSettingValidator()
    {
        const int nameMaxLength = 20;

        RuleFor(e => e.Name).NotEmpty().WithMessage($"{nameof(TEntity)} Name is not empty");
        RuleFor(e => e.Name).MaximumLength(nameMaxLength).WithMessage($"{nameof(TEntity)} Name max length = {nameMaxLength}");
    }
}

