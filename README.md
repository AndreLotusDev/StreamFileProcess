# Large File Uploads in ASP.NET Core

This repository contains the source code accompanying our detailed guide on handling large file uploads in ASP.NET Core applications efficiently using streams. 

## Key Features

- **Stream Utilization**: Demonstrates how to use streams instead of byte arrays or MemoryStream, significantly improving memory management and processing speed.
- **Kestrel Configuration**: Instructions on configuring Kestrel in `Program.cs` to support the upload of large files.
- **Content Type Validation**: Implements a `MultipartFormDataAttribute` for ensuring the correct content type of incoming requests.
- **Custom Upload Summary**: Introduces a `FileUploadSummary` class to encapsulate the results of the file upload process.
- **File Service Implementation**: Provides a `FileService` class that reads files from request body streams and saves them efficiently.
- **Postman Testing**: Guide on how to test file uploads using Postman, including request setup and response handling.

## How to Use

1. Clone the repository to your local machine.
2. Follow the guide to set up Kestrel configuration and implement the necessary classes and attributes.
3. Test the upload functionality using Postman or a similar tool to ensure everything is working as expected.
