# NuGetSampleTrueConfVideoSDK

![изображение](https://github.com/user-attachments/assets/ec61dc4c-7b53-4a0f-979d-dc32637f9fb9)

## What Features Does the Example Demonstrate?

This project showcases the following capabilities:
   * Connecting to TrueConf VideoSDK via WebSocket and remotely managing a video conferencing application.
   * Handling incoming commands and events, with this information displayed in the "Logging" tab of the application’s main window.
   * Examples of API calls for TrueConf VideoSDK or TrueConf Room:
      * Connecting to a specified TrueConf video communication server.
      * Authorization of a user on the TrueConf server using their TrueConf ID and password.
      * Logging out the user.
      * Making a video call to a specific user by their TrueConf ID or joining a conference by its Conference ID.
      * Sending and receiving text chat messages.
      * Turning automatic handling of incoming video calls and conference invitations on or off.

### Example of Joining a Conference
Let’s walk through an example of calling into a conference:
   * Specify the address of our test server (e.g., video.example.com).
   * Log in with your credentials (username and password).
   * Enter the conference address and connect (paste the conference link and place the call).

Success! You’ve joined the conference!

## How does it work?

TrueConf provides not only complete solutions for corporate communication but also a range of SDKs for developers.

These tools enable the integration of messaging and video calling capabilities into corporate software.

You can, for example, enable direct calls to an operator from your company's self-service terminal.

The TrueConf.VideoSDK NuGet (newget) package is essentially a C# wrapper that includes all the functions and notifications required to work with the VideoSDK API. Detailed information about its features can be found in the documentation.

The project is available on our corporate GitHub: https://github.com/TrueConf/NuGetSampleTrueConfVideoSDK

## Requirements
   * Installed and running TrueConf Room or VideoSDK. You can download these tools via the following link: https://github.com/TrueConf/pyVideoSDK/blob/main/download.md
   * VideoSDK/Room address. This can be found on the main screen of the running application.
![изображение](https://github.com/user-attachments/assets/4233c798-2be1-43ee-8630-57f8c009de99)

   * .NET version 6 or higher.
   * Visual Studio 2022. We recommend running the project in this IDE for optimal compatibility.

## How to Install the TrueConf NuGet Package

   * Open the NuGetSampleTrueConfVideoSDK project in Visual Studio.
   * Navigate to Project → Manage NuGet Packages.
   * In the package manager window, select nuget.org as the package source.
   * Enter TrueConf in the search field and select TrueConf.VideoSDK from the results.
   * Click Install in the pop-up window containing the package details.

You can access the NuGet package page here: https://www.nuget.org/packages/TrueConf.VideoSDK/
