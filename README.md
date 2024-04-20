# Hotel Management System

## Overview

This Hotel Management System is designed to streamline various aspects of hotel operations, providing efficient tools for employees to manage daily tasks and enhance customer satisfaction. The system includes employee login, room availability management, customer registration, check-out process, and employee management functionalities.

## Features

### 1. Employee Login

- Secure login page for employees to access the system.

### 2. Dashboard

- Centralized dashboard for employees with intuitive tabs for easy navigation.

### Tabs on the Dashboard:

#### a. Add Rooms

- Allows employees to add new rooms to the system.
- Input fields for room number, room type (AC/Non-AC), bed type (single/double/triple), and price.
- The "Add Room" button will save room details in the database.

#### b. Customer Registration

- Enables registration of new customers checking into the hotel.
- Input fields for customer details such as name, phone number, nationality, gender, date of birth, ID proof, address, check-in date, bed type, room type, room number, and price.
- The "Allocate Room" button will save customer data and allocate a room.

#### c. Check-out

- Facilitates the check-out process for customers.
- Use the search field to find a specific customer.
- Automatically displays customer details upon selection.
- Check-out date selector.
- Use the "Check out" button to complete the check-out process and mark the room as available.

#### d. Customer Details

- Provides access to customer details based on different criteria.
- Options to view all customer details, including in-hotel and checked-out customers.

#### e. Employee Details

- Manages employee-related tasks and information.
- Three sub-tabs:
  1. **Employee Registration**: Allows registration of new employees with basic details and allocation of username and password.
  2. **Employee Details**: Displays essential information about all employees.
  3. **Remove Employee**: Enables searching for employees by ID and deleting their details from the database.

## Technologies Used

- C# Programming Language
- .NET Framework
- Microsoft Data SQLClient (for database interaction)
- SQL Server

## Installation and Setup

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/EdisCode/Project-Group5.git
   ```

2. **Navigate to the Project Directory:**

   ```bash
   cd Project-Group5
   ```

3. **Run the Application:**

   ```bash
   dotnet run
   ```

   - Ensure all dependencies are installed.
   - Configure the database connection string in `DatabaseConnection.cs`.
   - Run the SQL queries in your localdb.
   - Build and run the application.
   - Signin with `admin` - `admin`.

## Video Link

Follow this [Link](https://www.loom.com/share/5660fb60453b4d2ebd7271ba0799cfb9?sid=2fe827db-8926-4aa9-aa73-adaa93b31599) to watch the implementation video.

## Contributors

- [Edikan](https://github.com/EdisCode)
- [Anish](https://github.com/AnishReddi)
- [Motunrayo](http://github.com/Ogunseyemo)
- [Mayank](https://github.com/MayankSharma247)
- [Mahendra](https://github.com/patelmp)
