import webbrowser

Score = 0
Wrong = 0

url= 'https://dn721809.ca.archive.org/0/items/youtube-xvFZjo5PgG0/xvFZjo5PgG0.webm'
2url=''

name = (input("What is your name?"))
print(f"Welcome to the Trivia quiz {name}")
print("There will be 5 questions for you to answer")
print("Here is the first one")

print("Question 1")
answer=input("Who is the most powerful pokemon god?")
if answer == "Arceus":
    print("Well done! That is correct")
    Score = Score + 1
else:
    print("Sorry,That is incorrect")
    Wrong = Wrong + 1

print("Question 2")
answer=input("What is the most dangerous animal on Earth? ")
if answer == "Mosquito":
    print("Well done! That is correct.")
    Score =Score+1
else:
    print("Sorry, that is incorrect")
    Wrong = Wrong+1

print("Question 3")
answer=input("What is the most popular childrens author? ")
if answer == "JK Rowling" or answer == "Roald Dahl" :
    print("Well done! That is correct.")
    Score =Score+1
else:
    print("Sorry, that is incorrect")
    Wrong = Wrong+1

print("Question 4")
answer=input("What country does Harry Kane play for in football? ")
if answer == "England":
    print("Well done! That is correct.")
    Score =Score+1
else:
    print("Sorry, that is incorrect")
    Wrong = Wrong+1

print("Question 5")
answer=input("what star sign is represented by twins")
if answer == "Gemini":
    print("Well done! That is correct.")
    Score =Score+1
else:
    print("Sorry, that is incorrect")
    Wrong = Wrong+1

print(f"Well done {name}, your score is {Score}")
print(f"However, you got {Wrong} questions wrong")

if Score == 5:
    print("Your rank is Trivia genius")
elif Score == 4:
    print("Your rank is Trivia wizard")
elif Score == 3:
    print("Your rank is average")
elif Score == 2:
    print("Your rank is beginner")
else:
    print("Your rank is noob")

if Score == 0:
    webbrowser.open_new_tab(url)
elif Score == 1:
   webbrowser.open_new_tab(url)
elif Score == 2:
    webbrowser.open_new_tab()
elif Score == 3:
    webbrowser.open_new_tab()
else:
     webbrowser.open_new_tab()
