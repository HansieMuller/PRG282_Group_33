Student Management System - Project PRG2782
This project is a C# Windows Forms application for managing student records using text files, with integrated Git version control. The application allows users to add, view, update, delete, and generate reports on student records, while also providing robust error handling and validation.

Features
Add New Student
Users can input student details (Student ID, Name, Age, and Course) through a form and save these records in students.txt.

View All Students
Displays all student records from students.txt in a DataGridView for easy viewing.

Update Student Information
Users can search for students by ID, edit details in the form, and save the changes back to students.txt.

Delete a Student
Allows users to select and delete a student record from the DataGridView, removing it from students.txt.

Generate Summary Report
Calculates the total number of students and the average age, displaying the summary on the form and saving it in summary.txt.

Version Control
The project utilizes Git for version control:

Repository Initialization: A Git repository is initialized in the project folder.
Commit Structure: Each major change (Add, Update, Delete, Report Generation) is committed with descriptive messages.
GitHub Integration: The repository is synced with a remote GitHub repository for easy version tracking and collaboration.
Error Handling and Code Documentation
Includes error handling for file operations and validation for inputs, enhancing reliability.
Inline comments improve code readability and maintainability.
