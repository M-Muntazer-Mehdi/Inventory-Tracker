# Table of Contents

1. [Project Description](#inventory-tracker)
2. [Features](#features)
   - [Super Admin Panel](#1-super-admin-panel)
   - [User Admin](#2-user-admin)
   - [Additional Features](#3-additional-features)
   - [Bonus Features](#4-bonus-features)
3. [EERD Diagram](#eerd-diagram)
4. [Adobe XD Prototypes](#adobe-xd-prototypes)
5. [Installation](#installation)
6. [Database Queries](#database-queries)
7. [Contributions](#contributions)


# Inventory-Tracker

The Inventory Management System is meticulously crafted to optimize the oversight of inventory items with precision and efficiency. This robust system encompasses essential functionalities including meticulous item tracking, comprehensive user management capabilities, and meticulous logging features. Designed to cater to the demands of structured inventory management, it serves as an indispensable tool for ensuring seamless operational control and insightful inventory oversight.

## Features

#### 1. Super Admin Panel
- **Dashboard View:** View item records individually and by society.
- **User Management:** Add temporary admins who can manage items but cannot add new users or view the dashboard.
- **Item Assignment:** Assign items to different societies.

#### 2. User Admin
- **Item Management:** Add, update, and delete item records.
- **tem Return:** Mark items as returned.
- **Category Management:** Organize items into categories (e.g., stationery).
- **Society Management:** Assign items to societies and manage their requirements.
- **Inventory Alerts:** Alerts for low inventory items.

#### 3. Additional Features
- **Requirements Gathering:** Collect and approve requirements from society representatives.

#### 4. Bonus Features:
- **Notification System:** Send notifications via Email/SMS for user logins.

## EERD Diagram
The Enhanced Entity-Relationship Diagram (EERD) for the Inventory Management System is shown below:

<table align="center">
  <tr>
    <td align="center">
     <img src="https://i.ibb.co/wM3q7LH/Drawing1.jpg" alt="Drawing1" border="0" width="400" height="500">
    </td>
  </tr>
</table>

## Adobe XD Prototypes
Interactive prototypes created using Adobe XD is [here](https://github.com/M-Muntazer-Mehdi/Inventory-Tracker/tree/main/Prototypes%20Files%20-%20Adobe%20XD).

## Installation
To set up the project on your local machine, follow these steps:
1. Clone the repository:
`git clone https://github.com/yourusername/Inventory-Management-System.git`
2. Navigate to the project directory:
`cd Inventory-Management-System`
3. Open the project in Visual Studio Code:
`code .`
4. Restore the dependencies:
`dotnet restore`
5. Run the application:
`dotnet run`

## Database Queries
This project includes essential SQL queries and scripts for managing the Oracle database, which can be found in the Database directory.

## Contributions
Contributions are welcome! Please fork the repository and create a pull request with your changes.

