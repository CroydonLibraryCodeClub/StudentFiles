Score = 0
Wrong = 0

print("Welcome to the Trivia quiz")
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
if answer == "JK Rowling" or "Roald Dahl" :
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
