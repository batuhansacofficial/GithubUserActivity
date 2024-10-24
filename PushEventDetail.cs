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