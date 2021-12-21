# Script name:  Comment.R
# Created on:   December 4, 2021
# Author:       Marcus Hudgins
# Purpose:      Echo user input
# Versoin:      1.0
# Execution:    Must be ran as Source to await user input.

# Request user input.
name <- readline("Please enter your name: ")

# Concatenate input and strings.
greeting <- paste("Welcome", name, "!")

#Output concatenated string.
print(greeting)