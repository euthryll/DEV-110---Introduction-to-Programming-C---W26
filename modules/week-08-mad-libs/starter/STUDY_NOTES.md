# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Yanlin Tang

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: ReadIntInRange helps validate that the user's input is a valid integer within the range of what the program wants. ReadYesNo sets a boolean to true or false based on whether or not the user types in y or n. ReadNonEmptyString makes sure that the user doesn't enter an input that somehow is either blank or invalid. Choosetemplate uses ReadIntInRange to decide which part of the program to call based on user input. CollectWord takes the user input and puts them into an array to use later

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: It helps improve readability so that there isn't a bunch of if statements and loops everywhere. It can go into its own separate corner and if something bugs out you can tell where easier.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: it stores which template you want to use, and then gives you a list of blanks to fill, then uses the things you filled to make a story using predetermined words that go with the blanks you filled in to create a mad libs.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: with a template you can use the same code for different stories.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I used a breakpoint right before and after the do-while loop inside storytemplate to make sure that it was giving the right outputs.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: It helped me find a bunch of typos that I had in the original code because it would point them out

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: I had a few errors where my string modifiers weren't capitalized and so it didn't recognize what it meant. having a breakpoint helped before it would show my code in segments so that errors only showed when I was on a specific section.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. breakpoints and how to use them
2. classes
3. how to access the debug menu

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: using public/private methods, it explained why I kept seeing random words above the code i've been writing for the past 7ish weeks

## Time Spent

**Total time:** 9 hours

**Breakdown:**

- Planning structure (methods/classes): 0.5 hours
- Input validation: 1 hour
- Story templates + formatting: 4
- Testing and debugging: 1.5
- Writing documentation: 1 hour

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: the story templates because I had to figure out how helper methods would use other helper methods and what the helper methods being called required.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: using the debug panel and breakpoints more.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: breaking helped me identify the issues with specific parts of my code. If the whole program wasn't working I could break it down into parts that I could test individually to see what broke and what didn't.
