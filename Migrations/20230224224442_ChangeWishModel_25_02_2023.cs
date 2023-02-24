using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WishesApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWishModel25022023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Wishes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Wishes");
        }
    }
}
