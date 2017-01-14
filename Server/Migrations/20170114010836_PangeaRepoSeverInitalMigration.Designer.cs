using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Server;

namespace Server.Migrations
{
    [DbContext(typeof(PangeaRepoDataContext))]
    [Migration("20170114010836_PangeaRepoSeverInitalMigration")]
    partial class PangeaRepoSeverInitalMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Server.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarUrl")
                        .HasColumnName("Avatar_url");

                    b.Property<string>("EventsUrl")
                        .HasColumnName("Events_url");

                    b.Property<string>("FollowersUrl")
                        .HasColumnName("Followers_url");

                    b.Property<string>("FollowingUrl")
                        .HasColumnName("Following_url");

                    b.Property<string>("GistsUrl")
                        .HasColumnName("Gists_url");

                    b.Property<int>("GitHubId")
                        .HasColumnName("GitHub_id");

                    b.Property<string>("GravatarId")
                        .HasColumnName("Gravatar_id");

                    b.Property<string>("HtmlUrl")
                        .HasColumnName("Html_url");

                    b.Property<string>("Login");

                    b.Property<string>("OrganizationsUrl")
                        .HasColumnName("Organizations_url");

                    b.Property<string>("ReceivedEventsUrl")
                        .HasColumnName("Received_events_url");

                    b.Property<string>("ReposUrl")
                        .HasColumnName("Repos_url");

                    b.Property<bool>("SiteAdmin")
                        .HasColumnName("Site_admin");

                    b.Property<string>("StarredUrl")
                        .HasColumnName("Starred_url");

                    b.Property<string>("SubscriptionsUrl")
                        .HasColumnName("Subscriptions_url");

