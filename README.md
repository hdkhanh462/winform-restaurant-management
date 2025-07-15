<div align="center">
  <h3 align="center">Restaurant Management System</h3>
  <p>A management platform for restaurants, supporting table, food, customer, staff, and billing management.</p>
  <div>
    <img src="https://img.shields.io/badge/-.NET-512BD4?logo=dotnet&logoColor=white" alt="dotnet">
    <img src="https://img.shields.io/badge/-CSharp-239120?logo=sharp&logoColor=white" alt="C#">
    <img src="https://img.shields.io/badge/-SQL Server-CC2927?logo=microsoftsqlserver&logoColor=white" alt="SQL Server">
    <img src="https://img.shields.io/badge/-WinForms-0078D6?logo=windows&logoColor=white" alt="WinForms">
  </div>
</div>

---

### 🚀 Features

- User authentication and profile management
- Table and area management
- Food and menu management
- Customer management
- Staff management
- Order and billing management
- Revenue and report statistics
- Role-based access control (admin, staff, etc.)
- Windows desktop client (WinForms)

### 🔨 Installation Guide

Follow these steps to install and use the application.

**Requirements**

Software:

- [.NET Framework 4.7.2+](https://dotnet.microsoft.com/en-us/download/dotnet-framework) (for Windows client)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or compatible database)

Hardware:

- RAM: 4GB or higher
- CPU: Any modern processor
- GPU: Optional

**Preparation**

- Update connection strings in the configuration files as needed (see `App.config` in the project).
- Ensure the database is accessible and configured (see `SQL/` folder for scripts).

**Database Setup**

1. Open SQL Server Management Studio.
2. Run the scripts in the `SQL/` folder in order:
   - `CreateTable.sql`
   - `Table.sql`
   - `Procedure.sql`
   - `View.sql`
   - `TestValues.sql`
3. Update the connection string in `App.config` to match your SQL Server instance.

---
