# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Test Student

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: It makes the entire program easier to read, find out where the errors are and debug them easier. I've had so much of an easier time trying to debug this assignment than any other one this quarter. god bless

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: min, max, average, count, orderby, orderbydescending, take, where

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: orderbydescending + take, orderbydescending + where,

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: if you have other things you need program to do, then you can keep track of the different functions of program better. It also makes it easier to debug as you can just put in breakpoints and see where the program breaks based on the class being called.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. linq and how to use/combine them.
2. how to debug linq methods
3. how to use comparisons for numbers
4. how to use string.join
5. how to use average.ToString("F1", CultureInfo.InvariantCulture)

**Which concept felt easiest (methods or LINQ) and why?**

Answer: methods because they're basically just the equivalent of chapters and an index in a book

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Understanding the starter code: .5 hours
- Implementing the print methods: .5 hours
- LINQ method chaining: 1 hour
- Testing and debugging: 1 hour
- Writing documentation: like 10 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: debugging the syntax for chaining the linq methods

## Reflection

**What would you improve next time?**

Answer: I would want to figure out how the chaining works before starting the assignment

**How did methods make this program easier to work on?**

Answer: It made it much easier to figure out what code I needed to write and debug
