using LearnOnline.Models;
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
            //news
            modelBuilder.Entity<New>().HasData(new New
            {
                Id = 1,
                Title = "IELTS Tranning đồng hành cùng Career Explore Program 2022",
                Description = "Ngày 23/7 vừa qua, sự kiện đã chính thức diễn ra với sự tham gia đông đảo của hơn 100 bạn sinh viên và những " +
                "diễn giả đến từ các doanh nghiệp nổi tiếng trên cả nước. IELTS Fighter hân hạnh được mời làm Nhà tài trợ vàng cho chương trình, " +
                "đem những giá trị cả về hiện kim và tinh thần đến cho các bạn sinh viên." +
                "1. Career Explore Program FTU “Career Explore Program: Roadmap to dream university” " +
                "là sự kiện do câu lạc bộ FBA Elite kết hợp với khoa Quản trị kinh doanh Đại học Ngoại " +
                "Thương tổ chức, với mục đích giúp các bạn sinh viên có thể định hướng được nghề nào phù hợp với bản thân mình, " +
                "với xu hướng và yêu cầu của thị trường lao động hiện tại. " +
                "Đứng ở cương vị là nhà tài trợ vàng, IELTS Fighter cảm thấy vô cùng vui mừng khi thấy tinh thần nhiệt huyết và sự nghiêm túc," +
                " nhanh nhạy của các bạn trẻ hiện nay, khi sớm theo đuổi sự phát triển toàn diện cho bản thân, đến với sự kiện với lòng ham học hỏi " +
                "và tinh thần cầu tiến, muốn trở nên xuất sắc hơn mỗi ngày.",
                Image = "new1.jpg",
                UserId = 8342
            });

            modelBuilder.Entity<New>().HasData(new New
            {
                Id = 2,
                Title = "Tháng 7 “cháy” hết mình cùng các Workshop học IELTS",
                Description = "Trong lúc các học sinh khác đang thong thả nghỉ hè thì tại IELTS Fighter những Chiến binh chăm chỉ đang “đắm mình”" +
                " trong loạt Workshop Định hướng học IELTS hiệu quả, chuẩn bị sẵn sàng cho một năm học mới rực rỡ hơn." +
                "Workshop “Học IELTS Listening hiệu quả” tại cơ sở 44 Trần Quốc Hoàn và 22 Nguyễn Hoàng. " +
                "Ngoài các buổi học bổ trợ chuyên sâu về Listening thì những buổi chia sẻ kinh nghiệm của thầy cô giỏi, các học viên điểm cao đi trước " +
                "là bí kíp giúp học viên tại IELTS Fighter luôn dành được điểm Listening cao trong bài thi IELTS.",
                Image = "new2.jpg",
                UserId = 8342
            });

            modelBuilder.Entity<New>().HasData(new New
            {
                Id = 3,
                Title = "IELTS Fighter tổ chức RUNG CHUÔNG VÀNG tại nhiều trường học",
                Description = "Dự án IELTS Fighter Here and There là một hoạt động vì cộng đồng của IELTS Fighter," +
                " triển khai tại các trường THCS, THPT và đại học khắp VN nhằm giúp các em học sinh, sinh viên có cái nhìn gần gũi," +
                " thân thiện hơn với tiếng Anh. Thông qua dự án giao lưu và chia sẻ những phương pháp, kinh nghiệm học và trao tặng " +
                "nhiều phần quà giá trị giúp các bạn học sinh chinh phục ngôn ngữ dễ dàng và nhanh chóng hơn, IELTS Fighter cổ vũ và truyền lửa tình yêu," +
                " lan tỏa đam mê với ngoại ngữ này cho các bạn trẻ Việt Nam. Tính đến hiện tại, IELTS Fighter Here and There đã đặt chân đến hàng loạt các trường Cấp 2, " +
                "Cấp 3, Đại học ở nhiều tỉnh thành như: Trường THPT Tân Phong, trường Chuyên THPT Nguyễn Huệ, THPT Nguyễn Hữu Cầu, Đại học Ngoại thương, Đại học Thương Mại," +
                " Đại học Nông Nghiệp... Danh sách ấy vẫn liên tục được nối dài.",
                Image = "new3.jpg",
                UserId = 8342
            });

            modelBuilder.Entity<New>().HasData(new New
            {
                Id = 4,
                Title = "IELTS Fighter tổ chức RUNG CHUÔNG VÀNG tại nhiều trường học",
                Description = "Dự án IELTS Fighter Here and There là một hoạt động vì cộng đồng của IELTS Fighter," +
               " triển khai tại các trường THCS, THPT và đại học khắp VN nhằm giúp các em học sinh, sinh viên có cái nhìn gần gũi," +
               " thân thiện hơn với tiếng Anh. Thông qua dự án giao lưu và chia sẻ những phương pháp, kinh nghiệm học và trao tặng " +
               "nhiều phần quà giá trị giúp các bạn học sinh chinh phục ngôn ngữ dễ dàng và nhanh chóng hơn, IELTS Fighter cổ vũ và truyền lửa tình yêu," +
               " lan tỏa đam mê với ngoại ngữ này cho các bạn trẻ Việt Nam. Tính đến hiện tại, IELTS Fighter Here and There đã đặt chân đến hàng loạt các trường Cấp 2, " +
               "Cấp 3, Đại học ở nhiều tỉnh thành như: Trường THPT Tân Phong, trường Chuyên THPT Nguyễn Huệ, THPT Nguyễn Hữu Cầu, Đại học Ngoại thương, Đại học Thương Mại," +
               " Đại học Nông Nghiệp... Danh sách ấy vẫn liên tục được nối dài.",
                Image = "new3.jpg",
                UserId = 8342
            });

            modelBuilder.Entity<New>().HasData(new New
            {
                Id = 5,
                Title = "IELTS Fighter tổ chức RUNG CHUÔNG VÀNG tại nhiều trường học",
                Description = "Dự án IELTS Fighter Here and There là một hoạt động vì cộng đồng của IELTS Fighter," +
               " triển khai tại các trường THCS, THPT và đại học khắp VN nhằm giúp các em học sinh, sinh viên có cái nhìn gần gũi," +
               " thân thiện hơn với tiếng Anh. Thông qua dự án giao lưu và chia sẻ những phương pháp, kinh nghiệm học và trao tặng " +
               "nhiều phần quà giá trị giúp các bạn học sinh chinh phục ngôn ngữ dễ dàng và nhanh chóng hơn, IELTS Fighter cổ vũ và truyền lửa tình yêu," +
               " lan tỏa đam mê với ngoại ngữ này cho các bạn trẻ Việt Nam. Tính đến hiện tại, IELTS Fighter Here and There đã đặt chân đến hàng loạt các trường Cấp 2, " +
               "Cấp 3, Đại học ở nhiều tỉnh thành như: Trường THPT Tân Phong, trường Chuyên THPT Nguyễn Huệ, THPT Nguyễn Hữu Cầu, Đại học Ngoại thương, Đại học Thương Mại," +
               " Đại học Nông Nghiệp... Danh sách ấy vẫn liên tục được nối dài.",
                Image = "new3.jpg",
                UserId = 8342
            });

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                UserId = 8342,
                RoleId = 4421
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 4421,
                RoleName = "admin"
            });
            modelBuilder.Entity<UserHistory>()
           .HasData(new UserHistory
           {
               UserId = 8342,
               HistoryId = 1
           });

            modelBuilder.Entity<History>().HasData(new History
            {
                Id = 1,
                Date = new System.DateTime(),
                PartId = 1,
                TotalScore = 100,
            });
            modelBuilder.Entity<Part>().HasData(new Part
            {
                Id = 1,
                CategoryId = 1,
                SkillId = 1,
                LevelId = 1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                CategoryName = "acb"
            });
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 1,
                SkillName = "Reading"
            });
            modelBuilder.Entity<Level>().HasData(new Level
            {
                Id = 1,
                LevelName = "450"
            });
            // fluent
            modelBuilder.Entity<UserHistory>().HasKey(t => new { t.UserId, t.HistoryId });
            modelBuilder.Entity<UserInformation>().HasKey(t => new { t.UserId, t.InformationId });
            modelBuilder.Entity<UserRole>().HasKey(t => new { t.UserId, t.RoleId });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
