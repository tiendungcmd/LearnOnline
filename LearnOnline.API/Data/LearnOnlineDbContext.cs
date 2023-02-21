using LearnOnline.Models;
using LearnOnline.Models.Entities;
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
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();
            base.OnModelCreating(modelBuilder);
            //news
            modelBuilder.Entity<Part>().HasData(new Part
            {
                Id = 1,
                CategoryId = 1,
                Title = "LOOKING IN THE TELESCOPE",
                SkillId = 2,
                LevelId = 1,
                Image = "UNIT1.PNG",
                Score = 10,
            });
          
            modelBuilder.Entity<Question>().HasData(new Question
            {
                Id = 1,
                Content = "1",
                Result = "B",
                PartId = 1
            });
            modelBuilder.Entity<Question>().HasData(new Question
            {
                Id = 2,
                Content = "2",
                Result = "B",
                PartId = 1
            });
            modelBuilder.Entity<Question>().HasData(new Question
            {
                Id = 3,
                Content = "3",
                Result = "B",
                PartId = 1
            });
            modelBuilder.Entity<Question>().HasData(new Question
            {
                Id = 4,
                Content = "4",
                Result = "B",
                PartId = 1
            });
            modelBuilder.Entity<Question>().HasData(new Question
            {
                Id = 5,
                Content = "5",
                Result = "B",
                PartId = 1
            });
           
            //Categories

           

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                CategoryName = "Đề thi tháng 1 năm 2023"
            });
            //Skill - reading -listening
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 1,
                SkillName = "Reading"
            });
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 2,
                SkillName = "Listening"
            });
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 3,
                SkillName = "Speaking"
            });
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 4,
                SkillName = "Writing"
            });
            modelBuilder.Entity<Level>().HasData(new Level
            {
                Id = 1,
                LevelName = "450"
            });
          
            modelBuilder.Entity<UserInformation>().HasKey(t => new { t.UserId, t.InformationId });
            modelBuilder.Entity<UserRole>().HasKey(t => new { t.UserId, t.RoleId });
        }
    }
}
