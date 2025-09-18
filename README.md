# Dashboard (.NET MAUI Application)

A cross-platform dashboard application built with **.NET MAUI**.  
The project includes platform-specific files, resource management, and XAML-based UI pages.

---

## 📂 Project Structure

```text
Dashboard/
├── Pages/
│   ├── MainPage.xaml           # Main dashboard UI page
│   └── AddImagePage.xaml       # Page to add or upload images
├── Resources/
│   └── Images/                 # Image assets used in app
├── Platforms/                  # Platform-specific files (Android, iOS, Windows, etc.)
├── Properties/                 # Configuration & assembly info
├── AppShell.xaml               # Navigation shell for app
├── MauiProgram.cs              # App startup and dependency setup
├── Baclground.csproj           # Project file
├── .gitignore                  # Git ignore rules for VS/MAUI
└── README.md                   # Project documentation
```

---

## ⚙️ Requirements

- .NET SDK (version used in this project, e.g. .NET 7/8)  
- Visual Studio 2022+ with MAUI workload installed  
- For mobile targets: Android SDK / iOS toolchain  

---

## 🚀 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/Kalyanishivade/Dashboard.git
   cd Dashboard
   ```

2. Open in **Visual Studio**.  
   - Restore NuGet packages.  
   - Select target platform (Windows, Android, iOS, MacCatalyst).  

3. Build and run:
   - Run on Windows via **Start Debugging** (F5).  
   - Or deploy to Android/iOS if configured.  

---

## 📋 Features

- `MainPage.xaml`: main dashboard screen.  
- `AddImagePage.xaml`: UI page for adding/uploading images.  
- Cross-platform structure via `Platforms/`.  
- Centralized resources in `Resources/Images`.  
- Uses `.NET MAUI Shell` (`AppShell.xaml`) for navigation.  

---

## 🤝 Contributing

Contributions are welcome:  
- Fork the repository  
- Create a feature branch  
- Commit your changes  
- Open a Pull Request  

---


---

*Developed by [Kalyanishivade](https://github.com/Kalyanishivade)*
