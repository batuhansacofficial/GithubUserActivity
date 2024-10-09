using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace GithubUserActivity
{
    public class GitHubClient
    {
        private static readonly HttpClient client = new HttpClient();

        public List<UserActivity> GetUserActivity(string username)
        {
            try
            {
                string url = $"https://api.github.com/users/{username}/events";
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Add("User-Agent", "GithubUserActivityApp");

                HttpResponseMessage response = client.SendAsync(request).Result;

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"User '{username}' not found.");
                    return new List<UserActivity>();  // Return an empty list instead of exiting
                }
                else if (response.StatusCode == HttpStatusCode.Forbidden &&
                         response.Headers.Contains("X-RateLimit-Remaining") &&
                         int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()) == 0)
                {
                    Console.WriteLine("GitHub API rate limit exceeded. Please try again later.");
                    return new List<UserActivity>();  // Return an empty list instead of exiting
                }
                else if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Failed to fetch activity. HTTP Status: {response.StatusCode}");
                    return new List<UserActivity>();  // Return an empty list instead of exiting
                }

                var jsonResponse = response.Content.ReadAsStringAsync().Result;
                var activities = JsonSerializer.Deserialize<List<UserActivity>>(jsonResponse);

                var distinctActivities = activities
                    .Distinct(new UserActivityComparer())  // Using custom comparer to remove duplicates
                    .ToList();

                return distinctActivities;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<UserActivity>();  // Return an empty list if an error occurs
            }
        }

    }

    public class UserActivityComparer : IEqualityComparer<UserActivity>
    {
        public bool Equals(UserActivity x, UserActivity y)
        {
            return x.EventType == y.EventType && x.Repo.Name == y.Repo.Name;
        }

        public int GetHashCode(UserActivity obj)
        {
            return HashCode.Combine(obj.EventType, obj.Repo.Name);
        }
    }
}
