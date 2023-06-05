conn.execute("INSERT INTO Student (name, row, desk, variant) VALUES (?, ?, ?, ?)", ('John Doe', 1, 2, 3))
conn.commit()
