using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVC_RabbitMQ.Entity
{
    public partial class PangeaRepoDataContext : DbContext
    {
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<RepoData> RepoData { get; set; }

        public PangeaRepoDataContext(DbContextOptions<PangeaRepoDataContext> options)
        : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.Property(e => e.AvatarUrl).HasColumnName("Avatar_url");

                entity.Property(e => e.EventsUrl).HasColumnName("Events_url");

                entity.Property(e => e.FollowersUrl).HasColumnName("Followers_url");

                entity.Property(e => e.FollowingUrl).HasColumnName("Following_url");

                entity.Property(e => e.GistsUrl).HasColumnName("Gists_url");

                entity.Property(e => e.GitHubId).HasColumnName("GitHub_id");

                entity.Property(e => e.GravatarId).HasColumnName("Gravatar_id");

                entity.Property(e => e.HtmlUrl).HasColumnName("Html_url");

                entity.Property(e => e.OrganizationsUrl).HasColumnName("Organizations_url");

                entity.Property(e => e.ReceivedEventsUrl).HasColumnName("Received_events_url");

                entity.Property(e => e.ReposUrl).HasColumnName("Repos_url");

                entity.Property(e => e.SiteAdmin).HasColumnName("Site_admin");

                entity.Property(e => e.StarredUrl).HasColumnName("Starred_url");

                entity.Property(e => e.SubscriptionsUrl).HasColumnName("Subscriptions_url");
            });

            modelBuilder.Entity<RepoData>(entity =>
            {
                entity.HasIndex(e => e.OwnerId)
                    .HasName("IX_RepoData_OwnerId");

                entity.HasIndex(e => e.PermissionsId)
                    .HasName("IX_RepoData_PermissionsId");

                entity.Property(e => e.ArchiveUrl).HasColumnName("Archive_url");

                entity.Property(e => e.AssigneesUrl).HasColumnName("Assignees_url");

                entity.Property(e => e.BlobsUrl).HasColumnName("Blobs_url");

                entity.Property(e => e.BranchesUrl).HasColumnName("Branches_url");

                entity.Property(e => e.CloneUrl).HasColumnName("Clone_url");

                entity.Property(e => e.CollaboratorsUrl).HasColumnName("Collaborators_url");

                entity.Property(e => e.CommentsUrl).HasColumnName("Comments_url");

                entity.Property(e => e.CommitsUrl).HasColumnName("Commits_url");

                entity.Property(e => e.CompareUrl).HasColumnName("Compare_url");

                entity.Property(e => e.ContentsUrl).HasColumnName("Contents_url");

                entity.Property(e => e.ContributorsUrl).HasColumnName("Contributors_url");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.DefaultBranch).HasColumnName("Default_branch");

                entity.Property(e => e.DeploymentsUrl).HasColumnName("Deployments_url");

                entity.Property(e => e.DownloadsUrl).HasColumnName("Downloads_url");

                entity.Property(e => e.EventsUrl).HasColumnName("Events_url");

                entity.Property(e => e.ForksCount).HasColumnName("Forks_count");

                entity.Property(e => e.ForksUrl).HasColumnName("Forks_url");

                entity.Property(e => e.FullName).HasColumnName("Full_name");

                entity.Property(e => e.GitCommitsUrl).HasColumnName("Git_commits_url");

                entity.Property(e => e.GitHubId).HasColumnName("GitHub_Id");

                entity.Property(e => e.GitRefsUrl).HasColumnName("Git_refs_url");

                entity.Property(e => e.GitTagsUrl).HasColumnName("Git_tags_url");

                entity.Property(e => e.GitUrl).HasColumnName("Git_url");

                entity.Property(e => e.HasDownloads).HasColumnName("Has_downloads");

                entity.Property(e => e.HasIssues).HasColumnName("Has_issues");

                entity.Property(e => e.HasPages).HasColumnName("Has_pages");

                entity.Property(e => e.HasWiki).HasColumnName("Has_wiki");

                entity.Property(e => e.HooksUrl).HasColumnName("Hooks_url");

                entity.Property(e => e.HtmlUrl).HasColumnName("Html_url");

                entity.Property(e => e.IssueCommentUrl).HasColumnName("Issue_comment_url");

                entity.Property(e => e.IssueEventsUrl).HasColumnName("Issue_events_url");

                entity.Property(e => e.IssuesUrl).HasColumnName("Issues_url");

                entity.Property(e => e.KeysUrl).HasColumnName("Keys_url");

                entity.Property(e => e.LabelsUrl).HasColumnName("Labels_url");

                entity.Property(e => e.LanguagesUrl).HasColumnName("Languages_url");

                entity.Property(e => e.MergesUrl).HasColumnName("Merges_url");

                entity.Property(e => e.MilestonesUrl).HasColumnName("Milestones_url");

                entity.Property(e => e.MirrorUrl).HasColumnName("Mirror_url");

                entity.Property(e => e.NotificationsUrl).HasColumnName("Notifications_url");

                entity.Property(e => e.OpenIssues).HasColumnName("Open_issues");

                entity.Property(e => e.OpenIssuesCount).HasColumnName("Open_issues_count");

                entity.Property(e => e.PullsUrl).HasColumnName("Pulls_url");

                entity.Property(e => e.PushedAt).HasColumnName("Pushed_at");

                entity.Property(e => e.ReleasesUrl).HasColumnName("Releases_url");

                entity.Property(e => e.SshUrl).HasColumnName("Ssh_url");

                entity.Property(e => e.StargazersCount).HasColumnName("Stargazers_count");

                entity.Property(e => e.StargazersUrl).HasColumnName("Stargazers_url");

                entity.Property(e => e.StatusesUrl).HasColumnName("Statuses_url");

                entity.Property(e => e.SubscribersUrl).HasColumnName("Subscribers_url");

                entity.Property(e => e.SubscriptionUrl).HasColumnName("Subscription_url");

                entity.Property(e => e.SvnUrl).HasColumnName("Svn_url");

                entity.Property(e => e.TagsUrl).HasColumnName("Tags_url");

                entity.Property(e => e.TeamsUrl).HasColumnName("Teams_url");

                entity.Property(e => e.TreesUrl).HasColumnName("Trees_url");

                entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");

                entity.Property(e => e.WatchersCount).HasColumnName("Watchers_count");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.RepoData)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Permissions)
                    .WithMany(p => p.RepoData)
                    .HasForeignKey(d => d.PermissionsId);
            });
        }
    }
}