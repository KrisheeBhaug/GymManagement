# Gym Management Application
## Overview
### This project is a Gym Management System, built using C# and connected to a SQL Server database. It allows you to manage gym members, payment plans, equipments and other features through Gym admin. This guide will show you how to set up the project, connect to the database using SQL Server, and configure the application to use your own data source.


# Gym Management Application Setup Guide

## Prerequisites
### - SQL Server 2022
### - SQL Server Management Studio (SSMS): Install SSMS to connect to your database.
### - Git: Install Git to clone the repository and manage versions.
### - IDE (Visual Studio)

## Steps to Setup and Run the Application

## Step 1: Clone the Repository
### Clone the repository using the following Git command:
### git clone https://github.com/KrisheeBhaug/GymManagement

### Once cloned, navigate to the project folder:
### cd GymManagement

## Step 2: Open the Project Files
### Open the project folder in the IDE (Usually: Visual Studio).

## Step 3: Connect to SQL Server using SSMS and set the necessary database and tables
### To connect to your SQL Server instance using SSMS:
### 1. Open SQL Server Management Studio (SSMS).
### 2. In the Connect to Server window, enter your server details:
###  - Server Name: This is typically the machine name or localhost(In this case localhost).
###    - Authentication: Choose Windows Authentication or SQL Server Authentication.
###    - Make sure to trust the server first by ticking the box Trust Server
### 3. Click Connect to establish the connection to your server.
### 4. Run all SQL code provided in this repo

## Step 4: Obtain Data Source for app.config
### Once connected to SSMS:
### 1. Right-click on the Server in the Object Explorer and select Properties.
### 2. Under the General section, find the Connection Name.
###    - This will be your Data Source for the connection string.

## Step 5: Update the Connection String in app.config
### Open the app.config file and modify the connection string as follows:
### 1. Replace the Data Source in the connection string with the server name obtained from SSMS.
### 2. The modified connection string should look like this:

## <?xml version="1.0" encoding="utf-8" ?> 
## <configuration> 
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" /> 
    </startup>

    <connectionStrings> 
        <add name="GymDBConnection"
             connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=GymManagementDB;Integrated Security=True;TrustServerCertificate=True;" 
             providerName="System.Data.SqlClient" /> 
    </connectionStrings> 
## </configuration>

# Replace YOUR_SERVER_NAME with the Server Name you obtained in Step 4.

## Step 6: Build and Run the Application
### 1. Build the project in your IDE (e.g., Visual Studio).
### 2. Run the application. It should now connect to the GymManagementDB database using the connection string you provided.

---

## Troubleshooting

## Error: Unable to connect to SQL Server
### If you receive an error related to the connection, ensure that:
### - The Server Name is correct.
### - SQL Server is running and accessible.

## Error: Database not found
### If the application can't find GymManagementDB, make sure:
### - You have created the database with the correct name on your SQL Server.(GymManagementDB)
### - You ran the SQL codes we provided for the correct names and fields
### - The Initial Catalog is set correctly in the connection string.
### - The GymManagementDB exists on the SQL Server.

---

## End of Guide
