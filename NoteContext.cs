using Microsoft.EntityFrameworkCore;
using net6_note_system.Models;

namespace net6_note_system
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options)
            : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var conn = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=NoteSystem;Integrated Security=True";
            builder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Note>().ToTable("Note");
        }
    }
}
