import mysql.connector

config = {
  "user": "root",
  "password": "",
  "host": "127.0.0.1",
  "database": "memories"
}

connectionBdd = mysql.connector.connect(**config)
cursor = connectionBdd.cursor()

def checkLogin(email, password): 
      cursor.execute("SELECT email, password FROM user WHERE email = '{}' and password = '{}'".format(email, password))
      account = cursor.fetchone()

      if account:
            print("Connected")
      else:
            print("C'est non")

email = "jason.richard@epsi.fr"
password = "epsi"

checkLogin(email, password)

cursor.close()
connectionBdd.close()
