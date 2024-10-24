# GitHub User Activity

This project allows you to fetch and display the recent GitHub activity of any user from the command line. It uses GitHub's REST API to pull the user's events (e.g., pushes, forks, issues, etc.) and shows them in a user-friendly format.<br>
Project Idea: [GitHub User Activity]https://roadmap.sh/projects/github-user-activity

## Features

- Fetch and display the recent GitHub activity of any user.
- Filter the results by a specific event type.
- Display the results in a user-friendly format.

## Prerequision

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

### Clone or Download the Repository
```bash
git clone https://github.com/batuhansacofficial/GithubUserActivity.git
```
or download the ZIP file and extract it.

### Build and Run the Application

1. Build the application:
```bash
dotnet build
```

3. Run the application:
```bash
dotnet run
```

## Usage

### Display the Recent Activity For a User
```bash
dotnet run <GitHub-username>
```
### Filter the Results by a Specific Event Type
```bash
dotnet run <GitHub-username> <event-type>
```
(`event-type` can be *PushEvent*, *PullRequestEvent*, *IssuesEvent*, *WatchEvent*, *ForkEvent*, *CreateEvent*)

## Error Messages

- **If the username is invalid, you will receive an error**:
```bash
Error: User 'invalidusername' not found.
```

- **If the GitHub API rate limit is exceeded, you will get**:
```bash
GitHub API rate limit exceeded. Please try again later.
No activity found or an error occurred.
```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/batuhansacofficial/GithubUserActivity?tab=MIT-1-ov-file) file for details.