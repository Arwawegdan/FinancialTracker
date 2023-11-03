namespace FinancialTracker.Server;
public class UserConfiguration : BaseSettingsEntityConfiguration<User>, IEntityTypeConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("Users");
    }
}