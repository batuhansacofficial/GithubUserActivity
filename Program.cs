using GithubUserActivity;

if (args.Length == 0)
{
    Console.WriteLine("Usage: github-activity <username>");
    Environment.Exit(1);  // Exit with non-zero status code
}

string username = args[0];
string eventType = args.Length > 1 ? args[1] : null;

try
{
    var client = new GitHubClient();
    var userActivity = client.GetUserActivity(username);

    if (userActivity == null || !userActivity.Any())
    {
        Console.WriteLine("No activity found or an error occurred.");
        Environment.Exit(1);  // Exit if userActivity is null or empty
    }

    // If eventType is provided, filter results by event type
    if (!string.IsNullOrEmpty(eventType))
    {
        var filteredActivities = userActivity.Where(a => a.EventType == eventType).ToList();
        foreach (var activity in filteredActivities)
        {
            Console.WriteLine($"{activity.EventType} in {activity.Repo.Name}");
            Console.WriteLine($"  Event Date: {activity.CreatedAt}");
        }
    }
    else
    {
        foreach (var activity in userActivity)
        {
            Console.WriteLine($"{activity.EventType} in {activity.Repo.Name}");
            Console.WriteLine($"  Event Date: {activity.CreatedAt}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
    Environment.Exit(1);  // Graceful exit with non-zero status
}