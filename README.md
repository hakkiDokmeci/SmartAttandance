# 🎓 Classroom Automatic Attendance System  
A smart attendance management platform designed for universities. The system automates student attendance using classroom sessions, course management, teacher tools, and structured database workflows.

This project is developed as part of the **SE342 – Software Validation and Testing** course at **Maltepe University**.

---

## 🧩 Project Overview  
The system allows teachers to register students, manage courses and classrooms, start attendance sessions, and review attendance results. The backend provides secure API endpoints connected to a Microsoft SQL Server database using Entity Framework Core.

---

## 🚀 Features  
### 🔹 Student Management  
- Add and register new students  
- Store student details and program information  
- Associate students with attendance records  

### 🔹 Teacher Management  
- Add instructors  
- Assign courses  
- Manage account details and roles  

### 🔹 Course & Classroom Management  
- Create and update courses  
- Assign classrooms  
- Define weekly schedules  

### 🔹 Attendance Sessions  
- Start and end attendance sessions  
- Link sessions with classrooms and cameras  
- Prepare attendance data for recognition  

### 🔹 Attendance Recording  
- Generate attendance records  
- Link students and sessions  
- Store presence/absence statuses  

### 🔹 Reporting  
- View attendance summaries  
- Generate semester-level reports  

---

## 🏛 System Architecture  
The system follows a **three-layered architecture**:

### **1. Frontend**
- Static HTML/CSS interface  
- Teacher dashboard and management screens  
- Works as the presentation layer for API communication  

### **2. Backend (ASP.NET Core Web API)**
- RESTful API structure  
- Controllers for Teachers, Students, Courses  
- Input validation  
- Entity Framework Core DB operations  
- Swagger support for testing  
- Follows UI → API → Database data flow  

### **3. Database (Microsoft SQL Server)**
Entities include:
- Students  
- Teachers  
- Courses  
- Classrooms  
- Enrollments  
- Attendance Sessions  
- Attendance Records  

ERD is fully documented in the SRS and implemented via EF Core scaffolding.

---

## 🛠 Technologies Used  
| Layer | Technology |
|-------|------------|
| Backend | ASP.NET Core Web API |
| ORM | Entity Framework Core |
| Database | Microsoft SQL Server |
| Frontend | HTML, CSS, JavaScript |
| Tools | Swagger, PowerShell, .NET CLI |

---

## 🔧 Installation & Setup

### **Prerequisites**
- .NET 8 SDK  
- SQL Server Installed  
- Visual Studio / VS Code  

### **1️⃣ Restore Packages**
```bash
dotnet restore
