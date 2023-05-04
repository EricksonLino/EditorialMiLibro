using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EditorialMiLibro.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MisLibros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripción = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Género = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechadePublicación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EjemplaresProducidas = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisLibros", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MisLibros");
        }
    }
}
