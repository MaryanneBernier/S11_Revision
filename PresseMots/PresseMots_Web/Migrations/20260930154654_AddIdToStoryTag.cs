using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresseMots.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToStoryTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StoryTags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_TagId",
                table: "StoryTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags");

            migrationBuilder.DropIndex(
                name: "IX_StoryTags_TagId",
                table: "StoryTags");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StoryTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags",
                columns: new[] { "TagId", "StoryId" });
        }
    }
}
