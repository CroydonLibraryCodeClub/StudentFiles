#!/bin/python3
from random import choice

players = ['Max','Leo','Alex','Kari','Amari']
print(players)

print(choice(players))

teamA = []

playerA = choice(players)
print(playerA)
teamA.append(playerA)
players.remove(playerA)

print('Players left:', players)

teamB = []

playerB = choice(players)
print(playerB)
teamB.append(playerB)
players.remove(playerB)

print('players left:', players)

teamB = []