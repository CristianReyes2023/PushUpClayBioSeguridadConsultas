using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "country",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         NameCountry = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "position",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         NamePosition = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "statecontract",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         Description = table.Column<string>(type: "text", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "turns",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         NameTurns = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         HourShiftStart = table.Column<TimeOnly>(type: "time", nullable: false),
            //         HourShiftFinally = table.Column<TimeOnly>(type: "time", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "typeperson",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         Description = table.Column<string>(type: "text", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "state",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         NameState = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdCountryFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "state_ibfk_1",
            //             column: x => x.IdCountryFk,
            //             principalTable: "country",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "Cities",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NameCity = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdStateFk = table.Column<int>(type: "int", nullable: false),
            //         IdStateFkNavigationId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Cities", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_Cities_state_IdStateFkNavigationId",
            //             column: x => x.IdStateFkNavigationId,
            //             principalTable: "state",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "client",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         IdClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         NameCliente = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         DateRegister = table.Column<DateTime>(type: "datetime", nullable: false),
            //         TelephoneNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdTPersonFk = table.Column<int>(type: "int", nullable: true),
            //         IdCityFk = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "client_ibfk_1",
            //             column: x => x.IdCityFk,
            //             principalTable: "Cities",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "client_ibfk_2",
            //             column: x => x.IdTPersonFk,
            //             principalTable: "typeperson",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "employee",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         IdEmployee = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         NameEmployee = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         DateRegister = table.Column<DateTime>(type: "datetime", nullable: false),
            //         TelephoneNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdCityFk = table.Column<int>(type: "int", nullable: false),
            //         IdPositionFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "employee_ibfk_1",
            //             column: x => x.IdCityFk,
            //             principalTable: "Cities",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "employee_ibfk_2",
            //             column: x => x.IdPositionFk,
            //             principalTable: "position",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "addressclient",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         tipo_via = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_principal = table.Column<short>(type: "smallint", nullable: false),
            //         letra_principal = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         bis = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         letra_secundaria = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         cardinal_primario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_secundario = table.Column<short>(type: "smallint", nullable: false),
            //         cardinal_secundario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdClientFk = table.Column<int>(type: "int", nullable: false),
            //         IdTAddressFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "addressclient_ibfk_1",
            //             column: x => x.IdClientFk,
            //             principalTable: "client",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "addressoffice",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         tipo_via = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_principal = table.Column<short>(type: "smallint", nullable: false),
            //         letra_principal = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         bis = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         letra_secundaria = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         cardinal_primario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_secundario = table.Column<short>(type: "smallint", nullable: false),
            //         cardinal_secundario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdEmployeeFk = table.Column<int>(type: "int", nullable: false),
            //         IdTAddressFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "addressoffice_ibfk_1",
            //             column: x => x.IdEmployeeFk,
            //             principalTable: "employee",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "contract",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         DateContract = table.Column<DateTime>(type: "datetime", nullable: false),
            //         DATEFINAL = table.Column<DateTime>(type: "datetime", nullable: false),
            //         IdClientFk = table.Column<int>(type: "int", nullable: false),
            //         IdEmployeeFk = table.Column<int>(type: "int", nullable: false),
            //         IdStateContractFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "contract_ibfk_1",
            //             column: x => x.IdStateContractFk,
            //             principalTable: "statecontract",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "contract_ibfk_2",
            //             column: x => x.IdEmployeeFk,
            //             principalTable: "employee",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "contract_ibfk_3",
            //             column: x => x.IdClientFk,
            //             principalTable: "client",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "programming",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         IdContractFk = table.Column<int>(type: "int", nullable: false),
            //         IdTurnFk = table.Column<int>(type: "int", nullable: false),
            //         IdEmployeeFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "programming_ibfk_1",
            //             column: x => x.IdContractFk,
            //             principalTable: "contract",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "programming_ibfk_2",
            //             column: x => x.IdTurnFk,
            //             principalTable: "turns",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "programming_ibfk_3",
            //             column: x => x.IdEmployeeFk,
            //             principalTable: "employee",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Cities_IdStateFkNavigationId",
            //     table: "Cities",
            //     column: "IdStateFkNavigationId");

            // migrationBuilder.CreateIndex(
            //     name: "IdClientFk",
            //     table: "addressclient",
            //     column: "IdClientFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdEmployeeFk",
            //     table: "addressoffice",
            //     column: "IdEmployeeFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdCityFk",
            //     table: "client",
            //     column: "IdCityFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdTPersonFk",
            //     table: "client",
            //     column: "IdTPersonFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdClientFk1",
            //     table: "contract",
            //     column: "IdClientFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdEmployeeFk1",
            //     table: "contract",
            //     column: "IdEmployeeFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdStateContractFk",
            //     table: "contract",
            //     column: "IdStateContractFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdCityFk1",
            //     table: "employee",
            //     column: "IdCityFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdPositionFk",
            //     table: "employee",
            //     column: "IdPositionFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdContractFk",
            //     table: "programming",
            //     column: "IdContractFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdEmployeeFk2",
            //     table: "programming",
            //     column: "IdEmployeeFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdTurnFk",
            //     table: "programming",
            //     column: "IdTurnFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdCountryFk",
            //     table: "state",
            //     column: "IdCountryFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "addressclient");

            // migrationBuilder.DropTable(
            //     name: "addressoffice");

            // migrationBuilder.DropTable(
            //     name: "programming");

            // migrationBuilder.DropTable(
            //     name: "contract");

            // migrationBuilder.DropTable(
            //     name: "turns");

            // migrationBuilder.DropTable(
            //     name: "statecontract");

            // migrationBuilder.DropTable(
            //     name: "employee");

            // migrationBuilder.DropTable(
            //     name: "client");

            // migrationBuilder.DropTable(
            //     name: "position");

            // migrationBuilder.DropTable(
            //     name: "Cities");

            // migrationBuilder.DropTable(
            //     name: "typeperson");

            // migrationBuilder.DropTable(
            //     name: "state");

            // migrationBuilder.DropTable(
            //     name: "country");
        }
    }
}
