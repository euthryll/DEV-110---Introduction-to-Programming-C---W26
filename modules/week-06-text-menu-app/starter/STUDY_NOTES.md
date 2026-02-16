# Week 6: Text Menu App - Study Notes

**Name:** Yanlin Tang
Yanlin Tang
## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: do-while runs it once and then checks for the condition to see if it runs again, a while loop will just keep running until the condition is false

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: I used a do-while loop for the functions that checked if user input was correct, I did this because it needs to run once to check if user input the valid type of data, then if it isn't valid (meets conditions) I need to run the loop again

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used a while loop to create the menu navigation because you need to call the menu at the start of navigation and then call it again as long as the condition isn't met (user enters 6)

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: I didn't use a for loop because it repeats something a specific amount of times, and this program only uses loops that may potentially run infinitely. it would be pretty stupid if a user was using a menu and it randomly ran out of attempts like an arcade machine.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: I needed to verify the validity of the inputs multiple times, so it's better to make a function that does it and call it instead of rewriting the same code for clarity and ease of access

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I used a function with a do-while loop that checked if the user input was a number and if it ranged from 1 to 6, if it was valid then the loop ends and gives an output for the rest of the program to run, if it wasn't valid then it would repeat until input was valid

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I used a boolean that checked if int.TryParse or double.TryParse could try to convert the string that the user gave as input as either a integer or double respectively. If TryParse can convert, then it gives the converted output as "value" that then goes to the rest of the program for processing, otherwise it will return as false and the loop it is in will restart.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and {x,y:C2} to position and format my strings

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: String comparison which compares the input with a certain string of characters, this can have a lot of things but similarity is the one I used in the code. Substring takes a section of the inputted string. EndsWith checks if the input ends with a specific character. IndexOf finds the position of a character in the input, in my case in the code it checked where the space was.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: Concatenation joins strings together and interpolation begins with a $ then adding the names of the strings e.g. a + b vs $"{a}{b}". Both are good but I prefer interpolation because I'm more used to it

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. string concatenation
2. how to put code in specific places so that they are not interrupted by loops
3. string formatting
4.
5.

**Which loop felt most natural to use and why?**

Answer: while loops because they're really simple to understand personally and only require one thing to loop again

## Time Spent

**Total time:** 7 hours

**Breakdown:**

- Planning the loops: 1 hour
- Input validation: 2 hours
- String formatting: 2 hours
- Testing and debugging: 1 hour
- Writing documentation: 1 hour

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: figuring out how to format the strings properly

## Reflection

**What would you do differently next time?**

Answer: figure out what stuff to put outside the loops first so I don't have to spend 30 minutes figuring out where to put a blank line

**How did using three different loop types improve your understanding of repetition?**

Answer: I got more familiar with loops and am more confident on where and where to use them.
