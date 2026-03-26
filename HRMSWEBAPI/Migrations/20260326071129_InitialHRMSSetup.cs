using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMSWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialHRMSSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COMPANY_MASTER",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    PinCode = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY_MASTER", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "PERMISSION_MASTER",
                columns: table => new
                {
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    DeginationId = table.Column<int>(type: "int", nullable: false),
                    PermissionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMISSION_MASTER", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "ROLE_MASTER",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    DeginationId = table.Column<int>(type: "int", nullable: false),
                    RoleStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLE_MASTER", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "COUNTRY_MASTER",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyMasterCompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COUNTRY_MASTER", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_COUNTRY_MASTER_COMPANY_MASTER_CompanyMasterCompanyId",
                        column: x => x.CompanyMasterCompanyId,
                        principalTable: "COMPANY_MASTER",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "STATE_MASTER",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateCode = table.Column<int>(type: "int", nullable: false),
                    StateStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATE_MASTER", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_STATE_MASTER_COUNTRY_MASTER_CountryId",
                        column: x => x.CountryId,
                        principalTable: "COUNTRY_MASTER",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CITY_MASTER",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityCode = table.Column<int>(type: "int", nullable: false),
                    CityStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryMasterCountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITY_MASTER", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_CITY_MASTER_COUNTRY_MASTER_CountryMasterCountryId",
                        column: x => x.CountryMasterCountryId,
                        principalTable: "COUNTRY_MASTER",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_CITY_MASTER_STATE_MASTER_StateId",
                        column: x => x.StateId,
                        principalTable: "STATE_MASTER",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BRANCH_MASTER",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternetNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    PinCode = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRANCH_MASTER", x => x.BranchId);
                    table.ForeignKey(
                        name: "FK_BRANCH_MASTER_CITY_MASTER_CityId",
                        column: x => x.CityId,
                        principalTable: "CITY_MASTER",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BRANCH_MASTER_COMPANY_MASTER_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "COMPANY_MASTER",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BRANCH_MASTER_COUNTRY_MASTER_CountryId",
                        column: x => x.CountryId,
                        principalTable: "COUNTRY_MASTER",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BRANCH_MASTER_STATE_MASTER_StateId",
                        column: x => x.StateId,
                        principalTable: "STATE_MASTER",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DEPARTMENT_MASTER",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeptLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEPARTMENT_MASTER", x => x.DeptId);
                    table.ForeignKey(
                        name: "FK_DEPARTMENT_MASTER_BRANCH_MASTER_BranchId",
                        column: x => x.BranchId,
                        principalTable: "BRANCH_MASTER",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEGINATION_MASTER",
                columns: table => new
                {
                    DeginationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeginationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    DeginationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEGINATION_MASTER", x => x.DeginationId);
                    table.ForeignKey(
                        name: "FK_DEGINATION_MASTER_DEPARTMENT_MASTER_DeptId",
                        column: x => x.DeptId,
                        principalTable: "DEPARTMENT_MASTER",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE_MASTER",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeginationId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdharNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoiningDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    PinCode = table.Column<int>(type: "int", nullable: false),
                    EmpStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE_MASTER", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_EMPLOYEE_MASTER_DEGINATION_MASTER_DeginationId",
                        column: x => x.DeginationId,
                        principalTable: "DEGINATION_MASTER",
                        principalColumn: "DeginationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DOCUMENT_MASTER",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCUMENT_MASTER", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_DOCUMENT_MASTER_BRANCH_MASTER_BranchId",
                        column: x => x.BranchId,
                        principalTable: "BRANCH_MASTER",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DOCUMENT_MASTER_COMPANY_MASTER_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "COMPANY_MASTER",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DOCUMENT_MASTER_EMPLOYEE_MASTER_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMPLOYEE_MASTER",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BRANCH_MASTER_CityId",
                table: "BRANCH_MASTER",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BRANCH_MASTER_CompanyId",
                table: "BRANCH_MASTER",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BRANCH_MASTER_CountryId",
                table: "BRANCH_MASTER",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BRANCH_MASTER_StateId",
                table: "BRANCH_MASTER",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CITY_MASTER_CountryMasterCountryId",
                table: "CITY_MASTER",
                column: "CountryMasterCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CITY_MASTER_StateId",
                table: "CITY_MASTER",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_COUNTRY_MASTER_CompanyMasterCompanyId",
                table: "COUNTRY_MASTER",
                column: "CompanyMasterCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DEGINATION_MASTER_DeptId",
                table: "DEGINATION_MASTER",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DEPARTMENT_MASTER_BranchId",
                table: "DEPARTMENT_MASTER",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DOCUMENT_MASTER_BranchId",
                table: "DOCUMENT_MASTER",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DOCUMENT_MASTER_CompanyId",
                table: "DOCUMENT_MASTER",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DOCUMENT_MASTER_EmployeeId",
                table: "DOCUMENT_MASTER",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_MASTER_DeginationId",
                table: "EMPLOYEE_MASTER",
                column: "DeginationId");

            migrationBuilder.CreateIndex(
                name: "IX_STATE_MASTER_CountryId",
                table: "STATE_MASTER",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOCUMENT_MASTER");

            migrationBuilder.DropTable(
                name: "PERMISSION_MASTER");

            migrationBuilder.DropTable(
                name: "ROLE_MASTER");

            migrationBuilder.DropTable(
                name: "EMPLOYEE_MASTER");

            migrationBuilder.DropTable(
                name: "DEGINATION_MASTER");

            migrationBuilder.DropTable(
                name: "DEPARTMENT_MASTER");

            migrationBuilder.DropTable(
                name: "BRANCH_MASTER");

            migrationBuilder.DropTable(
                name: "CITY_MASTER");

            migrationBuilder.DropTable(
                name: "STATE_MASTER");

            migrationBuilder.DropTable(
                name: "COUNTRY_MASTER");

            migrationBuilder.DropTable(
                name: "COMPANY_MASTER");
        }
    }
}
