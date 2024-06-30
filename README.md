<table align="center">
  <tr>
    <td align="center">
     <img src="https://i.ibb.co/f263TWT/1.png" alt="1" border="0" width="800" height="400">
    </td>
  </tr>
</table>

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
   - [Concepts Covered](#concepts-covered)
7. [Database Study Material](#database-study-material)
   - [Contents](#contents)
8. [Contributions](#contributions)


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

<table align="center">
  <tr>
    <td align="center">
     <img src="https://i.ibb.co/pjV1VFN/3.png" alt="3" border="0" width="500" height="300">
    </td>
   <td align="center">
     <img src="https://i.ibb.co/HdL8XL0/4.png" alt="4" border="0" width="500" height="300">
    </td>
  </tr>
</table>

## EERD Diagram
The Enhanced Entity-Relationship Diagram [(EERD)](https://github.com/M-Muntazer-Mehdi/Inventory-Tracker/blob/main/EERD%20Diagram%20File%20-%20Visio.vsdx) for the Inventory Management System is shown below:

<table align="center">
  <tr>
    <td align="center">
     <img src="https://i.ibb.co/wM3q7LH/Drawing1.jpg" alt="Drawing1" border="0" width="500" height="600">
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
The Database directory contains essential SQL queries and scripts for managing the Oracle database, covering various key database concepts and functionalities:

#### Concepts Covered:
- **DDL (Data Definition Language):** Includes queries for creating tables, views, indexes, and other database objects.
- **DML (Data Manipulation Language):** Queries for inserting, updating, deleting data in tables.
- **Constraints:** Definitions for enforcing data integrity rules such as primary keys, foreign keys, unique constraints, etc.
- **Triggers:** Scripts that execute automatically in response to certain database events, enhancing data consistency and enforcing business rules.
- **Views:** Virtual tables based on the result of SQL statements, simplifying complex queries and enhancing data security.
- **Indexes:** Scripts for creating and managing indexes to improve query performance.
- **Database Security:** Queries related to user privileges, roles, and permissions management.

## Database Study Material

The [**Database Study Material Report File**](https://github.com/M-Muntazer-Mehdi/Inventory-Tracker/blob/main/Database%20Study%20Material.pdf) contains comprehensive study materials and resources related to database concepts and management. It includes detailed explanations, examples, and practical insights into various aspects of database design, SQL queries, database administration, and more.

### Contents:
- **Database Concepts:** Overview of fundamental database concepts.
- **SQL Queries:** Example queries and scripts for data manipulation and retrieval.
- **Database Administration:** Tips and strategies for efficient database management.
- **Advanced Topics:** Coverage of advanced database topics such as normalization, indexing, and transaction management.
- **Case Studies:** Real-world examples and case studies illustrating database implementation and optimization.

## Contributions
Contributions are welcome! Please fork the repository and create a pull request with your changes.

