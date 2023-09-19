using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_Fidus_CsharpAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.account_id);
                });

            migrationBuilder.CreateTable(
                name: "answars",
                columns: table => new
                {
                    answar_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_id = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    answar_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    answar_content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answars", x => x.answar_id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "faqs",
                columns: table => new
                {
                    follow_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    faq_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faq_content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faq_created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faq_updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faqs", x => x.follow_id);
                });

            migrationBuilder.CreateTable(
                name: "follows",
                columns: table => new
                {
                    follow_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_follows", x => x.follow_id);
                });

            migrationBuilder.CreateTable(
                name: "loginhistories",
                columns: table => new
                {
                    follow_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    login_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    logout_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginhistories", x => x.follow_id);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    message_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    from_account_id = table.Column<int>(type: "int", nullable: false),
                    to_account_id = table.Column<int>(type: "int", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    send_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    readornot = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.message_id);
                });

            migrationBuilder.CreateTable(
                name: "motds",
                columns: table => new
                {
                    motd_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    context = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motd_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motds", x => x.motd_id);
                });

            migrationBuilder.CreateTable(
                name: "post_types",
                columns: table => new
                {
                    post_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_type_title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_types", x => x.post_type_id);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    post_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    post_type_id = table.Column<int>(type: "int", nullable: false),
                    post_headline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    post_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    post_views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.post_id);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    profile_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    information = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    worktitle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.profile_id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.role_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "answars");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "faqs");

            migrationBuilder.DropTable(
                name: "follows");

            migrationBuilder.DropTable(
                name: "loginhistories");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "motds");

            migrationBuilder.DropTable(
                name: "post_types");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
