using Server.DataModel;
using System;
using System.Collections.Generic;

namespace Server
{
    public partial class RepoData
    {
        public RepoData()
        {

        }

        public RepoData(Server.DataModel.RepoData repoData, int ownerId, int permissionId)
        {
            this.GitHubId= repoData.id;
            this.ArchiveUrl = repoData.archive_url;
            this.AssigneesUrl = repoData.assignees_url;
            this.BlobsUrl = repoData.blobs_url;
            this.BranchesUrl = repoData.branches_url;
            this.CloneUrl = repoData.clone_url;
            this.CollaboratorsUrl = repoData.collaborators_url;
            this.CommentsUrl = repoData.comments_url;
            this.CommitsUrl = repoData.commits_url;
            this.CompareUrl= repoData.compare_url;
            this.ContentsUrl= repoData.contents_url;
            this.ContributorsUrl= repoData.contributors_url;
            this.CreatedAt= repoData.created_at;
            this.DefaultBranch= repoData.default_branch;
            this.DeploymentsUrl= repoData.deployments_url;
            this.Description= repoData.description;
            this.DownloadsUrl= repoData.downloads_url;
            this.EventsUrl= repoData.events_url;
            this.Fork= repoData.fork;
            this.Forks= repoData.forks;
            this.ForksCount= repoData.forks_count;
            this.ForksUrl= repoData.forks_url;
            this.FullName= repoData.full_name;
            this.GitCommitsUrl= repoData.git_commits_url;
            this.GitRefsUrl= repoData.git_refs_url;
            this.GitTagsUrl= repoData.git_tags_url;
            this.GitUrl= repoData.git_url;
            this.HasDownloads= repoData.has_downloads;
            this.HasIssues= repoData.has_issues;
            this.HasPages= repoData.has_pages;
            this.HasWiki= repoData.has_wiki;
            this.Homepage= repoData.homepage;
            this.HooksUrl= repoData.hooks_url;
            this.HtmlUrl= repoData.html_url;
            this.IsPrivate= repoData.isPrivate;
            this.IssueCommentUrl= repoData.issue_comment_url;
            this.IssueEventsUrl= repoData.issue_comment_url;
            this.IssuesUrl= repoData.issues_url;
            this.KeysUrl= repoData.keys_url;
            this.LabelsUrl= repoData.labels_url;
            this.Language= repoData.language;
            this.LanguagesUrl= repoData.languages_url;
            this.MergesUrl= repoData.merges_url;
            this.MilestonesUrl= repoData.milestones_url;
            this.MirrorUrl= repoData.mirror_url;
            this.Name= repoData.name;
            this.NotificationsUrl= repoData.notifications_url;
            this.OpenIssues= repoData.open_issues;
            this.OpenIssuesCount= repoData.open_issues_count;
            this.OwnerId= ownerId;
            this.PermissionsId= permissionId;
            this.PullsUrl= repoData.pulls_url;
            this.PushedAt= repoData.pushed_at;
            this.ReleasesUrl= repoData.releases_url;
            this.Size= repoData.size;
            this.SshUrl= repoData.ssh_url;
            this.StargazersCount= repoData.stargazers_count;
            this.StargazersUrl= repoData.stargazers_url;
            this.StatusesUrl= repoData.statuses_url;
            this.SubscribersUrl= repoData.subscribers_url;
            this.SubscriptionUrl= repoData.subscription_url;
            this.SvnUrl= repoData.svn_url;
            this.TagsUrl= repoData.tags_url;
            this.TeamsUrl= repoData.teams_url;
            this.TreesUrl= repoData.trees_url;
            this.UpdatedAt= repoData.updated_at;
            this.Url= repoData.url;
            this.Watchers= repoData.watchers;
            this.WatchersCount= repoData.watchers_count;
        }


        public int Id { get; set; }
        public string ArchiveUrl { get; set; }
        public string AssigneesUrl { get; set; }
        public string BlobsUrl { get; set; }
        public string BranchesUrl { get; set; }
        public string CloneUrl { get; set; }
        public string CollaboratorsUrl { get; set; }
        public string CommentsUrl { get; set; }
        public string CommitsUrl { get; set; }
        public string CompareUrl { get; set; }
        public string ContentsUrl { get; set; }
        public string ContributorsUrl { get; set; }
        public string CreatedAt { get; set; }
        public string DefaultBranch { get; set; }
        public string DeploymentsUrl { get; set; }
        public string Description { get; set; }
        public string DownloadsUrl { get; set; }
        public string EventsUrl { get; set; }
        public bool Fork { get; set; }
        public int Forks { get; set; }
        public int ForksCount { get; set; }
        public string ForksUrl { get; set; }
        public string FullName { get; set; }
        public string GitCommitsUrl { get; set; }
        public string GitRefsUrl { get; set; }
        public string GitTagsUrl { get; set; }
        public string GitUrl { get; set; }
        public int? GitHubId { get; set; }
        public bool HasDownloads { get; set; }
        public bool HasIssues { get; set; }
        public bool HasPages { get; set; }
        public bool HasWiki { get; set; }
        public string Homepage { get; set; }
        public string HooksUrl { get; set; }
        public string HtmlUrl { get; set; }
        public bool IsPrivate { get; set; }
        public string IssueCommentUrl { get; set; }
        public string IssueEventsUrl { get; set; }
        public string IssuesUrl { get; set; }
        public string KeysUrl { get; set; }
        public string LabelsUrl { get; set; }
        public string Language { get; set; }
        public string LanguagesUrl { get; set; }
        public string MergesUrl { get; set; }
        public string MilestonesUrl { get; set; }
        public string MirrorUrl { get; set; }
        public string Name { get; set; }
        public string NotificationsUrl { get; set; }
        public int OpenIssues { get; set; }
        public int OpenIssuesCount { get; set; }
        public int OwnerId { get; set; }
        public int PermissionsId { get; set; }
        public string PullsUrl { get; set; }
        public string PushedAt { get; set; }
        public string ReleasesUrl { get; set; }
        public int Size { get; set; }
        public string SshUrl { get; set; }
        public int StargazersCount { get; set; }
        public string StargazersUrl { get; set; }
        public string StatusesUrl { get; set; }
        public string SubscribersUrl { get; set; }
        public string SubscriptionUrl { get; set; }
        public string SvnUrl { get; set; }
        public string TagsUrl { get; set; }
        public string TeamsUrl { get; set; }
        public string TreesUrl { get; set; }
        public string UpdatedAt { get; set; }
        public string Url { get; set; }
        public int Watchers { get; set; }
        public int WatchersCount { get; set; }

        public virtual Owner Owner { get; set; }
        public virtual Permissions Permissions { get; set; }
    }
}
