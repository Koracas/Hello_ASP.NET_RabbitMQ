using Server.DataModel;
using System;
using System.Collections.Generic;

namespace Server
{
    public partial class Owner
    {
        public Owner()
        {
            RepoData = new HashSet<RepoData>();
        }

        public Owner(Server.DataModel.Owner dataToShape)
        {
            this.GitHubId = dataToShape.id;
            this.AvatarUrl = dataToShape.avatar_url;
            this.EventsUrl = dataToShape.events_url;
            this.FollowersUrl = dataToShape.followers_url;
            this.FollowingUrl = dataToShape.following_url;
            this.GistsUrl = dataToShape.gists_url;
            this.GravatarId = dataToShape.gravatar_id;
            this.HtmlUrl = dataToShape.html_url;
            this.Login = dataToShape.login;
            this.OrganizationsUrl = dataToShape.organizations_url;
            this.ReceivedEventsUrl = dataToShape.received_events_url;
            this.ReposUrl = dataToShape.repos_url;
            this.SiteAdmin = dataToShape.site_admin;
            this.StarredUrl = dataToShape.starred_url;
            this.SubscriptionsUrl = dataToShape.subscriptions_url;
            this.Type = dataToShape.type;
            this.Url = dataToShape.url;
            RepoData = new HashSet<RepoData>();
        }


        public int Id { get; set; }
        public string AvatarUrl { get; set; }
        public string EventsUrl { get; set; }
        public string FollowersUrl { get; set; }
        public string FollowingUrl { get; set; }
        public string GistsUrl { get; set; }
        public int GitHubId { get; set; }
        public string GravatarId { get; set; }
        public string HtmlUrl { get; set; }
        public string Login { get; set; }
        public string OrganizationsUrl { get; set; }
        public string ReceivedEventsUrl { get; set; }
        public string ReposUrl { get; set; }
        public bool SiteAdmin { get; set; }
        public string StarredUrl { get; set; }
        public string SubscriptionsUrl { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

        public virtual ICollection<RepoData> RepoData { get; set; }
    }
}
