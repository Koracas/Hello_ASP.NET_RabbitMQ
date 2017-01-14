using System;
using System.Collections.Generic;

namespace MVC_RabbitMQ.Entity
{
    public partial class Permissions
    {
        public Permissions()
        {
            RepoData = new HashSet<RepoData>();
        }

        public int Id { get; set; }
        public bool Admin { get; set; }
        public bool Pull { get; set; }
        public bool Push { get; set; }

        public virtual ICollection<RepoData> RepoData { get; set; }
    }
}
