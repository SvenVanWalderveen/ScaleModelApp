using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScaleModelDomain.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InputFieldConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ControlType = table.Column<int>(type: "INTEGER", nullable: false),
                    DataType = table.Column<int>(type: "INTEGER", nullable: false),
                    LabelName = table.Column<string>(type: "TEXT", nullable: false),
                    ToolTip = table.Column<string>(type: "TEXT", nullable: true),
                    IsRequired = table.Column<bool>(type: "INTEGER", nullable: false),
                    MaxLength = table.Column<int>(type: "INTEGER", nullable: true),
                    ValidationRule = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputFieldConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ManualName = table.Column<string>(type: "TEXT", nullable: false),
                    TotalSteps = table.Column<int>(type: "INTEGER", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScaleModelOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleModelOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScaleModelProjectTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeName = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleModelProjectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualSteps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ManualId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StepNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    StepTitle = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManualSteps_Manuals_ManualId",
                        column: x => x.ManualId,
                        principalTable: "Manuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScaleModelProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ScaleModelProjectTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProjectTitle = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleModelProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScaleModelProjects_ScaleModelProjectTypes_ScaleModelProjectTypeId",
                        column: x => x.ScaleModelProjectTypeId,
                        principalTable: "ScaleModelProjectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScaleModelProjectTypeInputFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ScaleModelProjecTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ScaleModelProjectTypeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    InputFieldConfigurationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleModelProjectTypeInputFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScaleModelProjectTypeInputFields_InputFieldConfigurations_InputFieldConfigurationId",
                        column: x => x.InputFieldConfigurationId,
                        principalTable: "InputFieldConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScaleModelProjectTypeInputFields_ScaleModelProjectTypes_ScaleModelProjectTypeId",
                        column: x => x.ScaleModelProjectTypeId,
                        principalTable: "ScaleModelProjectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ManualAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ManualStepId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FileLocation = table.Column<string>(type: "TEXT", nullable: true),
                    FileType = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManualAttachments_ManualSteps_ManualStepId",
                        column: x => x.ManualStepId,
                        principalTable: "ManualSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScaleModelOrderLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ScaleModelProjectId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ScaleModelOrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Productcode = table.Column<string>(type: "TEXT", nullable: true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<double>(type: "REAL", nullable: false),
                    PricePerUnit = table.Column<double>(type: "REAL", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleModelOrderLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScaleModelOrderLines_ScaleModelOrders_ScaleModelOrderId",
                        column: x => x.ScaleModelOrderId,
                        principalTable: "ScaleModelOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScaleModelOrderLines_ScaleModelProjects_ScaleModelProjectId",
                        column: x => x.ScaleModelProjectId,
                        principalTable: "ScaleModelProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScaleModelPictures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ScaleModelProjectId = table.Column<Guid>(type: "TEXT", nullable: true),
                    FileLocation = table.Column<string>(type: "TEXT", nullable: false),
                    Remark = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleModelPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScaleModelPictures_ScaleModelProjects_ScaleModelProjectId",
                        column: x => x.ScaleModelProjectId,
                        principalTable: "ScaleModelProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScaleModelTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ScaleModelProjectId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TaskName = table.Column<string>(type: "TEXT", nullable: false),
                    EstimatedTimeHours = table.Column<double>(type: "REAL", nullable: true),
                    RemainingTimeHours = table.Column<double>(type: "REAL", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleModelTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScaleModelTasks_ScaleModelProjects_ScaleModelProjectId",
                        column: x => x.ScaleModelProjectId,
                        principalTable: "ScaleModelProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManualAttachments_ManualStepId",
                table: "ManualAttachments",
                column: "ManualStepId");

            migrationBuilder.CreateIndex(
                name: "IX_ManualSteps_ManualId",
                table: "ManualSteps",
                column: "ManualId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleModelOrderLines_ScaleModelOrderId",
                table: "ScaleModelOrderLines",
                column: "ScaleModelOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleModelOrderLines_ScaleModelProjectId",
                table: "ScaleModelOrderLines",
                column: "ScaleModelProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleModelPictures_ScaleModelProjectId",
                table: "ScaleModelPictures",
                column: "ScaleModelProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleModelProjects_ScaleModelProjectTypeId",
                table: "ScaleModelProjects",
                column: "ScaleModelProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleModelProjectTypeInputFields_InputFieldConfigurationId",
                table: "ScaleModelProjectTypeInputFields",
                column: "InputFieldConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleModelProjectTypeInputFields_ScaleModelProjectTypeId",
                table: "ScaleModelProjectTypeInputFields",
                column: "ScaleModelProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleModelTasks_ScaleModelProjectId",
                table: "ScaleModelTasks",
                column: "ScaleModelProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManualAttachments");

            migrationBuilder.DropTable(
                name: "ScaleModelOrderLines");

            migrationBuilder.DropTable(
                name: "ScaleModelPictures");

            migrationBuilder.DropTable(
                name: "ScaleModelProjectTypeInputFields");

            migrationBuilder.DropTable(
                name: "ScaleModelTasks");

            migrationBuilder.DropTable(
                name: "ManualSteps");

            migrationBuilder.DropTable(
                name: "ScaleModelOrders");

            migrationBuilder.DropTable(
                name: "InputFieldConfigurations");

            migrationBuilder.DropTable(
                name: "ScaleModelProjects");

            migrationBuilder.DropTable(
                name: "Manuals");

            migrationBuilder.DropTable(
                name: "ScaleModelProjectTypes");
        }
    }
}
