using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubUserActivity
{
    public class PushEventDetail
    {
        public List<Commit> Commits { get; set; }
    }

    public class Commit
    {
        public string? Message { get; set; }
    }

}