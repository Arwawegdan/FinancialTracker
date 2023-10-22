using Microsoft.Extensions.Options;

namespace FinancialTracker;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
    }



    //protected override void OnModelCreating(ModelBuilder modelBuilder) { }


    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.ApplyConfiguration(new EmployeeConfiguration())
    //                .ApplyConfiguration(new StudentConfiguration())
    //                .ApplyConfiguration(new ClassRoomConfiguration())
    //                .ApplyConfiguration(new ClassRoomStudentConfiguration())
    //                .ApplyConfiguration(new SubjectConfiguration())
    //                .ApplyConfiguration(new TeacherConfiguration());
    //}
}