                    b.Property<string>("Type");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("Server.Permissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<bool>("Pull");

                    b.Property<bool>("Push");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Server.RepoData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArchiveUrl")
                        .HasColumnName("Archive_url");

                    b.Property<string>("AssigneesUrl")
                        .HasColumnName("Assignees_url");

                    b.Property<string>("BlobsUrl")
                        .HasColumnName("Blobs_url");

                    b.Property<string>("BranchesUrl")
                        .HasColumnName("Branches_url");

                    b.Property<string>("CloneUrl")
                        .HasColumnName("Clone_url");

                    b.Property<string>("CollaboratorsUrl")
                        .HasColumnName("Collaborators_url");

                    b.Property<string>("CommentsUrl")
                        .HasColumnName("Comments_url");

                    b.Property<string>("CommitsUrl")
                        .HasColumnName("Commits_url");

                    b.Property<string>("CompareUrl")
                        .HasColumnName("Compare_url");

                    b.Property<string>("ContentsUrl")
                        .HasColumnName("Contents_url");

                    b.Property<string>("ContributorsUrl")
                        .HasColumnName("Contributors_url");

                    b.Property<string>("CreatedAt")
                        .HasColumnName("Created_at");

                    b.Property<string>("DefaultBranch")
                        .HasColumnName("Default_branch");

                    b.Property<string>("DeploymentsUrl")
                        .HasColumnName("Deployments_url");

                    b.Property<string>("Description");

                    b.Property<string>("DownloadsUrl")
                        .HasColumnName("Downloads_url");

                    b.Property<string>("EventsUrl")
                        .HasColumnName("Events_url");

                    b.Property<bool>("Fork");

                    b.Property<int>("Forks");

                    b.Property<int>("ForksCount")
                        .HasColumnName("Forks_count");

                    b.Property<string>("ForksUrl")
                        .HasColumnName("Forks_url");

                    b.Property<string>("FullName")
                        .HasColumnName("Full_name");

                    b.Property<string>("GitCommitsUrl")
                        .HasColumnName("Git_commits_url");

                    b.Property<int?>("GitHubId")
                        .HasColumnName("GitHub_Id");

                    b.Property<string>("GitRefsUrl")
                        .HasColumnName("Git_refs_url");

                    b.Property<string>("GitTagsUrl")
                        .HasColumnName("Git_tags_url");

                    b.Property<string>("GitUrl")
                        .HasColumnName("Git_url");

                    b.Property<bool>("HasDownloads")
                        .HasColumnName("Has_downloads");

                    b.Property<bool>("HasIssues")
                        .HasColumnName("Has_issues");

                    b.Property<bool>("HasPages")
                        .HasColumnName("Has_pages");

                    b.Property<bool>("HasWiki")
                        .HasColumnName("Has_wiki");

                    b.Property<string>("Homepage");

                    b.Property<string>("HooksUrl")
                        .HasColumnName("Hooks_url");

                    b.Property<string>("HtmlUrl")
                        .HasColumnName("Html_url");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("IssueCommentUrl")
                        .HasColumnName("Issue_comment_url");

                    b.Property<string>("IssueEventsUrl")
                        .HasColumnName("Issue_events_url");

                    b.Property<string>("IssuesUrl")
                        .HasColumnName("Issues_url");

                    b.Property<string>("KeysUrl")
                        .HasColumnName("Keys_url");

                    b.Property<string>("LabelsUrl")
                        .HasColumnName("Labels_url");

                    b.Property<string>("Language");

                    b.Property<string>("LanguagesUrl")
                        .HasColumnName("Languages_url");

                    b.Property<string>("MergesUrl")
                        .HasColumnName("Merges_url");

                    b.Property<string>("MilestonesUrl")
                        .HasColumnName("Milestones_url");

                    b.Property<string>("MirrorUrl")
                        .HasColumnName("Mirror_url");

                    b.Property<string>("Name");

                    b.Property<string>("NotificationsUrl")
                        .HasColumnName("Notifications_url");

                    b.Property<int>("OpenIssues")
                        .HasColumnName("Open_issues");

                    b.Property<int>("OpenIssuesCount")
                        .HasColumnName("Open_issues_count");

                    b.Property<int>("OwnerId");

                    b.Property<int>("PermissionsId");

                    b.Property<string>("PullsUrl")
                        .HasColumnName("Pulls_url");

                    b.Property<string>("PushedAt")
                        .HasColumnName("Pushed_at");

                    b.Property<string>("ReleasesUrl")
                        .HasColumnName("Releases_url");

                    b.Property<int>("Size");

                    b.Property<string>("SshUrl")
                        .HasColumnName("Ssh_url");

                    b.Property<int>("StargazersCount")
                        .HasColumnName("Stargazers_count");

                    b.Property<string>("StargazersUrl")
                        .HasColumnName("Stargazers_url");

                    b.Property<string>("StatusesUrl")
                        .HasColumnName("Statuses_url");

                    b.Property<string>("SubscribersUrl")
                        .HasColumnName("Subscribers_url");

                    b.Property<string>("SubscriptionUrl")
                        .HasColumnName("Subscription_url");

                    b.Property<string>("SvnUrl")
                        .HasColumnName("Svn_url");

                    b.Property<string>("TagsUrl")
                        .HasColumnName("Tags_url");

                    b.Property<string>("TeamsUrl")
                        .HasColumnName("Teams_url");

                    b.Property<string>("TreesUrl")
                        .HasColumnName("Trees_url");

                    b.Property<string>("UpdatedAt")
                        .HasColumnName("Updated_at");

                    b.Property<string>("Url");

                    b.Property<int>("Watchers");

                    b.Property<int>("WatchersCount")
                        .HasColumnName("Watchers_count");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId")
                        .HasName("IX_RepoData_OwnerId");

                    b.HasIndex("PermissionsId")
                        .HasName("IX_RepoData_PermissionsId");

                    b.ToTable("RepoData");
                });

            modelBuilder.Entity("Server.RepoData", b =>
                {
                    b.HasOne("Server.Owner", "Owner")
                        .WithMany("RepoData")
                        .HasForeignKey("OwnerId");

                    b.HasOne("Server.Permissions", "Permissions")
                        .WithMany("RepoData")
                        .HasForeignKey("PermissionsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
