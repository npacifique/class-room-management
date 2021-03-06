using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassSchedule.Migrations
{
    public partial class createInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DayId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    MilitaryTime = table.Column<string>(maxLength: 4, nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    DayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_Classes_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[] { 1, "Monday" });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[] { 2, "Tuesday" });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[] { 3, "Wednesday" });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[] { 4, "Thursday" });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[] { 5, "Friday" });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[] { 6, "Saturday" });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[] { 7, "Sunday" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[] { 1, "Anne", "Sullivan" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[] { 2, "Maria", "Montessori" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[] { 3, "Martin Luther", "King" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[] { 4, "", "Aristotle" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[] { 5, "Jaime", "Escalante" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 1, 1, "1500", 101, 1, "Sign Language" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 2, 2, "1100", 301, 1, "Sign Language" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 5, 3, "1000", 101, 2, "Early Childhood Education" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 6, 5, "1000", 401, 2, "Early Childhood Education" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 9, 4, "1400", 101, 3, "Nonviolence and Social Change" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 10, 5, "1400", 201, 3, "Nonviolence and Social Change" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 3, 4, "1300", 101, 4, "Logic" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 4, 4, "1500", 201, 4, "Logic" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 7, 1, "1300", 101, 5, "Calculus" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "DayId", "MilitaryTime", "Number", "TeacherId", "Title" },
                values: new object[] { 8, 3, "1300", 201, 5, "Calculus" });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_DayId",
                table: "Classes",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherId",
                table: "Classes",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
