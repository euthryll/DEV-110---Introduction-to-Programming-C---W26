# Week 3: Personal Profile Card - Study Notes

**Name:** Yanlin Tang
Yanlin Tang
## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: string stores text (like the user's name) int stores whole numbers (like the expected year of graduation) double stores a decimal (like potentially the user's height) bool stores a true or false (like whether or not user is an honors student)

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: GPAs have decimals so you can't use int because int only stores whole numbers

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I set the boolean to yes if the string from the user's next input is set to yes or y

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I mostly based it on the comments in the instructions, but most information categorizing goes down to personal information, academic information, and information used for calculations.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: birth year, years till graduation, height in feet and inches, whether or not user is an honors student, age in months

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: requires less input from user, so less chance of user misinput

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: trying to figure out what type of data was required to pass the automated testing.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I tried changing all the data types that were quoted in the errors until it worked.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: where to use modulus and what to use it on

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: you use parse, int.Parse if you know user input will only be a whole number, double.parse if you know it could potentially have a decimal

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: feet is inches / 12 to get the feet, inches % 12 to get any remainders to add to the height

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: if the user had a 3.5 gpa or above then a boolean was set to true that confirms whether or not they are an honor student

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: :F2 only displays 2 decimal points, you just add it to whatever value or variable you want to display

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: I just used a boolean to show whether the student was full time, if they're not then they're part time

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I tried to space different sections out as much as I could

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: height in centimeters, years until retirement, total salary

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: invalid data types might mess with the precision of the application or cause a bug/crash. also saves memory.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: You could use it to create some sort of profile for your student body if you were a university. You could also change up a few things and use it for hiring etc.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. How to space out code properly
2. use switch instead of if else (even if i didn't use it in my code)
3. sometimes using doubles even if it seems like I should use int
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: int because I was having issues with testing some inputs

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: it stops the code from bugging/crashing and can also save processing power.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: the auto tests and asking my friends for information I could use as inputs. I did try decimal numbers for all the ones that made sense, but I didn't test negative numbers to be honest.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: Some of the auto tests weren't passing so I tried a bunch of things before I figured out that I had to switch the data type for some of my variables

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I used the auto tests and also tested it using my information.

## Time Spent

**Total time:** 5 hours

**Breakdown:**

-   Understanding data types and planning variables: [.5 hours]
-   Collecting user input with correct types: [1 hours]
-   Implementing calculations: [.5 hours]
-   Formatting output: [1 hours]
-   Testing and debugging: [1 hours]
-   Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Trying to debug/Collecting user input with correct types because I didn't realize that I had to use double for some of the variables like height

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: I would check that all of my data types for variables were right before writing all of my code, maybe plan it out a little more.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: It's easier to read and makes it easier for others to understand.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: Some sort of automated macro that does something for you, but that might be too advanced for me right now.
