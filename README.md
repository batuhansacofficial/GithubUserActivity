# GithubUserActivity

## Description
This project allows you to fetch and display the recent GitHub activity of any user from the command line. It uses GitHub's REST API to pull the user's events (e.g., pushes, forks, issues, etc.) and shows them in a user-friendly format.

## Requirements
- **.NET SDK (version)**: 8.0.400
- **Target Framework**: .NET 8.0 
- **Visual Studio** or **Visual Studio Code** (optional)

## Getting Started

### Clone or Download the Repository
```bash
git clone https://github.com/batuhansacofficial/GithubUserActivity/
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

## Commands
- **To display the recent activity for a user**:
```bash
dotnet run <GitHub-username>
```
- **To filter the results by a specific event type**:
```bash
dotnet run <GitHub-username> <event-type>
```
(`event-type` can be *PushEvent*, *PullRequestEvent*, *IssuesEvent*, *WatchEvent*, *ForkEvent*, *CreateEvent*)
- **If the username is invalid, you will receive an error**:
```bash
Error: User 'invalidusername' not found.
```
- **If the GitHub API rate limit is exceeded, you will get:**:
```bash
GitHub API rate limit exceeded. Please try again later.
No activity found or an error occurred.
```
