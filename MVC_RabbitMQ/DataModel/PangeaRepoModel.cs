using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_RabbitMQ.DataModel
{

        public class Owner
        {
            public Owner()
            {
                this.login = "None";
                this.id = -1;
                this.avatar_url = "None";
                this.gravatar_id = "None";
                this.url = "None";
                this.html_url = "None";
                this.followers_url = "None";
                this.following_url = "None";
                this.gists_url = "None";
                this.git_hub_id = 0;
                this.starred_url = "None";
                this.subscriptions_url = "None";
                this.organizations_url = "None";
                this.repos_url = "None";
                this.events_url = "None";
                this.received_events_url = "None";
                this.type = "None";
                this.site_admin = false;
        }
            public Owner(MVC_RabbitMQ.Entity.Owner ownerIn)
            {
                this.login = ownerIn.Login;
                this.id = ownerIn.Id;
                this.avatar_url = ownerIn.AvatarUrl;
                this.gravatar_id = ownerIn.GravatarId;
                this.url = ownerIn.Url;
                this.html_url = ownerIn.HtmlUrl;
                this.followers_url = ownerIn.FollowersUrl;
                this.following_url = ownerIn.FollowingUrl;
                this.gists_url = ownerIn.GistsUrl;
                this.git_hub_id = ownerIn.GitHubId;
                this.starred_url = ownerIn.StarredUrl;
                this.subscriptions_url = ownerIn.SubscriptionsUrl;
                this.organizations_url = ownerIn.OrganizationsUrl;
                this.repos_url = ownerIn.ReposUrl;
                this.events_url = ownerIn.EventsUrl;
                this.received_events_url = ownerIn.ReceivedEventsUrl;
                this.type = ownerIn.Type;
                this.site_admin = ownerIn.SiteAdmin;
            }

            public string login { get; set; }
            public int id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public int git_hub_id { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        public class Permissions
        {
            public Permissions()
            {
                this.admin = false;
                this.push = false;
                this.pull = false;
            }
        public Permissions(MVC_RabbitMQ.Entity.Permissions permIn)
            {
                this.admin = permIn.Admin;
                this.push = permIn.Pull;
                this.pull = permIn.Push;
            }
            public bool admin { get; set; }
            public bool push { get; set; }
            public bool pull { get; set; }
        }

        public class RepoData
        {
        public RepoData(MVC_RabbitMQ.Entity.RepoData repoData, MVC_RabbitMQ.Entity.Owner ownerIn, MVC_RabbitMQ.Entity.Permissions permIn)
        {
            this.id = repoData.Id;
            this.name = repoData.Name;
            this.full_name = repoData.FullName;
            this.isPrivate = repoData.IsPrivate;
            this.html_url = repoData.HtmlUrl;
            this.description = repoData.Description;
            this.fork = repoData.Fork;
            this.url = repoData.Url;
            this.forks_url = repoData.ForksUrl;
            this.keys_url = repoData.KeysUrl;
            this.collaborators_url = repoData.CollaboratorsUrl;
            this.teams_url = repoData.TeamsUrl;
            this.hooks_url = repoData.HooksUrl;
            this.issue_events_url = repoData.IssueEventsUrl;
            this.events_url = repoData.EventsUrl;
            this.assignees_url = repoData.AssigneesUrl;
            this.branches_url = repoData.BranchesUrl;
            this.tags_url = repoData.TagsUrl;
            this.blobs_url = repoData.BlobsUrl;
            this.git_tags_url = repoData.GitTagsUrl;
            this.git_refs_url = repoData.GitRefsUrl;
            this.git_hub_id = (int)repoData.GitHubId;
            this.trees_url = repoData.TreesUrl;
            this.statuses_url = repoData.StatusesUrl;
            this.languages_url = repoData.LanguagesUrl;
            this.stargazers_url = repoData.StargazersUrl;
            this.contributors_url = repoData.ContributorsUrl;
            this.subscribers_url = repoData.SubscribersUrl;
            this.subscription_url = repoData.SubscriptionUrl;
            this.commits_url = repoData.CommitsUrl;
            this.git_commits_url = repoData.GitCommitsUrl;
            this.comments_url = repoData.CommentsUrl;
            this.issue_comment_url = repoData.IssueCommentUrl;
            this.contents_url = repoData.ContentsUrl;
            this.compare_url = repoData.CompareUrl;
            this.merges_url = repoData.MergesUrl;
            this.archive_url = repoData.ArchiveUrl;
            this.downloads_url = repoData.DownloadsUrl;
            this.issues_url = repoData.IssuesUrl;
            this.pulls_url = repoData.PullsUrl;
            this.milestones_url = repoData.MilestonesUrl;
            this.notifications_url = repoData.NotificationsUrl;
            this.labels_url = repoData.LabelsUrl;
            this.releases_url = repoData.ReleasesUrl;
            this.deployments_url = repoData.DeploymentsUrl;
            this.created_at = repoData.CreatedAt;
            this.updated_at = repoData.UpdatedAt;
            this.pushed_at = repoData.PushedAt;
            this.git_url = repoData.GitUrl;
            this.ssh_url = repoData.SshUrl;
            this.clone_url = repoData.CloneUrl;
            this.svn_url = repoData.SvnUrl;
            this.homepage = repoData.Homepage;
            this.size = repoData.Size;
            this.stargazers_count = repoData.StargazersCount;
            this.watchers_count = repoData.WatchersCount;
            this.language = repoData.Language;
            this.has_issues = repoData.HasIssues;
            this.has_downloads = repoData.HasDownloads;
            this.has_wiki = repoData.HasWiki;
            this.has_pages = repoData.HasPages;
            this.forks_count = repoData.ForksCount;
            this.mirror_url = repoData.MirrorUrl;
            this.open_issues_count = repoData.OpenIssuesCount;
            this.forks = repoData.Forks;
            this.open_issues = repoData.OpenIssues;
            this.watchers = repoData.Watchers;
            this.default_branch = repoData.DefaultBranch;
            if (ownerIn == null)
            {
                this.owner = new Owner();
            }
            else
            {
                this.owner = new Owner(ownerIn);
            }

            if (permIn == null)
            {
                this.permissions = new Permissions();
            }
            else
            {
                this.permissions = new Permissions(permIn);
            }
        }

        public int id { get; set; }
            public string name { get; set; }
            public string full_name { get; set; }
            public Owner owner { get; set; }

            [JsonProperty("private")]
            public bool isPrivate { get; set; }
            public string html_url { get; set; }
            public string description { get; set; }
            public bool fork { get; set; }
            public string url { get; set; }
            public string forks_url { get; set; }
            public string keys_url { get; set; }
            public string collaborators_url { get; set; }
            public string teams_url { get; set; }
            public string hooks_url { get; set; }
            public string issue_events_url { get; set; }
            public string events_url { get; set; }
            public string assignees_url { get; set; }
            public string branches_url { get; set; }
            public string tags_url { get; set; }
            public string blobs_url { get; set; }
            public string git_tags_url { get; set; }
            public string git_refs_url { get; set; }
            public int git_hub_id { get; set; }
            public string trees_url { get; set; }
            public string statuses_url { get; set; }
            public string languages_url { get; set; }
            public string stargazers_url { get; set; }
            public string contributors_url { get; set; }
            public string subscribers_url { get; set; }
            public string subscription_url { get; set; }
            public string commits_url { get; set; }
            public string git_commits_url { get; set; }
            public string comments_url { get; set; }
            public string issue_comment_url { get; set; }
            public string contents_url { get; set; }
            public string compare_url { get; set; }
            public string merges_url { get; set; }
            public string archive_url { get; set; }
            public string downloads_url { get; set; }
            public string issues_url { get; set; }
            public string pulls_url { get; set; }
            public string milestones_url { get; set; }
            public string notifications_url { get; set; }
            public string labels_url { get; set; }
            public string releases_url { get; set; }
            public string deployments_url { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string pushed_at { get; set; }
            public string git_url { get; set; }
            public string ssh_url { get; set; }
            public string clone_url { get; set; }
            public string svn_url { get; set; }
            public string homepage { get; set; }
            public int size { get; set; }
            public int stargazers_count { get; set; }
            public int watchers_count { get; set; }
            public string language { get; set; }
            public bool has_issues { get; set; }
            public bool has_downloads { get; set; }
            public bool has_wiki { get; set; }
            public bool has_pages { get; set; }
            public int forks_count { get; set; }
            public string mirror_url { get; set; }
            public int open_issues_count { get; set; }
            public int forks { get; set; }
            public int open_issues { get; set; }
            public int watchers { get; set; }
            public string default_branch { get; set; }
            public Permissions permissions { get; set; }
        }


}


