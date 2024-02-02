using Microsoft.EntityFrameworkCore;
using TdxBackend.Domain.Entities;

namespace TdxBackend
{
    public class DbContextTdx : DbContext
    {
        public DbSet<TaskTdx> TaskTdx { get; set; }
        public DbSet<StateTask> StateTask { get; set; }

        public DbContextTdx(DbContextOptions<DbContextTdx> options) : base(options)
        {

        }
    }
}
