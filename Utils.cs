namespace GithubUserActivity
{
    public static class Utils
    {
        public static string FormatActivity(UserActivity activity)
        {
            string actionDescription = activity.EventType switch
            {
                "PushEvent" => "Pushed to",
                "PullRequestEvent" => "Opened a pull request in",
                "IssuesEvent" => "Opened an issue in",
                "WatchEvent" => "Starred",
                "ForkEvent" => "Forked",
                "CreateEvent" => "Created a repository",
                _ => "Performed an action in"
            };

            return $"{actionDescription} {activity.Repo.Name}";
        }
    }
}