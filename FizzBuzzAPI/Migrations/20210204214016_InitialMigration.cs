using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzzAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FizzBuzzStoretbl",
                columns: table => new
                {
                    FizzBuzzStoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FizzBuzzValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FizzBuzzStoretbl", x => x.FizzBuzzStoreID);
                });

            migrationBuilder.InsertData(
                table: "FizzBuzzStoretbl",
                columns: new[] { "FizzBuzzStoreID", "FizzBuzzValue" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 73, "73" },
                    { 72, "Fizz" },
                    { 71, "71" },
                    { 70, "Buzz" },
                    { 69, "Fizz" },
                    { 68, "68" },
                    { 67, "67" },
                    { 66, "Fizz" },
                    { 65, "Buzz" },
                    { 64, "64" },
                    { 63, "Fizz" },
                    { 62, "62" },
                    { 61, "61" },
                    { 60, "FizzBuzz" },
                    { 59, "59" },
                    { 58, "58" },
                    { 57, "Fizz" },
                    { 56, "56" },
                    { 55, "Buzz" },
                    { 54, "Fizz" },
                    { 53, "53" },
                    { 74, "74" },
                    { 52, "52" },
                    { 75, "FizzBuzz" },
                    { 77, "77" },
                    { 98, "98" },
                    { 97, "97" },
                    { 96, "Fizz" },
                    { 95, "Buzz" },
                    { 94, "94" },
                    { 93, "Fizz" },
                    { 92, "92" },
                    { 91, "91" },
                    { 90, "FizzBuzz" },
                    { 89, "89" },
                    { 88, "88" },
                    { 87, "Fizz" },
                    { 86, "86" },
                    { 85, "Buzz" },
                    { 84, "Fizz" },
                    { 83, "83" }
                });

            migrationBuilder.InsertData(
                table: "FizzBuzzStoretbl",
                columns: new[] { "FizzBuzzStoreID", "FizzBuzzValue" },
                values: new object[,]
                {
                    { 82, "82" },
                    { 81, "Fizz" },
                    { 80, "Buzz" },
                    { 79, "79" },
                    { 78, "Fizz" },
                    { 76, "76" },
                    { 51, "Fizz" },
                    { 50, "Buzz" },
                    { 49, "49" },
                    { 22, "22" },
                    { 21, "Fizz" },
                    { 20, "Buzz" },
                    { 19, "19" },
                    { 18, "Fizz" },
                    { 17, "17" },
                    { 16, "16" },
                    { 15, "FizzBuzz" },
                    { 14, "14" },
                    { 13, "13" },
                    { 12, "Fizz" },
                    { 11, "11" },
                    { 10, "Buzz" },
                    { 9, "Fizz" },
                    { 8, "8" },
                    { 7, "7" },
                    { 6, "Fizz" },
                    { 5, "Buzz" },
                    { 4, "4" },
                    { 3, "Fizz" },
                    { 2, "2" },
                    { 23, "23" },
                    { 24, "Fizz" },
                    { 25, "Buzz" },
                    { 26, "26" },
                    { 48, "Fizz" },
                    { 47, "47" },
                    { 46, "46" },
                    { 45, "FizzBuzz" },
                    { 44, "44" },
                    { 43, "43" },
                    { 42, "Fizz" },
                    { 41, "41" }
                });

            migrationBuilder.InsertData(
                table: "FizzBuzzStoretbl",
                columns: new[] { "FizzBuzzStoreID", "FizzBuzzValue" },
                values: new object[,]
                {
                    { 40, "Buzz" },
                    { 39, "Fizz" },
                    { 99, "Fizz" },
                    { 38, "38" },
                    { 36, "Fizz" },
                    { 35, "Buzz" },
                    { 34, "34" },
                    { 33, "Fizz" },
                    { 32, "32" },
                    { 31, "31" },
                    { 30, "FizzBuzz" },
                    { 29, "29" },
                    { 28, "28" },
                    { 27, "Fizz" },
                    { 37, "37" },
                    { 100, "Buzz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FizzBuzzStoretbl");
        }
    }
}
