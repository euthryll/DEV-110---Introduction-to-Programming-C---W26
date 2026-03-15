# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Yanlin Tang
Yanlin Tang

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: File.ReadAllLines returns a an array from the file it's reading (habits.csv in this case). We used it to read from the file and turn each line from the file into an array that was then turned into the habit object which contains 3 different strings

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: it might crash from trying to split and index an array with blank inputs

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: File.WriteAllLines either creates, overwrites a file by writing each string from an array. in our case it overwrote a specific file (arg 1) and use a specific array for the lines it was going to write down (arg 2).

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: select transforms the argument into a different sort of data type, specifically here it turns into a string and the ToArray takes those strings and puts them in an array.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: the FileNotFoundException is when either the user or the program can't find the right file to edit/store data.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: It's harder to debug what went wrong when you get an error that just says exception instead of file not found exception. In one case you kinda have to just throw yourself at a wall and try everything whilst the other you will know what to debug the moment the exception pops up.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. how to prevent crashes using exception
2. how to use lists
3. how to read and change different files

**What was the trickiest part of this assignment and how did you work through it?**

Answer: learning how to use all the code together like select and toarray

## Time Spent

**Total time:** 8.5 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 2 hours
- Implementing LoadHabits: 2 hours
- Implementing PrintHabits / PrintSummary: 1 hour
- Implementing AddHabit / UpdateHabit / SaveHabits: 2 hours
- Testing and debugging: 1 hour
- Writing study notes: .5 hours

**Most time-consuming part:**

Answer: figuring out how to implement load habits
