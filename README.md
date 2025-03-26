# ✈️ TECAir Airline Management System — CE3101

## 📘 Overview

This repository contains the complete implementation of TECAir, a full-stack airline management system developed as part of the course CE3101 — Bases de Datos at the Instituto Tecnológico de Costa Rica.

TECAir simulates the digital infrastructure of a low-cost airline targeted primarily at students, allowing them to reserve flights, manage baggage, and perform check-ins online. The system includes both web and mobile applications, built following a layered architecture and modern development practices.

---

## 🧩 System Components

- **Web App: Reservations Portal**
  - Flight search and booking
  - Payment processing
  - Loyalty system for students
  - User registration and login
  - Promotions section

- **Web App: Airport Staff Portal**
  - Flight creation, opening, and closing
  - Passenger check-in and seat selection
  - Boarding pass generation
  - Baggage registration with dynamic pricing
  - Promotion management interface

- **Mobile App**
  - Fully functional offline support with **SQLite**
  - Syncs with central server when online
  - Replicates reservation portal functionality

- **Backend & API**
  - Built in **C#**, deployed over IIS
  - Handles business logic, RESTful communication
  - Interacts with PostgreSQL (no stored procedures, views, or triggers)

---

## 🧪 Technologies Used

- **Frontend**: Angular, Bootstrap, HTML5, CSS
- **Backend**: C# Web API
- **Databases**:
  - PostgreSQL (main DB)
  - SQLite (local mobile storage)
- **Other Tools**: Entity Framework, Crystal Reports (or similar)
