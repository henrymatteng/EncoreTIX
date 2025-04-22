# EncoreTIX – .NET MAUI Blazor Mobile App

EncoreTIX is a mobile application built using .NET 9 MAUI Blazor that allows users to search for live attractions (bands, comedians, sports teams, etc.), view detailed information, and explore upcoming events. The app integrates with the Ticketmaster Discovery API and follows the provided Figma design.

---

## Features Implemented

### Search and Display
- Integrated search bar with a submit button to query attractions.
- Default search term is set to "Phish".
- Results are displayed in card format with the attraction’s name and image.
- Graceful "No Results Found" message when no matches are returned.

### Selection and Navigation
- Each card includes a “Select” button.
- Only one attraction can be selected at a time.
- Selecting an attraction navigates to its details screen.

### Attraction Details Screen
- Displays attraction name and image.
- Provides clickable external links to:
  - YouTube
  - Spotify
  - Twitter
  - Website
- Lists upcoming events with event name, venue, date/time, and event image (if available).

---

## Project Structure

EncoreTIX/   
├── Pages/   
│ ├── SearchPage.razor   
│ └── AttractionDetail.razor   
├── Shared/   
│ └── Header.razor   
├── wwwroot/   
│ ├── images/   
│ │ ├── placeholder.png   
│ │ └── sad.png   
│ ├── icons/   
│ │ ├── youtube.svg   
│ │ ├── spotify.svg   
│ │ ├── twitter.svg   
│ │ ├── website.svg   
│ │ └── search.png   
│ └── css/   
│ └── app.css  


---

## How to Run the Application

### Requirements
- .NET 9 SDK (Preview)
- Visual Studio 2022 or later with the .NET MAUI workload
- Android Emulator or Physical Device
- Ticketmaster API Key

### Setup Instructions

1. Clone the repository:
git clone https://github.com/your-username/EncoreTIX.git

2. Open the solution in Visual Studio.

3. Add your Ticketmaster API key in `appsettings.json`:
```json
{
  "Ticketmaster": {
    "ApiKey": "YOUR_API_KEY",
    "BaseUrl": "https://app.ticketmaster.com/discovery/v2"
  }
}
```
4. Set the MAUI Blazor app as the startup project.
5. Run the application using an emulator or physical device.
