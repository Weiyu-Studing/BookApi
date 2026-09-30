# Library Management Web API

## Project Overview

This is a simple ASP\.NET Core Web API project for basic library management\. The system manages **Books, Authors, Categories, and Borrow Records**\. It provides basic data storage and API functions for library book borrowing management\.

The project uses Entity Framework Core code\-first architecture and RESTful API design\. It implements database CRUD basic logic, asynchronous operation, and standard API structure\.

## Problem Statement \& Purpose

Small libraries lack a simple backend system to manage book information, author information, book classification and borrowing records\. This API solves the problem of scattered manual records and provides standardized data management interfaces\.

This version only implements core lightweight functions for demonstration\. Advanced features will be added in future iterations\.

## Core Entities \& Relationships

The system contains four main entities with standard relational database relationships:

- **Author / Book \(One\-to\-Many\)**: One author can publish multiple books; each book belongs to one author\.

- **Book / BorrowRecord \(One\-to\-Many\)**: One book can have multiple borrowing records\.

- **Book / Category \(Many\-to\-Many\)**: One book can belong to multiple categories, and one category can include multiple books \(realized by BookCategory junction table\)\.

## Implemented API Features

This lightweight project completes 2 core functional endpoints:

- `GET /api/Books` — Query all books with author information

- `POST /api/Books/borrow` — Create new book borrowing record

## Tech Stack

- ASP\.NET Core Web API

- Entity Framework Core \(Code First\)

- SQL Server LocalDB

- Swagger UI for API testing

## How to Run

1. Build the project in Visual Studio

2. Run migration commands to create database

3. Start the project and open Swagger UI: `/swagger`

4. Test book query and borrow record creation APIs

## Future Improvements

- Book update and delete functions

- Book return record management

- Data validation and pagination

- Multi\-condition book search

