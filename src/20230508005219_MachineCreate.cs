using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ucmdb_mvc.Migrations
{
    /// <inheritdoc />
    public partial class MachineCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                            name: "Machines",
                            columns: table => new
                            {
                                Id = table.Column<int>(type: "INTEGER", nullable: false)
                                                            .Annotation("Sqlite:Autoincrement", true),
                                Nickname = table.Column<string>(type: "TEXT", nullable: false),
                                Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                                Description = table.Column<string>(type: "TEXT", nullable: false),
                                IP_Address = table.Column<string>(type: "TEXT", nullable: true),
                                SubnetMask = table.Column<string>(type: "TEXT", nullable: true),
                                Gateway = table.Column<string>(type: "TEXT", nullable: true),
                                Arch = table.Column<string>(type: "TEXT", nullable: false),
                                ModelName = table.Column<string>(type: "TEXT", nullable: false),
                                StorageGbs = table.Column<int>(type: "INTEGER", nullable: true),

                            },
                            constraints: table =>
                            {
                                table.PrimaryKey("PK_Machines", x => x.Id);
                            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                            name: "Machines");
        }
    }
}
