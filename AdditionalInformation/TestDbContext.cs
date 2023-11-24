using ClassLibrary1;
using Microsoft.EntityFrameworkCore;

namespace AdditionalInformation
{
    public class TestDbContext :DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext>options) : base(options) { }

        public DbSet<UserManagement> Users { get; set; }
    }
}
