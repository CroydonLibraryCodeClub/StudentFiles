import time
print("Today you will guess our password.")
password=("password")
i=1
while i < 6:
  guess1=input("Guess the password?")
  i+1
  seconds=5
  for i in range(seconds):
    print(str(seconds-i)+"seconds remain")
    time.sleep(1)
  print("TIME IS UP")
  if guess1==("password"):
    print("Correct")
  else:
    print("Incorrect")
    hint1=input("Do you want a hint?")
    if hint1==("yes"):
      print("okay, its something you can put in a computer")
    else:
      print("okay")
      
