using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnOnline.API.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Record = table.Column<byte>(type: "tinyint", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parts_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parts_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spelling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInformations",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformations", x => new { x.UserId, x.InformationId });
                    table.ForeignKey(
                        name: "FK_UserInformations_Informations_InformationId",
                        column: x => x.InformationId,
                        principalTable: "Informations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInformations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartId = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Histories_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserHistories",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    HistoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHistories", x => new { x.UserId, x.HistoryId });
                    table.ForeignKey(
                        name: "FK_UserHistories_Histories_HistoryId",
                        column: x => x.HistoryId,
                        principalTable: "Histories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[] { 1, "acb", null });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Description", "LevelName", "Note" },
                values: new object[] { 1, null, "450", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { 4421, "admin" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Note", "SkillName" },
                values: new object[] { 1, null, null, "Reading" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { 8342, "admin@gmail.com", null, null, "admin" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Description", "Image", "Note", "Spelling", "Title", "Topic", "UserId" },
                values: new object[,]
                {
                    { 1, "Ngày 23/7 vừa qua, sự kiện đã chính thức diễn ra với sự tham gia đông đảo của hơn 100 bạn sinh viên và những diễn giả đến từ các doanh nghiệp nổi tiếng trên cả nước. IELTS Fighter hân hạnh được mời làm Nhà tài trợ vàng cho chương trình, đem những giá trị cả về hiện kim và tinh thần đến cho các bạn sinh viên.1. Career Explore Program FTU “Career Explore Program: Roadmap to dream university” là sự kiện do câu lạc bộ FBA Elite kết hợp với khoa Quản trị kinh doanh Đại học Ngoại Thương tổ chức, với mục đích giúp các bạn sinh viên có thể định hướng được nghề nào phù hợp với bản thân mình, với xu hướng và yêu cầu của thị trường lao động hiện tại. Đứng ở cương vị là nhà tài trợ vàng, IELTS Fighter cảm thấy vô cùng vui mừng khi thấy tinh thần nhiệt huyết và sự nghiêm túc, nhanh nhạy của các bạn trẻ hiện nay, khi sớm theo đuổi sự phát triển toàn diện cho bản thân, đến với sự kiện với lòng ham học hỏi và tinh thần cầu tiến, muốn trở nên xuất sắc hơn mỗi ngày.", "new1.jpg", null, null, "IELTS Tranning đồng hành cùng Career Explore Program 2022", null, 8342 },
                    { 2, "Trong lúc các học sinh khác đang thong thả nghỉ hè thì tại IELTS Fighter những Chiến binh chăm chỉ đang “đắm mình” trong loạt Workshop Định hướng học IELTS hiệu quả, chuẩn bị sẵn sàng cho một năm học mới rực rỡ hơn.Workshop “Học IELTS Listening hiệu quả” tại cơ sở 44 Trần Quốc Hoàn và 22 Nguyễn Hoàng. Ngoài các buổi học bổ trợ chuyên sâu về Listening thì những buổi chia sẻ kinh nghiệm của thầy cô giỏi, các học viên điểm cao đi trước là bí kíp giúp học viên tại IELTS Fighter luôn dành được điểm Listening cao trong bài thi IELTS.", "new2.jpg", null, null, "Tháng 7 “cháy” hết mình cùng các Workshop học IELTS", null, 8342 },
                    { 3, "Dự án IELTS Fighter Here and There là một hoạt động vì cộng đồng của IELTS Fighter, triển khai tại các trường THCS, THPT và đại học khắp VN nhằm giúp các em học sinh, sinh viên có cái nhìn gần gũi, thân thiện hơn với tiếng Anh. Thông qua dự án giao lưu và chia sẻ những phương pháp, kinh nghiệm học và trao tặng nhiều phần quà giá trị giúp các bạn học sinh chinh phục ngôn ngữ dễ dàng và nhanh chóng hơn, IELTS Fighter cổ vũ và truyền lửa tình yêu, lan tỏa đam mê với ngoại ngữ này cho các bạn trẻ Việt Nam. Tính đến hiện tại, IELTS Fighter Here and There đã đặt chân đến hàng loạt các trường Cấp 2, Cấp 3, Đại học ở nhiều tỉnh thành như: Trường THPT Tân Phong, trường Chuyên THPT Nguyễn Huệ, THPT Nguyễn Hữu Cầu, Đại học Ngoại thương, Đại học Thương Mại, Đại học Nông Nghiệp... Danh sách ấy vẫn liên tục được nối dài.", "new3.jpg", null, null, "IELTS Fighter tổ chức RUNG CHUÔNG VÀNG tại nhiều trường học", null, 8342 },
                    { 4, "Dự án IELTS Fighter Here and There là một hoạt động vì cộng đồng của IELTS Fighter, triển khai tại các trường THCS, THPT và đại học khắp VN nhằm giúp các em học sinh, sinh viên có cái nhìn gần gũi, thân thiện hơn với tiếng Anh. Thông qua dự án giao lưu và chia sẻ những phương pháp, kinh nghiệm học và trao tặng nhiều phần quà giá trị giúp các bạn học sinh chinh phục ngôn ngữ dễ dàng và nhanh chóng hơn, IELTS Fighter cổ vũ và truyền lửa tình yêu, lan tỏa đam mê với ngoại ngữ này cho các bạn trẻ Việt Nam. Tính đến hiện tại, IELTS Fighter Here and There đã đặt chân đến hàng loạt các trường Cấp 2, Cấp 3, Đại học ở nhiều tỉnh thành như: Trường THPT Tân Phong, trường Chuyên THPT Nguyễn Huệ, THPT Nguyễn Hữu Cầu, Đại học Ngoại thương, Đại học Thương Mại, Đại học Nông Nghiệp... Danh sách ấy vẫn liên tục được nối dài.", "new3.jpg", null, null, "IELTS Fighter tổ chức RUNG CHUÔNG VÀNG tại nhiều trường học", null, 8342 },
                    { 5, "Dự án IELTS Fighter Here and There là một hoạt động vì cộng đồng của IELTS Fighter, triển khai tại các trường THCS, THPT và đại học khắp VN nhằm giúp các em học sinh, sinh viên có cái nhìn gần gũi, thân thiện hơn với tiếng Anh. Thông qua dự án giao lưu và chia sẻ những phương pháp, kinh nghiệm học và trao tặng nhiều phần quà giá trị giúp các bạn học sinh chinh phục ngôn ngữ dễ dàng và nhanh chóng hơn, IELTS Fighter cổ vũ và truyền lửa tình yêu, lan tỏa đam mê với ngoại ngữ này cho các bạn trẻ Việt Nam. Tính đến hiện tại, IELTS Fighter Here and There đã đặt chân đến hàng loạt các trường Cấp 2, Cấp 3, Đại học ở nhiều tỉnh thành như: Trường THPT Tân Phong, trường Chuyên THPT Nguyễn Huệ, THPT Nguyễn Hữu Cầu, Đại học Ngoại thương, Đại học Thương Mại, Đại học Nông Nghiệp... Danh sách ấy vẫn liên tục được nối dài.", "new3.jpg", null, null, "IELTS Fighter tổ chức RUNG CHUÔNG VÀNG tại nhiều trường học", null, 8342 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "LevelId", "Note", "Record", "Score", "SkillId", "Style", "Title" },
                values: new object[] { 1, 1, null, null, 1, null, (byte)0, 0, 1, null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 4421, 8342 });

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "Date", "PartId", "TotalScore" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100 });

            migrationBuilder.InsertData(
                table: "UserHistories",
                columns: new[] { "HistoryId", "UserId" },
                values: new object[] { 1, 8342 });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_PartId",
                table: "Answer",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_PartId",
                table: "Histories",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_News_UserId",
                table: "News",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_CategoryId",
                table: "Parts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_LevelId",
                table: "Parts",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_SkillId",
                table: "Parts",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHistories_HistoryId",
                table: "UserHistories",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformations_InformationId",
                table: "UserInformations",
                column: "InformationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "UserHistories");

            migrationBuilder.DropTable(
                name: "UserInformations");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
