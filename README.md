# Employee-Time-Management-System

This is a school team final project

## Table of Contents

- [Employee-Time-Management-System](#employee-time-management-system)
  - [Table of Contents](#table-of-contents)
  - [Objectives](#objectives)
  - [Software Requirements Specification](#software-requirements-specification)
    - [Users](#users)
    - [Functional Requirements](#functional-requirements)
      - [1. Authentication Module](#1-authentication-module)
  - [Software Design Description (SDD)](#software-design-description-sdd)
    - [User Interface Design](#user-interface-design)
      - [Home page](#home-page)
    - [Sign Up page](#sign-up-page)
    - [Database Design](#database-design)
      - [Users Table](#users-table)
      - [Attendance Table](#attendance-table)

## Objectives

## Software Requirements Specification

### Users

1. Employee - This is users is able to login in the system when he/she arrives at the work station and is able to clock when leaving the work station.

1. HRM - View reports of employee attendance and reccommends the necessary plans of action.

### Functional Requirements

#### 1. Authentication Module

1. Creating users accounts
2. Login
3. Profile
4. Logout
5. Reset password
6. Edit profile

## Software Design Description (SDD)

### User Interface Design

This contain sketches of the interfaces. The sketches could draw by hand on a paper or use a prototyping tool like Figma.

#### Home page

![homepage](documentaion/images/homepage.png)

- navigation bar
- jumbotron / call to action
- Testimonials
- Footer

### Sign Up page

### Database Design

Contains tables of the database.

#### Users Table

| Column       | Type     | Lenght |
| ------------ | -------- | ------ |
| id           | int (PK) |
| first_name   | tinytext |
| last_name    | tinytext |
| email        | tinytext |
| password     | text     |
| user_type    | text     |
| last_updated | date     |

#### Attendance Table

| Column   | Type     | Lenght |
| -------- | -------- | ------ |
| id       | int (PK) |
| emp_no   | int(FK)  |
| time_in  | datetime |
| time_out | datetime |
