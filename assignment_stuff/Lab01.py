# 1. Name: 
#    Scott Slater
# 2. Assignment Name: 
#    Lab 01: Python Review
# 3. Assignment Description:
#    Play a number-guessing game, putting in random numbers and going higher/lower until you find it.
# 4. What was the hardest part? Be as specific as possible.
#    I can't really say there was a hardest part. If anything, it was just figuring out what "array" and "sentinal" meant.
#    Once I realized it was just a guess count and a guess list, it was trivial from there. This stuff is still fresh on my mind, so
#    I really didn't have any trouble. I'd say the big issue was how late I got this in, since I forgot its due date. Apologies!
# 5. How long did it take for you to complete the assignment?
#    This went by pretty quickly, so I'd say around 30 minutes? After reading up on everything, coding it went by really fast.

import random

# Game introduction.
print('This is the "guess a number" game.')
print('You try to guess a random number in the smallest number of attempts.')
print()

# Prompt the user for how difficult the game will be. Ask for an integer.
value_max = int(input('Pick a positive integer: '))

# Generate a random number between 1 and the chosen value.
value_random = random.randint(1, value_max)

# Give the user instructions as to what he or she will be doing.
print(f'Guess a number between 1 and {value_max}.')

# Initialize the sentinal and the array of guesses.
guess_list = []
guess_count = 0

# Play the guessing game.
guess = 0
while guess != value_random:
    # Prompt the user for a number.
    guess = int(input("> "))
    # Store the number in an array so it can be displayed later.
    guess_list.append(guess)
    guess_count += 1
    # Make a decision: was the guess too high, too low, or just right.
    if guess > value_random:
        print('Too high!')
    elif guess < value_random:
        print('Too low!')
    elif guess == value_random:
        print(f'You got it! It was {value_random}!')
# Give the user a report: How many guesses and what the guesses where.
print(f'You were able to find the number in {guess_count} guesses.')
print(f'The numbers you guessed were: {guess_list}')