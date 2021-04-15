import sqlite3

conn = sqlite3.connect('TestDB.db')

c = conn.cursor()

c.execute('SELECT 1+1')

conn1 = sqlite3.connect('./home/dataskeptic/SQLite/mortality.db')

c1 = conn1.cursor()

result = c1.execute('SELECT * FROM VISIT')

print(result)
