# Password Strength Checker

A simple C# console program that checks password length.

## Program Description

The program asks the user to input a password then evaluates its' strength using a simple if/else statement.

It checks for the password length.

It then prints whether a password is too short.

## Steps

1. Start program
2. Ask user to input password
3. Read user input and store it as 'password'
4. Evaluate password properties
   - checks:
     - length: count characters
5. Determine password strength
   - conditions:
     - if: length < 8
       - action: print "Weak"
     - else:
       - action: print "Password is okay!"
6. End program
