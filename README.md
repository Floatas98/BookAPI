# 📚 BookApp

A Blazor Web App that integrates with [OpenLibrary.org](https://openlibrary.org/developers/api) to search authors, browse their books, and view detailed information about each book — all through a clean and interactive UI.

---

## ✨ Features

- 🔍 **Author Search**: Type to search for authors via OpenLibrary API.
- 📚 **Books Listing**: View a list of books by the selected author.
- 📖 **Book Details Page**: Navigate to a dedicated page with:
  - Description
  - Subjects
  - Excerpts
  - Cover images
  - Related people/places/topics
  - Timestamps (creation, last modified)
- 🎯 Fully asynchronous and API-driven.
- 💄 Styled using Bootstrap + custom CSS.

---

## 🧱 Tech Stack

- **.NET 8 / Blazor Server**
- **C#**
- **OpenLibrary REST API**
- **Bootstrap 5**
- **Dependency Injection**
- **Component-based architecture**

---

## 📦 Folder Structure (Key Parts)

```
BookApp/
├── Components/
│   ├── Pages/                 # Book.razor, Home.razor, Error page
│   ├── Elements/              # Reusable components like BookList, SearchableDropdown
│   ├── Models/                # DTOs for Author, Book, Details, Search results, etc.
│   ├── Services/              # API clients (OpenLibraryService, IHttpClientService)
│   └── Layout/                # Main layout and navigation
├── wwwroot/                   # Static files (CSS, favicon, bootstrap)
├── Program.cs                 # App entry point
├── appsettings.json           # Config (can be expanded if needed)
├── BookApp.csproj             # Project file
```

---

## 🚀 Getting Started

### 1. **Clone the Repository**

```bash
git clone https://github.com/Floatas98/BookAPI.git
cd BookAPI
```

### 2. **Run the App**

> Make sure you have **.NET 8 SDK** installed.

```bash
dotnet run
```

The app should be available at `https://localhost:7039/`

---

## 🔧 Configuration

No API keys required — it uses public OpenLibrary endpoints.

You can optionally tweak settings in `appsettings.json`, but this project currently doesn't require external secrets.

---

## 📘 Usage Guide

1. **Search Author**: Start typing in the dropdown input on the homepage.
2. **Select Author**: Choose one from the suggestions.
3. **Browse Books**: See list of books tied to the selected author.
4. **View Book**: Click on a book to open its details page.

---

## 🛠 Development Notes

- OpenLibrary API response models are stored in `Components/Models`.
- Service classes use dependency injection and HttpClient for clean API integration.
- All external requests are asynchronous and handled with error catching.

---

## 🪪 License

MIT License. Free to use and modify.

---

## 🤝 Contributing

PRs welcome! If you want to expand features (book ratings, or local storage), feel free to fork and submit your ideas.

---

## 📮 Credits

- [OpenLibrary.org](https://openlibrary.org/developers/api) — for the free and open API.
