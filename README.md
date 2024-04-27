# LogLibrary
# LogAPI

LogAPI is an ASP.NET Core Web Application that provides API endpoints for managing and analyzing log files.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Models](#models)
- [Contributing](#contributing)
- [License](#license)

## Features
- **Log Management**: Provides endpoints for managing log files, including archiving, deletion, and counting.
- **Error Analysis**: Allows counting unique and duplicated errors in log files.
- **Remote Logging**: Supports uploading log files to a remote server using an API.

## Installation
To run the LogAPI locally, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/LogAPI.git
   Open the solution file (LogAPI.sln) in Visual Studio.
Build the solution to restore dependencies.
Usage
To use the LogAPI, follow these steps:

1. Start the application in Visual Studio.
2. Navigate to the API endpoints using your preferred API client (e.g., Postman).
Endpoints
The following endpoints are available:

GET /log/unique-errors: Counts the number of unique errors in a log file.
GET /log/duplicated-errors: Counts the number of duplicated errors in a log file.
POST /log/delete-archive: Deletes archives from a specified period.
POST /log/archive-logs: Archives logs from a specified period.
POST /log/upload-logs: Uploads log files to a remote server.
POST /log/delete-logs: Deletes logs from a specified period.
GET /log/count-total-logs: Counts the total available logs in a specified period.
Models
The following model is used in the application:

ErrorLog
Represents an error log entry.

Id: Unique identifier for the error log.
Timestamp: Timestamp of when the error occurred.
Message: Error message.
Source: Source of the error.
Level: Error level.
