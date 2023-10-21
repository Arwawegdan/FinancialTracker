//namespace InnoBlazorWASM.Server;
//public class EmployeeConfiguration : BaseSettingsEntityConfiguration<Employee>, IEntityTypeConfiguration<Employee>
//{
//    public virtual new void Configure(EntityTypeBuilder<Employee> builder)
//    {
//        base.Configure(builder);

//        builder.ToTable("Employees");

//        builder.Property(e => e.Mobile).HasMaxLength(20);
//        builder.Property(e => e.Telephone).HasMaxLength(20);
//    }
//}