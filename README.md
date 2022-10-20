# GowanMMiniChallenge4
Madeline Gowan
10-18-2022
Mini Challenge 4 - Redo
In this program we must compare two numbers, and the console should write if the numbers are greater than, lesser than, or equal to one another.

Peer Review by: Kenneth Fujimura
Project appears to do what it needs to do. I do like how your code is written; it flows in an aesthetically pleasing way. Some suggestions if you wish to refactor some of the code:

- You could turn your multiple if statements at the end that evaluates whether numbers are larger than the others into else if statements that connect to one another and flow a little better.

- Indent/tab everything inside the play again while loop. Being able to visually see what's inside loops and functions based on indentation is an easy way to keep your code more organized and for legibility for others.

- You could expand your input validation significantly. Using a TryParse would be an easy way to make sure your program users are putting in integers and nothing else. Your program as designed right now would error out if someone put say, letters when you're asking for numbers. Your program also doesn't have a way of responding to if the user responds with anything but y/n for repeating the game, and just exits out entirely.

Also, make sure before you submit this to make a few adjustments to your project so you don't get in trouble with Mr Martinez:

- Rename this project "GowanMGreaterThanOrLessThan" -- they want the name of the project, not that it was Mini Challenge #4.

- Make sure to include a brief description of this program in this README file. 


Response by Madeline Gowan: I appreciate the feedback and have taken it into consideration to the best of my ability and understanding. I have since tried to correct the formatting to make it more user-friendly and organized, used TryParse to ensure only integers could be considered, and tried to fix the errors in which the loop did not continue when something other than Y or N was entered.

Edit: Everything is actually working really well now! The data validation works and everything runs smoothly, you've got a great working and looking program now! The only thing nitpicky thing (that at this point doesn't matter too much) is:
- If the user puts in something other than a whole number. So I would either put in a short clarification that a user should insert a whole number, or change the data type to something like 'double' that can handle fractions. (I would do the former, it's easier lol)
- I just asked Ken now, and apparently we need to have our peer reviews in both the README file, as well as at the top of our vs code. So just keep a look out for that in all your other assignments.
