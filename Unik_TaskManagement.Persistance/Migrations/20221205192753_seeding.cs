using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnikTaskManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    KundeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.KundeId);
                });

            migrationBuilder.CreateTable(
                name: "Medarbejder",
                columns: table => new
                {
                    MedarbejdeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medarbejder", x => x.MedarbejdeId);
                });

            migrationBuilder.CreateTable(
                name: "Opgaver",
                columns: table => new
                {
                    OpgaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opgaver", x => x.OpgaveId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KundeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Kunder_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunder",
                        principalColumn: "KundeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedarbejdeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_Medarbejder_MedarbejdeId",
                        column: x => x.MedarbejdeId,
                        principalTable: "Medarbejder",
                        principalColumn: "MedarbejdeId");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpgaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedarbejdeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Booking_Medarbejder_MedarbejdeId",
                        column: x => x.MedarbejdeId,
                        principalTable: "Medarbejder",
                        principalColumn: "MedarbejdeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Opgaver_OpgaveId",
                        column: x => x.OpgaveId,
                        principalTable: "Opgaver",
                        principalColumn: "OpgaveId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "KundeId", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { new Guid("2d56c6f9-da4d-4907-9c1a-634de7e7281e"), "aabv@gmail.com", "AAb Vejle", "82838435" },
                    { new Guid("344e120b-12fc-4ded-8f45-52d60604460c"), "lejerbo@gmail.com", "Lejer Bo Vejle", "82838444" }
                });

            migrationBuilder.InsertData(
                table: "Medarbejder",
                columns: new[] { "MedarbejdeId", "Email", "FirstName", "Job", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("0104f406-58a9-457a-af8c-e0712c8577b5"), "med3@gmail.com", "med3", 1, "med3L", "12345630" },
                    { new Guid("580c5ae7-5eaa-4918-bbea-9e5a53124699"), "med1@gmail.com", "med1", 0, "med1L", "12345678" },
                    { new Guid("970ad7e2-c5a8-441b-bd34-f9e68cbe11d2"), "med2@gmail.com", "med1", 0, "med2L", "12345679" }
                });

            migrationBuilder.InsertData(
                table: "Opgaver",
                columns: new[] { "OpgaveId", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("04b8af31-28b6-4b14-91d1-f5c7f62f4496"), "", "testing systems" },
                    { new Guid("08fc43ea-0283-4371-900e-e22028bb721e"), "", " Installing Sql Server" },
                    { new Guid("3b6db15f-0120-4b6c-bb54-dff6b0faf466"), "", "Make Database net working" },
                    { new Guid("f6b0b0d5-b5dc-4677-bd45-cbd4c6925401"), "", "Programming " }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "Description", "MedarbejdeId", "SkillTitle" },
                values: new object[,]
                {
                    { new Guid("0d3243bb-fb8a-4323-a9fd-362bfe23165d"), "some des.", null, "Sikkehed" },
                    { new Guid("65384c2c-9000-435a-bd94-abadc2d5107e"), "some des.", null, "Sql Server" },
                    { new Guid("97ce53b1-f23a-4930-b4bf-67e419949ae1"), "some des.", null, "Programming" },
                    { new Guid("a29731a6-c039-4a3d-898f-bd6236a4a101"), "some des.", null, "Consultant" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "KundeId", "Location", "ProjectTitle" },
                values: new object[,]
                {
                    { new Guid("344c5b73-5d01-4ece-8d34-b10ba6daaa19"), new Guid("2d56c6f9-da4d-4907-9c1a-634de7e7281e"), "Kolding", "Pt2" },
                    { new Guid("6024788a-8bce-4c7d-ae34-2beafbf0a2d2"), new Guid("344e120b-12fc-4ded-8f45-52d60604460c"), "Herning", "Pt3" },
                    { new Guid("ddb63550-022c-4d35-88d6-c3ab0b3d1d1f"), new Guid("2d56c6f9-da4d-4907-9c1a-634de7e7281e"), "Vejle", "Pt1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_MedarbejdeId",
                table: "Booking",
                column: "MedarbejdeId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_OpgaveId",
                table: "Booking",
                column: "OpgaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ProjectId",
                table: "Booking",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_KundeId",
                table: "Projects",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_MedarbejdeId",
                table: "Skills",
                column: "MedarbejdeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Opgaver");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Medarbejder");

            migrationBuilder.DropTable(
                name: "Kunder");
        }
    }
}
