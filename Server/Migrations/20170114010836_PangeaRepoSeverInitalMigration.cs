using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Server.Migrations
{
    public partial class PangeaRepoSeverInitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Avatar_url = table.Column<string>(nullable: true),
                    Events_url = table.Column<string>(nullable: true),
                    Followers_url = table.Column<string>(nullable: true),
                    Following_url = table.Column<string>(nullable: true),
                    Gists_url = table.Column<string>(nullable: true),
                    GitHub_id = table.Column<int>(nullable: false),
                    Gravatar_id = table.Column<string>(nullable: true),
                    Html_url = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Organizations_url = table.Column<string>(nullable: true),
                    Received_events_url = table.Column<string>(nullable: true),
                    Repos_url = table.Column<string>(nullable: true),
                    Site_admin = table.Column<bool>(nullable: false),
                    Starred_url = table.Column<string>(nullable: true),
                    Subscriptions_url = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Admin = table.Column<bool>(nullable: false),
                    Pull = table.Column<bool>(nullable: false),
                    Push = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepoData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Archive_url = table.Column<string>(nullable: true),
                    Assignees_url = table.Column<string>(nullable: true),
                    Blobs_url = table.Column<string>(nullable: true),
                    Branches_url = table.Column<string>(nullable: true),
                    Clone_url = table.Column<string>(nullable: true),
                    Collaborators_url = table.Column<string>(nullable: true),
                    Comments_url = table.Column<string>(nullable: true),
                    Commits_url = table.Column<string>(nullable: true),
                    Compare_url = table.Column<string>(nullable: true),
                    Contents_url = table.Column<string>(nullable: true),
                    Contributors_url = table.Column<string>(nullable: true),
                    Created_at = table.Column<string>(nullable: true),
                    Default_branch = table.Column<string>(nullable: true),
                    Deployments_url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Downloads_url = table.Column<string>(nullable: true),
                    Events_url = table.Column<string>(nullable: true),
                    Fork = table.Column<bool>(nullable: false),
                    Forks = table.Column<int>(nullable: false),
                    Forks_count = table.Column<int>(nullable: false),
                    Forks_url = table.Column<string>(nullable: true),
                    Full_name = table.Column<string>(nullable: true),
                    Git_commits_url = table.Column<string>(nullable: true),
                    GitHub_Id = table.Column<int>(nullable: true),
                    Git_refs_url = table.Column<string>(nullable: true),
                    Git_tags_url = table.Column<string>(nullable: true),
                    Git_url = table.Column<string>(nullable: true),
                    Has_downloads = table.Column<bool>(nullable: false),
                    Has_issues = table.Column<bool>(nullable: false),
                    Has_pages = table.Column<bool>(nullable: false),
                    Has_wiki = table.Column<bool>(nullable: false),
                    Homepage = table.Column<string>(nullable: true),
                    Hooks_url = table.Column<string>(nullable: true),
                    Html_url = table.Column<string>(nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false),
                    Issue_comment_url = table.Column<string>(nullable: true),
                    Issue_events_url = table.Column<string>(nullable: true),
                    Issues_url = table.Column<string>(nullable: true),
                    Keys_url = table.Column<string>(nullable: true),
                    Labels_url = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Languages_url = table.Column<string>(nullable: true),
                    Merges_url = table.Column<string>(nullable: true),
                    Milestones_url = table.Column<string>(nullable: true),
                    Mirror_url = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notifications_url = table.Column<string>(nullable: true),
                    Open_issues = table.Column<int>(nullable: false),
                    Open_issues_count = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false),
                    PermissionsId = table.Column<int>(nullable: false),
                    Pulls_url = table.Column<string>(nullable: true),
                    Pushed_at = table.Column<string>(nullable: true),
                    Releases_url = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Ssh_url = table.Column<string>(nullable: true),
                    Stargazers_count = table.Column<int>(nullable: false),
                    Stargazers_url = table.Column<string>(nullable: true),
                    Statuses_url = table.Column<string>(nullable: true),
                    Subscribers_url = table.Column<string>(nullable: true),
                    Subscription_url = table.Column<string>(nullable: true),
                    Svn_url = table.Column<string>(nullable: true),
                    Tags_url = table.Column<string>(nullable: true),
                    Teams_url = table.Column<string>(nullable: true),
                    Trees_url = table.Column<string>(nullable: true),
                    Updated_at = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Watchers = table.Column<int>(nullable: false),
                    Watchers_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepoData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepoData_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepoData_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepoData_OwnerId",
                table: "RepoData",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RepoData_PermissionsId",
                table: "RepoData",
                column: "PermissionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepoData");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
