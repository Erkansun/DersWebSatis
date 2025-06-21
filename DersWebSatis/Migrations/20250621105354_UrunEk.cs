using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DersWebSatis.Migrations
{
    /// <inheritdoc />
    public partial class UrunEk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SiparisItems_UrunId",
                table: "SiparisItems",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiparisItems_Uruns_UrunId",
                table: "SiparisItems",
                column: "UrunId",
                principalTable: "Uruns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiparisItems_Uruns_UrunId",
                table: "SiparisItems");

            migrationBuilder.DropIndex(
                name: "IX_SiparisItems_UrunId",
                table: "SiparisItems");
        }
    }
}
