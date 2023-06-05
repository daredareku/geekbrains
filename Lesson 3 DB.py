import sqlite3

# Create a connection to the database
conn = sqlite3.connect('school_classroom.db')

# Create the "Classroom" table with fields "id", "name", and "address"
conn.execute('''CREATE TABLE IF NOT EXISTS Classroom
             (id INTEGER PRIMARY KEY,
             name TEXT NOT NULL,
             address TEXT NOT NULL);''')

# Create the "Student" table with fields "id", "name", "row", "desk", and "variant"
conn.execute('''CREATE TABLE IF NOT EXISTS Student
             (id INTEGER PRIMARY KEY,
             name TEXT NOT NULL,
             row INTEGER NOT NULL,
             desk INTEGER NOT NULL,
             variant INTEGER NOT NULL);''')

# Create the "Schedule" table with fields "lesson_id", "classroom_id", "start_time", and "end_time"
conn.execute('''CREATE TABLE IF NOT EXISTS Schedule
             (lesson_id INTEGER PRIMARY KEY,
             classroom_id INTEGER NOT NULL,
             start_time TIMESTAMP NOT NULL,
             end_time TIMESTAMP NOT NULL,
             FOREIGN KEY(classroom_id) REFERENCES Classroom(id));''')

# Create the "Desks and Students" table with fields "lesson_id", "student_id", "row", "desk", and "variant"
conn.execute('''CREATE TABLE IF NOT EXISTS DeskStudent
             (lesson_id INTEGER NOT NULL,
             student_id INTEGER NOT NULL,
             row INTEGER NOT NULL,
             desk INTEGER NOT NULL,
             variant INTEGER NOT NULL,
              PRIMARY KEY(lesson_id, student_id),
              FOREIGN KEY(lesson_id) REFERENCES Schedule(lesson_id),
              FOREIGN KEY(student_id) REFERENCES Student(id));''')

# Close the connection to the database
conn.close()