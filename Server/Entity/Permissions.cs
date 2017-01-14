using Server.DataModel;
using System;
using System.Collections.Generic;

namespace Server
{
    public partial class Permissions
    {
        public Permissions()
        {
            RepoData = new HashSet<RepoData>();
        }
        public Permissions(Server.DataModel.Permissions dataToShape)
        {
            this.Admin = dataToShape.admin;
            this.Pull = dataToShape.pull;
            this.Push = dataToShape.push;          
            RepoData = new HashSet<RepoData>();
        }

        public int Id { get; set; }
        public bool Admin { get; set; }
        public bool Pull { get; set; }
        public bool Push { get; set; }

        public virtual ICollection<RepoData> RepoData { get; set; }
    }
}
