using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BA.NTierApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kadın",
                table: "Users",
                newName: "Cinsiyet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cinsiyet",
                table: "Users",
                newName: "Kadın");
        }
    }
}
