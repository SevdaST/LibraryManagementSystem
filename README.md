## Library Management Application

---

### Project Description
This project is a simple library management system developed in C# using object-oriented programming principles.

## Class Structure
- **Book**: Stores book information such as title, author, ISBN, and number of copies  
- **Member**: Stores member information including ID, full name, and Turkish ID Number (TCK No)  
- **Loan**: Represents the borrowing and returning process  
- **Library**: The main class that manages and coordinates all operations  
---
## Input Validation
- The length of the Turkish ID Number (TCK No) is checked  
- Invalid operations are prevented using exceptions  
---
## Design
- Core classes are located in the **LibraryApp.Core** project  
- WinForms and Console applications reference **LibraryApp.Core**
---
## Data Storage
- No database is used  
- No file storage is implemented  
- All data is stored in memory during runtime  
---
## Possible Improvements
- Prevent borrowing the same book by the same member before returning it  
- Prevent borrowing books with no available copies  
