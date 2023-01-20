using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentplus.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DRAFT",
                columns: table => new
                {
                    draftid = table.Column<string>(name: "draft_id", type: "TEXT", nullable: false),
                    studentid = table.Column<string>(name: "student_id", type: "TEXT", nullable: false),
                    supervisorid = table.Column<string>(name: "supervisor_id", type: "TEXT", nullable: false),
                    filepath = table.Column<string>(name: "file_path", type: "TEXT", nullable: false),
                    notes = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    submitteddate = table.Column<string>(name: "submitted_date", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DRAFT", x => x.draftid);
                });

            migrationBuilder.CreateTable(
                name: "DRAFT_FEEDBACK",
                columns: table => new
                {
                    dfeedbackid = table.Column<string>(name: "d_feedback_id", type: "TEXT", nullable: false),
                    draftid = table.Column<string>(name: "draft_id", type: "TEXT", nullable: false),
                    supervisornum = table.Column<string>(name: "supervisor_num", type: "TEXT", nullable: false),
                    dfeedbacktext = table.Column<string>(name: "d_feedback_text", type: "TEXT", nullable: false),
                    dresponsedate = table.Column<string>(name: "d_response_date", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DRAFT_FEEDBACK", x => x.dfeedbackid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING",
                columns: table => new
                {
                    meetingid = table.Column<string>(name: "meeting_id", type: "TEXT", nullable: false),
                    organiserid = table.Column<string>(name: "organiser_id", type: "TEXT", nullable: false),
                    mrecordingid = table.Column<string>(name: "m_recording_id", type: "TEXT", nullable: false),
                    starttime = table.Column<string>(name: "start_time", type: "TEXT", nullable: false),
                    endtime = table.Column<string>(name: "end_time", type: "TEXT", nullable: false),
                    topic = table.Column<string>(type: "TEXT", nullable: false),
                    transcript = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING", x => x.meetingid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING_ATTENDEE",
                columns: table => new
                {
                    mattendeeid = table.Column<string>(name: "m_attendee_id", type: "TEXT", nullable: false),
                    meetingid = table.Column<string>(name: "meeting_id", type: "TEXT", nullable: false),
                    attendeenumber = table.Column<string>(name: "attendee_number", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING_ATTENDEE", x => x.mattendeeid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING_FEEDBACK",
                columns: table => new
                {
                    mfeedbackid = table.Column<string>(name: "m_feedback_id", type: "TEXT", nullable: false),
                    meetingid = table.Column<string>(name: "meeting_id", type: "TEXT", nullable: false),
                    studentnumber = table.Column<string>(name: "student_number", type: "TEXT", nullable: false),
                    date = table.Column<string>(type: "TEXT", nullable: false),
                    feedbacktext = table.Column<string>(name: "feedback_text", type: "TEXT", nullable: false),
                    category = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    rating = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING_FEEDBACK", x => x.mfeedbackid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING_FEEDBACK_CATEGORY",
                columns: table => new
                {
                    fcategoryid = table.Column<string>(name: "f_category_id", type: "TEXT", nullable: false),
                    categoryname = table.Column<string>(name: "category_name", type: "TEXT", nullable: false),
                    categorydescription = table.Column<string>(name: "category_description", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING_FEEDBACK_CATEGORY", x => x.fcategoryid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING_FEEDBACK_RESPONSE",
                columns: table => new
                {
                    fresponseid = table.Column<string>(name: "f_response_id", type: "TEXT", nullable: false),
                    meetingid = table.Column<string>(name: "meeting_id", type: "TEXT", nullable: false),
                    supervisorid = table.Column<string>(name: "supervisor_id", type: "TEXT", nullable: false),
                    responsetext = table.Column<string>(name: "response_text", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING_FEEDBACK_RESPONSE", x => x.fresponseid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING_QA",
                columns: table => new
                {
                    qaid = table.Column<string>(name: "qa_id", type: "TEXT", nullable: false),
                    meetingid = table.Column<string>(name: "meeting_id", type: "TEXT", nullable: false),
                    question = table.Column<string>(type: "TEXT", nullable: false),
                    speakername = table.Column<string>(name: "speaker_name", type: "TEXT", nullable: false),
                    answer = table.Column<string>(type: "TEXT", nullable: false),
                    timestamp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING_QA", x => x.qaid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING_RECORDING",
                columns: table => new
                {
                    recordingid = table.Column<string>(name: "recording_id", type: "TEXT", nullable: false),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    duration = table.Column<string>(type: "TEXT", nullable: false),
                    date = table.Column<string>(type: "TEXT", nullable: false),
                    videofilepath = table.Column<string>(name: "video_file_path", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING_RECORDING", x => x.recordingid);
                });

            migrationBuilder.CreateTable(
                name: "MEETING_REQUEST",
                columns: table => new
                {
                    requestid = table.Column<string>(name: "request_id", type: "TEXT", nullable: false),
                    organiser = table.Column<string>(type: "TEXT", nullable: false),
                    topic = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    createddate = table.Column<string>(name: "created_date", type: "TEXT", nullable: false),
                    decisiondate = table.Column<string>(name: "decision_date", type: "TEXT", nullable: false),
                    notes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEETING_REQUEST", x => x.requestid);
                });

            migrationBuilder.CreateTable(
                name: "STUDENT",
                columns: table => new
                {
                    studentid = table.Column<string>(name: "student_id", type: "TEXT", nullable: false),
                    studentnumber = table.Column<string>(name: "student_number", type: "TEXT", nullable: false),
                    firstname = table.Column<string>(name: "first_name", type: "TEXT", nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "TEXT", nullable: false),
                    course = table.Column<string>(type: "TEXT", nullable: false),
                    graduationdate = table.Column<string>(name: "graduation_date", type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENT", x => x.studentid);
                });

            migrationBuilder.CreateTable(
                name: "SUPERVISEE",
                columns: table => new
                {
                    superviseeid = table.Column<string>(name: "supervisee_id", type: "TEXT", nullable: false),
                    studentnumber = table.Column<string>(name: "student_number", type: "TEXT", nullable: false),
                    supervisorid = table.Column<string>(name: "supervisor_id", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPERVISEE", x => x.superviseeid);
                });

            migrationBuilder.CreateTable(
                name: "SUPERVISOR",
                columns: table => new
                {
                    supervisorid = table.Column<string>(name: "supervisor_id", type: "TEXT", nullable: false),
                    supervisornumber = table.Column<string>(name: "supervisor_number", type: "TEXT", nullable: false),
                    firstname = table.Column<string>(name: "first_name", type: "TEXT", nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "TEXT", nullable: false),
                    department = table.Column<string>(type: "TEXT", nullable: false),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPERVISOR", x => x.supervisorid);
                });

            migrationBuilder.CreateTable(
                name: "TOKEN",
                columns: table => new
                {
                    tokenid = table.Column<string>(name: "token_id", type: "TEXT", nullable: false),
                    value = table.Column<string>(type: "TEXT", nullable: false),
                    expirationdate = table.Column<string>(name: "expiration_date", type: "TEXT", nullable: false),
                    userid = table.Column<string>(name: "user_id", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOKEN", x => x.tokenid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DRAFT");

            migrationBuilder.DropTable(
                name: "DRAFT_FEEDBACK");

            migrationBuilder.DropTable(
                name: "MEETING");

            migrationBuilder.DropTable(
                name: "MEETING_ATTENDEE");

            migrationBuilder.DropTable(
                name: "MEETING_FEEDBACK");

            migrationBuilder.DropTable(
                name: "MEETING_FEEDBACK_CATEGORY");

            migrationBuilder.DropTable(
                name: "MEETING_FEEDBACK_RESPONSE");

            migrationBuilder.DropTable(
                name: "MEETING_QA");

            migrationBuilder.DropTable(
                name: "MEETING_RECORDING");

            migrationBuilder.DropTable(
                name: "MEETING_REQUEST");

            migrationBuilder.DropTable(
                name: "STUDENT");

            migrationBuilder.DropTable(
                name: "SUPERVISEE");

            migrationBuilder.DropTable(
                name: "SUPERVISOR");

            migrationBuilder.DropTable(
                name: "TOKEN");
        }
    }
}
