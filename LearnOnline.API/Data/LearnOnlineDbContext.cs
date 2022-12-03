using LearnOnline.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LearnOnline.API.Data
{
    public class LearnOnlineDbContext : DbContext
    {
        public LearnOnlineDbContext(DbContextOptions<LearnOnlineDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserHistory> UserHistories { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 8342,
                    UserName = "admin",
                    Email = "admin@gmail.com"
                    //PassWord = hasher.HashPassword(null, "admin123"),
                }
                );
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                IdUser = 8342,
                IdRole = 4421
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 4421,
                RoleName = "admin"
            });
            modelBuilder.Entity<UserHistory>()
           .HasData(new UserHistory
           {
               IdUser = 8342,
               IdHistory = 1
           });
           
            modelBuilder.Entity<History>().HasData(new History
            {
                Id = 1,
                Date = new System.DateTime(),
                //IdPart = ,
                TotalScore = 100,
            });
            // fluent
            modelBuilder.Entity<UserHistory>().HasKey(t => new { t.IdUser, t.IdHistory });
            modelBuilder.Entity<UserInformation>().HasKey(t => new {t.IdUser,t.IdInformation});
            modelBuilder.Entity<UserRole>().HasKey(t => new { t.IdUser, t.IdRole });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
