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
        public DbSet<UserHistory> UserHistories { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Question> Question { get; set; }
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

            modelBuilder.Entity<Part>().HasData(new Part
            {
                Id = 1,
                CategoryId = 1,
                Title = "LOOKING IN THE TELESCOPE",
                SkillId = 2,
                LevelId = 1,
                Image = "UNIT1.PNG",
                Record = "Unit 1, Test 1.mp3",
                Score = 10,
                Note = @"
                A story is told that around 400 years ago some children were fooling around in an eye glass shop. They noticed that when they placed lenses one on top of the other, they were able to see a considerable distance. They played around with the concept for a while, experimenting with what happened when they varied the distance between the lenses. Hans Lippershey, the Dutch lens maker who eventually applied for the first telescope patent, credits children as having been his motivation for the invention of the first telescope.

                The first telescopes built in the early 1600s were very primitive inventions allowing the user to see around 3-times further than the naked eye. It was not too long however, until Italian astronomer Galileo heard about the invention ‘that through use of correctly-positioned lenses, allowed people to see things a long way away’. The tools used in the manufacturing of the first refracting telescope was all Galileo needed to know and within 24 hours he had developed a better one. In fact, the process of improvements Galileo made on Lippershey’s telescope were quite dramatic. Whereas the original version had a magnification of 3, the new telescope had a magnification of around 30. Galileo achieved these extraordinary results by figuring out the combination of the positions of the lenses and also by making his own lenses which were of better quality. Although he originally thought they were stars, the better quality lenses – and some scientific analysis – enabled him to eventually use his telescopes to see the moons of Jupiter. Galileo’s refracting telescopes – so-called due to the way they handled the light that passed through them – were the standard at that time.

                Some 70 years later, British scientist Isaac Newton, explored the way a prism refracts 1 white light into an array of colors. He recognised that a lens was a circular prism and that the separation of colors limited the effectiveness of the telescopes in use at the time. Newton created a Reflective Telescope, one that used a dish-shaped or parabolic mirror to collect light and concentrate the image before it was visible in the eyepiece. Thus, lenses used for magnification in telescopes were replaced by mirrors. Mirrors have since been the standard for telescopes. In fact, according to telescope researcher Dr. Carl Addams, the basic designs of telescopes have not changed much in the last 100 years. What has changed however, is the way technology has been used to improve them. For example, the larger telescopes in the world today are around 10 metres in diameter and the mirrors placed within them are so finely polished that even at the microscopic level there are no scratches or bumps on them at all. To achieve such a flawless surface requires a very expensive process that operates with the utmost precision.

                1: The separation or change of direction of a ray of light when passed through a glass of water.

                The mid 1700s, saw the discovery and production of the Achromatic telescope. This type of telescope differed from previous ones in the way it handled the different wavelengths of light. The first person who succeeded in making achromatic refracting telescopes seems to have been the Englishman, Chester Moore Hall. The telescope design used two pieces of special optical glass known as crown and flint Each side of each piece was ground and polished and then the two pieces were assembled together. Achromatic lenses bring two wavelengths – typically red and blue – into focus in the same plane. Makers of achromatic telescopes had difficulty locating disks of flint glass of suitable purity needed to construct them. In the late 1700s, prizes were offered by the French Academy of Sciences for any chemist or glass-manufacturer that could create perfect discs of optical flint glass however, no one was able to provide a large disk of suitable purity and clarity.

                Currently the largest telescopes are around eight to ten metres in size. These extremely expensive and sophisticated pieces of equipment are located primarily throughout Europe and America. Dr Addams believes that the telescopes of the future will be a gigantic improvement in what is currently considered state-of-the-art. Telescopes that are 20 or 30 metres in diameter are currently being planned, and there has been a suggestion put forward by a European firm that they would like to build a 100-metre telescope. Says Addams, ‘The quality of the glass needed to build a 100 meter telescope is like building a lens the size of a football field and having the largest bump in that football field being a ten-thousandth of a human hair’. The engineering and technology required to build such a flawless reflective surface is most impressive.
                ",
            });
            //Question
            //modelBuilder.Entity<Question>().HasData(new Question
            //{
            //    Id = 1,
            //    Content = "According to the writer, the first telescope was",
            //    Result = "B",
            //    PartId = 1
            //});
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
            //Answer
            modelBuilder.Entity<Answer>().HasData(new Answer
            {
                Id = 1,
                QuestionId = 1,
                Title = "A",
                Content = "invented by children."
            });

            modelBuilder.Entity<Answer>().HasData(new Answer
            {
                Id = 2,
                QuestionId = 1,
                Title = "B",
                Content = "made by a lens maker."
            });
            modelBuilder.Entity<Answer>().HasData(new Answer
            {
                Id = 3,
                QuestionId = 1,
                Title = "C",
                Content = "a reflective telescope."
            });
            modelBuilder.Entity<Answer>().HasData(new Answer
            {
                Id = 4,
                QuestionId = 1,
                Title = "D",
                Content = "quite a complex piece of equipment."
            });
            //Categories

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

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                CategoryName = "Unit"
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
            // fluent
            modelBuilder.Entity<UserHistory>().HasKey(t => new { t.UserId, t.HistoryId });
            modelBuilder.Entity<UserInformation>().HasKey(t => new { t.UserId, t.InformationId });
            modelBuilder.Entity<UserRole>().HasKey(t => new { t.UserId, t.RoleId });
        }
    }
}
