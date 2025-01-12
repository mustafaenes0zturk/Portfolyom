using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolyom.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "Testimonial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial",
                column: "TestimonialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial");

            migrationBuilder.RenameTable(
                name: "Testimonial",
                newName: "Testimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialId");
        }
    }
}
