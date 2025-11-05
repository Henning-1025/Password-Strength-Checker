# Password Strength Checker

A simple C# console program that checks how strong or weak a password is based on its' length and character types.

## Program Description

The program asks the user to input a password then evaluates its' strength using a series of if / else if / else statements

It checks for the following: - Password length - Presence of uppercase letters - Presence of lowercase letters - Presence of digits - Presence of symbols (f.e `!`, `@`, `#`, etc)

Based on these checks, it prints one of the following: - Very weak - Weak - Moderate - Strong - Strength not determined

## Steps

1. Start program
2. Ask user to input password
3. Read user input and store it as 'password'
4. Evaluate password properties
   - checks:
     - length: count characters
     - hasUpper: contains uppercase letters
     - hasLower: contains lowercase letters
     - hasDigit: contains digits
     - hasSymbol: contains symbols
5. Determine password strength
   - conditions:
     - if: length < 6
       - action: print "Very Weak"
     - else if: length >= 6 and length < 8
       - action: print "Weak"
     - else if: length >= 8 and (hasUpper or hasDigit)
       - action: print "Moderate"
     - else if: length >= 8 and hasUpper and hasLower and hasDigit
       - action: print "Strong"
     - else:
       - action: print "Strength not determined"
6. End program
