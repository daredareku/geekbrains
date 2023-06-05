cur = conn.cursor()
cur.execute("SELECT * FROM Student")
rows = cur.fetchall()
for row in rows:
    print(row)
