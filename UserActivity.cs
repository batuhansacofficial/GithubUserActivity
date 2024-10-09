using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class UserActivity
{
    [JsonPropertyName("type")]
    public string EventType { get; set; }

    [JsonPropertyName("repo")]
    public Repo Repo { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("payload")]
    public PayloadDetail Payload { get; set; }

    public string CommitMessage { get; set; }
}

public class PayloadDetail
{
    [JsonPropertyName("commits")]
    public List<Commit> Commits { get; set; }
}

public class Commit
{
    [JsonPropertyName("message")]
    public string Message { get; set; }
}

public class Repo
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
