# Vestel Entry Fullstack Developer – Technical Assessment

This repository contains my solutions for the two assessment tasks described in the provided PDF.  
The goal was to implement:

1. **Task 1 – Frontend Component** (HTML/CSS, optional JS)
2. **Task 2 – .NET (6 or later) Web API** (POST `/api/reverse`)

Both tasks were completed **strictly according to the PDF requirements**.

---

## 📂 Project Structure
Vestel-Fullstack-Tasks/
│
├── Task1-Frontend/
│ └── index.html
│
├── ReverseTextApi/ # Task 2 - API project
│ ├── Controllers/
│ │ └── ReverseController.cs
│ ├── Models/
│ │ ├── ReverseRequest.cs
│ │ └── ReverseResponse.cs
│ ├── Program.cs
│ └── ReverseTextApi.csproj
│
└── ReverseTextApi.Tests/ # Task 2 - Unit tests
├── ReverseLogicTests.cs
└── ReverseTextApi.Tests.csproj


---

## 📝 Task 1 – Frontend Component

**Objective (from PDF):**  
> Build a UI component based on the attached image using HTML, CSS, and JavaScript only if needed. Focus on matching the visual appearance.

**My approach:**
- Used the **exact flexbox layout** and spacing from the base CSS in the PDF.
- Matched **colors precisely** using an online color palette tool from the provided design.
- Ensured **typography, icon sizes, button placement, and divider line** were consistent with the reference.
- Made the component self-contained in a single HTML file for easy viewing.

**How to run:**
1. Open `Task1-Frontend/index.html` in any modern web browser.
2. No setup required — works offline.


---

## 📝 Task 2 – Reverse Text API

**Objective :**  
> Create a .NET Core Web API with POST `/api/reverse` that takes `{ "text": "..." }` and returns `{ "reversedText": "..." }`.  
> If input is invalid → return `400 Bad Request` with `{ "error": "Text cannot be empty." }`.  
> Bonus: Add a unit test.

**My approach:**
- Built with **.NET 9** using MVC-style Controllers.
- Added **input validation** for null, empty, or whitespace-only strings.
- Returns the **exact output format** required by the PDF.
- Integrated **Swagger** for easy API testing.
- Created **unit tests** with xUnit covering:
  - Normal strings
  - Empty strings
  - Single characters
  - Special characters

---

## ▶️ Running the API

### 1. Prerequisites
- Install [.NET 6 SDK or later](https://dotnet.microsoft.com/en-us/download)

### 2. Start the API
```bash
cd ReverseTextApi
dotnet run
```
---
# 🧪 Testing the API
### Option 1 – Swagger (Recommended)
-When the API starts, copy the Swagger UI link from the terminal (http://localhost:5230/swagger/).

-Open it in your browser.

-Expand POST /api/reverse.

-Click "Try it out" and enter:
```bash
{ "text": "hello world" }
```
-Click Execute — you’ll see:
```bash
{ "reversedText": "dlrow olleh" }
```
-Or you can enter anything and it will Execute the reversedText back to you.

---
### Option 2 – cURL in Command Prompt / Terminal
```bash
curl -X POST "https://localhost:5230/api/reverse" ^
-H "Content-Type: application/json" ^
-d "{ \"text\": \"hello world\" }" --insecure
```
-Note: --insecure is needed for localhost HTTPS without a trusted certificate.
If your environment supports it, you can omit that flag.

# 🧪 Running Unit Tests
```
cd ReverseTextApi.Tests
dotnet test --no-build --verbosity normal
```
This runs all xUnit tests in ReverseTextApi.Tests.

---
📸 Screenshots

## Project Structure
<img width="440" height="985" alt="image" src="https://github.com/user-attachments/assets/d60aeece-1e71-4ee3-9b64-474b0af6e352" />

## Task 1 
<img width="1917" height="956" alt="image" src="https://github.com/user-attachments/assets/e9174ebe-324f-4487-86b1-b2294d490c1e" />

## Task 2 running it and opening Swagger and executing
<img width="1002" height="306" alt="image" src="https://github.com/user-attachments/assets/d523d611-cf36-415b-b7c1-cf6570bb8cd6" />
<img width="389" height="46" alt="image" src="https://github.com/user-attachments/assets/f2c135f9-e1b1-4cf9-94b7-b57ef1acd6b2" />
<img width="1784" height="834" alt="image" src="https://github.com/user-attachments/assets/ec871708-ed99-4622-8dfb-5ca3e3b9c140" />
<img width="1762" height="869" alt="image" src="https://github.com/user-attachments/assets/f5cd530b-8a3d-41c7-a580-c4c8433676e8" />
<img width="1787" height="897" alt="image" src="https://github.com/user-attachments/assets/f59deb3f-8bff-48f7-9012-6c42106071b4" />


## Task 2 Unit Testing 

<img width="957" height="299" alt="image" src="https://github.com/user-attachments/assets/ce94c0a3-bc3b-49be-8110-6a8df7303c56" />






