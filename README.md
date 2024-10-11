# GitHub User Activity

## Description

This project allows you to fetch and display the recent GitHub activity of any user from the command line. It uses GitHub's REST API to pull the user's events (e.g., pushes, forks, issues, etc.) and shows them in a user-friendly format.<br>
Project Idea: https://roadmap.sh/projects/github-user-activity

## Requirements

- **.NET SDK (version)**: 8.0.400
- **Target Framework**: .NET 8.0 
- **Visual Studio** or **Visual Studio Code** (optional)

## Getting Started

### Clone or Download the Repository
```bash
git clone https://github.com/batuhansacofficial/GithubUserActivity.git
```
or download the ZIP file and extract it.

### Navigate to Project Directory
```bash
cd path/to/GithubUserActivity
```

### Build the Application
```bash
dotnet build
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
