

name = input("What is your name? ")
my_number = input("Hello "+name+", please pick a number ")
my_number = int(my_number) + 1
print("Your number is "+str(my_number))

if(my_number > 100):
    print("That's a big number!")

if(my_number >= 20 and my_number < 30):
    print("That number is in the twenties!")