# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Yanlin Tang
Yanlin Tang
## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer:  they are arrays that use the same index to represent 1 item. in the assignment I used them for the name and credits array so that they would not misalign.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: the count variable keeps track of how many students i've already added. I add 1 to the count variable for every new student I add and then verify it against the limit of students that I can add to make sure I'm not adding too many students.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: I use count to control how many times that loops would run because I only needed as many loops as there were students and count stores how many students are in the system.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: the foreach loop prints something for each student in the array, and I only need as many lines as there are students. I made a function called BuildRosterLines that made an array where each line was a formatted string with name and credits, foreach loops go through every line and prints them as needed.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: I copied the rosters that were being used into another roster, then used array.sort on that copy.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to make an array
2. How to use an array
3. How to organize an array
4. Putting in exits for loops when testing
5.

**Which loop felt most natural to use and why?**

Answer:

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Planning the arrays/menu: 2 minutes
- Input validation: 0.5 hours
- Add + print roster features: 2 hours
- Sorting feature: 1 hour
- Testing and debugging: .5 hours
- Writing documentation: 10 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:

## Reflection

**What would you do differently next time?**

Answer: I would figure out how to use array before trying to directly implement it.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: for helped me understand indexes within arrays, for each loops helped me understand that arrays are just collections of specific things.
