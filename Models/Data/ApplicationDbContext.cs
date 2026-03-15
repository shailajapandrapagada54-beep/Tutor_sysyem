using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineTutor.Models;

namespace Tutor_System.Models.Data
{
    

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Country> Countries => Set<Country>();
        public DbSet<State> States => Set<State>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<UserSubject> UserSubjects => Set<UserSubject>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);

            b.Entity<State>().HasOne(s => s.Country).WithMany(c => c.States).HasForeignKey(s => s.CountryId).OnDelete(DeleteBehavior.Cascade);
            b.Entity<City>().HasOne(c => c.State).WithMany(s => s.Cities).HasForeignKey(c => c.StateId).OnDelete(DeleteBehavior.Cascade);

            b.Entity<UserSubject>().HasKey(us => new { us.UserId, us.SubjectId });
            b.Entity<UserSubject>().HasOne(us => us.User).WithMany(u => u.UserSubjects).HasForeignKey(us => us.UserId);
            b.Entity<UserSubject>().HasOne(us => us.Subject).WithMany(s => s.UserSubjects).HasForeignKey(us => us.SubjectId);

            // Uniqueness requirements
            b.Entity<ApplicationUser>().HasIndex(u => u.Email).IsUnique();
            b.Entity<ApplicationUser>().HasIndex(u => u.PhoneNumber).IsUnique();
            b.Entity<Subject>().HasIndex(s => s.Name).IsUnique();
            b.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            b.Entity<State>().HasIndex(x => new { x.CountryId, x.Name }).IsUnique();
            b.Entity<City>().HasIndex(x => new { x.StateId, x.Name }).IsUnique();
        }
    }
}
