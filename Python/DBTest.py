import sqlite3
import pandas as pd
conn = sqlite3.connect('TestDB.db')
c = conn.cursor()
result = c.execute('SELECT 1+1')
print(result.fetchall())

conn1 = sqlite3.connect('./DataBases/SQLite/mortality.db')
c1 = conn1.cursor()
result1 = c1.execute('SELECT * FROM VISIT')
for i in result1:
    print(i)

df = pd.read_sql_query('SELECT * FROM VISIT', conn1)
print(df.head())