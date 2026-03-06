# Week 5: Guess the Number - Study Notes

**Name:** Yanlin tang
Yanlin Tang
## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: while might not run even once, do-while runs at least once

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: because you need the user to give an input, then decide whether or not you need to repeat the loop

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: during the guess loop, you just want something that keeps going until the user gets it right, which can happen infinitely and doesn't have a range, while is good for that.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: For is used to record the amount of rounds because for gives you a range, and there's only a certain amount of rounds that the user can play so it's good for that

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: To reduce clutter and make it easier to read as well as more convenient to code.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: I had a boolean that went to true if the user input from parsing was bigger or equal to 10 and smaller than or equal to 100

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: Same thing as the last question, just a new range.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: the same function has a line that makes sure that user input is an integer and within the range, then runs the rest of code, otherwise it just tells the user to enter a valid input and loops. int.TryParse checks if user input can be converted into a number, and it does if able to

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: I had an if/else if/else loop for whether or not the guess variable was the same as the user input variable, if guess is over then it would say too high, if guess is under it would say too low, otherwise it'll be correct and program would tell user that they got it right.

**How did you count the number of guesses?**
[Explain where you incremented the counter]
I made a variable for a counter and increased it every single time the while loop was called
Answer:

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: I used Random to make the random number generator, then used another variable and next to use that generator to make a new random number
**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: the second value cannot be the random number, so the max would never be generated unless you do +1

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: numbers and characters, both letters and special characters

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: I kept accidentally making infinite loops that wouldn't end and would just softlock the terminal, so I had to figure out where stuff in the do-while and while loop went and whether or not the loop should be in the loop

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. how to do loops
2. how to avoid infinite looping
3. how to make a random integer
4.
5.

**Which loop felt most natural to use and why?**

Answer: while because it runs until a single condition is met.

## Time Spent

**Total time:** 6 hours
6 hours
**Breakdown:**

- Planning the loops: .5 hours
- Input validation: 1 hours
- Guessing logic: 2 hours
- Testing and debugging: 3 hours
- Writing documentation: .5 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Trying to debug the loops because I wasn't really sure how a loop worked within a loop

## Reflection

**What would you do differently next time?**

Answer: plan out how my loops worked next time because I honestly didn't

**How did using three different loop types improve your understanding of repetition?**

Answer: I understand what types of repetition are needed in certain scenarios and their different purposes.
