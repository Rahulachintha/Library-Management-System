# 📚 Library Management System

A Windows desktop application built with **C# (.NET Framework)** and **Windows Forms** for managing a library's books, members, staff, and book transactions.

---

## 🖥️ Tech Stack

| Technology | Details |
|------------|---------|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| UI | Windows Forms |
| Database | SQL Server LocalDB (`.mdf`) |
| IDE | Visual Studio |

---

## ✨ Features

- 🔐 **Login System** – Separate login for Admin and Staff
- 📊 **Dashboard** – Overview of library statistics
- 📖 **Add Books** – Add new books with cover image support
- 👥 **Members Management** – Add and manage library members
- 👨‍💼 **Staff Management** – Manage staff accounts
- 📤 **Issue Books** – Issue books to members
- 📥 **Return Books** – Handle book returns and track due dates

---

## 🔑 Default Admin Login

```
Username: admin
Password: admin
```

---

## 🚀 Getting Started

### Prerequisites

- Windows OS
- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/) with `.NET Desktop Development` workload
- SQL Server LocalDB (included with Visual Studio)

### How to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/Rahulachintha/Library-Management-System.git
   ```

2. **Open the solution**
   - Navigate to `LibraryManagementSystem/LibraryManagementSystem.sln`
   - Open it with Visual Studio

3. **Build and Run**
   - Press `F5` or click **Start** in Visual Studio
   - The application will launch and display the Login screen

> **Note:** The database file (`library.mdf`) is included in the project. Make sure SQL Server LocalDB is installed on your machine.

---

## 📁 Project Structure

```
LibraryManagementSystem/
├── Assets/                  # Icons and images
├── Books_Directory/         # Book cover images
├── AddBooks.cs              # Add Books form
├── Dashboard.cs             # Dashboard form
├── IssueBooks.cs            # Issue Books form
├── ReturnBooks.cs           # Return Books form
├── Members.cs               # Members management form
├── Staff.cs                 # Staff management form
├── LoginFrom.cs             # Login form
├── MainFrom.cs              # Admin main window
├── MainFromStaff.cs         # Staff main window
├── library.mdf              # LocalDB database file
└── Program.cs               # Application entry point
```

---

## 📸 Screenshots

> *(Add screenshots of your application here)*

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

## 👤 Author

**Rahulachintha**  
GitHub: [@Rahulachintha](https://github.com/Rahulachintha)
