using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_Management_Database.Data.Migrations
{
    public partial class addedpatientview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    PrescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prescriptionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrescriptionLab = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.PrescriptionId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffAge = table.Column<int>(type: "int", nullable: false),
                    StaffAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Patientid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientFirstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientAge = table.Column<int>(type: "int", nullable: false),
                    PatientAdress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientZip = table.Column<int>(type: "int", nullable: false),
                    PatientState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientRoomNumber = table.Column<int>(type: "int", nullable: false),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Patientid);
                    table.ForeignKey(
                        name: "FK_Patient_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "PrescriptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdmissionDischarge",
                columns: table => new
                {
                    AdmissionDischargeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wardnumber = table.Column<int>(type: "int", nullable: false),
                    bednumber = table.Column<int>(type: "int", nullable: false),
                    dateadmitted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datedischarged = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patientid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionDischarge", x => x.AdmissionDischargeId);
                    table.ForeignKey(
                        name: "FK_AdmissionDischarge_Patient_Patientid",
                        column: x => x.Patientid,
                        principalTable: "Patient",
                        principalColumn: "Patientid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientStaff",
                columns: table => new
                {
                    Patientid = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientStaff", x => new { x.Patientid, x.StaffId });
                    table.ForeignKey(
                        name: "FK_PatientStaff_Patient_Patientid",
                        column: x => x.Patientid,
                        principalTable: "Patient",
                        principalColumn: "Patientid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionDischarge_Patientid",
                table: "AdmissionDischarge",
                column: "Patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PrescriptionId",
                table: "Patient",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientStaff_StaffId",
                table: "PatientStaff",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionDischarge");

            migrationBuilder.DropTable(
                name: "PatientStaff");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Prescription");
        }
    }
}
