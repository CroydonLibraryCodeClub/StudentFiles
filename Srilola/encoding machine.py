import random
import string

chars = string.punctuation + string.digits + string.ascii_letters
chars = list(chars)
key = chars.copy()

random.shuffle(key)

#print(f"chars :{chars}")
#print("    ")
#print("")
#print("")
#print(f"key :{key}")

#Encryption
plain_text = input("Enter a message to encrypt: ")
cipher_text = ""


for letter in plain_text:
     index = chars.index(letter)
     cipher_text += key[index]

print(f"Original message = {plain_text}")
print(f"Encrypted message = {cipher_text}")

#Decryption
cipher_text = input("Enter a message to encrypt: ")
plain_text = ""


for letter in plain_text:
     index = key.index(letter)
     cipher_text += chars[index]

print(f"Original message = {cipher_text}")
print(f"Encrypted message = {plain_text}")
