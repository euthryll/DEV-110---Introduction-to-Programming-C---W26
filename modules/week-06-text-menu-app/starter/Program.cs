/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);

        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(divider);
        Console.WriteLine(subtitle);

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        while (choice != 6)
        {
            // TODO 3: Print the menu box
            // Required menu option texts (tests check for these):
            // - 1) Greeting Card
            // - 2) Name Tag Formatter
            // - 3) Phrase Analyzer
            // - 4) Fancy Receipt Line
            // - 5) Menu Banner Builder
            // - 6) Exit
            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");

            // TODO 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            // TODO 5: Use a switch statement to handle each menu option
            switch (choice)
            {
                // ===== OPTION 1: Greeting Card =====
                // Prompts: "Enter your name: " and "Enter a short message: "
                // Required string operations:
                // - Use Trim() to clean up the name
                // - Use ToUpper() for an uppercase version
                // - Use concatenation OR interpolation for greeting text
                // - Use string.Format() for at least one output line
                // - Display a boxed card with the name, uppercase name, and message
                // Include the word "Message:" in your output
                case 1:
                    Console.WriteLine("Enter your name: ");
                    string usersName = Console.ReadLine();
                    Console.WriteLine("Enter a short message: ");
                    string userMessage = Console.ReadLine();

                    string trimmedName = usersName.Trim();
                    string upperName = trimmedName.ToUpper();
                    string greeting = $"Hello, {trimmedName}!";
                    string formattedLine = string.Format("Uppercase Name: {0}", upperName);
                    Console.WriteLine("-" + new string('-', 38) + "-");
                    Console.WriteLine(($"| " + greeting).PadRight(39) + "|");
                    Console.WriteLine(("| " + formattedLine).PadRight(39) + "|");
                    Console.WriteLine(("| Message: " + userMessage).PadRight(39) + "|");
                    Console.WriteLine("-" + new string('-', 38) + "-");

                    break;

                // ===== OPTION 2: Name Tag Formatter =====
                // Prompts: "Enter first name: " and "Enter last name: "
                // Required string operations:
                // - Use Trim() on both inputs
                // - Use concatenation to build full name
                // - Use string indexing to get first characters for initials
                // - Use ToUpper() for initials
                // - Use ToLower() for lowercase version
                // Display three things:
                // - Name tag with the full name (include a bracket [)
                // - Initials (use word "Initials:" in label)
                // - Lowercase version (use word "Lowercase:" in label)
                case 2:

                    Console.WriteLine("Enter first name: ");
                    string userFirstName = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Enter last name: ");
                    string userLastName = Console.ReadLine() ?? string.Empty;

                    string trimmedFirstName = userFirstName.Trim();
                    string trimmedLastName = userLastName.Trim();
                    string fullName = trimmedFirstName + " " + trimmedLastName;
                    char firstInitial = trimmedFirstName.Length > 0 ? trimmedFirstName[0] : '?';
                    char lastInitial = trimmedLastName.Length > 0 ? trimmedLastName[0] : '?';
                    string initials = (string.Empty + firstInitial + lastInitial).ToUpper();
                    string lowerFullName = fullName.ToLower();

                    Console.WriteLine($"Name tag: [{fullName}]");
                    Console.WriteLine($"Initials: {initials}");
                    Console.WriteLine($"Lowercase: {lowerFullName}");

                    break;

                // ===== OPTION 3: Phrase Analyzer =====
                // Prompt: "Enter a phrase: "
                // Required string operations:
                // - Use Trim() on input
                // - Use Length property
                // - Use Contains() to check for letter 'a' (convert to lowercase first)
                // - Use Replace() to change spaces to dashes
                // - Use Split() to break into words
                // - Use string.Join() to create comma-separated list
                // Display: length, contains check, dashed version, and words list
                case 3:
                    Console.WriteLine("Enter a phrase");
                    string userPhrase = Console.ReadLine() ?? string.Empty;

                    string trimmedPhrase = userPhrase.Trim();
                    int phraseLength = trimmedPhrase.Length;
                    bool containsA = trimmedPhrase.ToLower().Contains('a');
                    string dashed = trimmedPhrase.Replace(' ', '-');
                    string[] words = trimmedPhrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string wordList = string.Join(", ", words);

                    Console.WriteLine($"Length: {phraseLength}");
                    Console.WriteLine($"Contains 'a': {containsA}");
                    Console.WriteLine($"Dashed: {dashed}");
                    Console.WriteLine($"Words: {wordList}");
                    break;

                // ===== OPTION 4: Fancy Receipt Line =====
                // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
                // Use ReadDouble for price and ReadIntInRange for quantity
                // Required:
                // - Calculate total (price * quantity)
                // - Create a receipt table with header row (ITEM, QTY, TOTAL)
                // - Use string.Format() with composite formatting for the data row
                // - Use alignment specifiers (left/right alignment)
                // - Use currency format specifier (:C2) for the total
                case 4:

                    Console.WriteLine("Enter item name:");
                    string itemName = Console.ReadLine() ?? string.Empty;
                    double itemPrice = ReadDouble("Enter price:");
                    int itemQuantity = ReadIntInRange("Enter quantity (1-9):", 1, 9);
                    double itemPriceTotal = itemPrice * itemQuantity;
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,12}", "ITEM", "QTY", "TOTAL"));
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,12:C2}", itemName, itemQuantity, itemPriceTotal));
                    Console.WriteLine("----------------------------------------");

                    break;

                // ===== OPTION 5: Menu Banner Builder =====
                // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
                // Use ReadIntInRange for width (min=30, max=60)
                // Required string operations:
                // - Create border line with equals signs (use new string constructor)
                // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
                // - Use ToUpper() on title
                // - Display banner with borders and centered text
                // - Show three alignment examples (centered, left, right)
                case 5:

                    Console.WriteLine("Enter a title:");
                    string userTitle = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Enter a subtitle:");
                    string userSubtitle = Console.ReadLine() ?? string.Empty;
                    int userWidth = ReadIntInRange("Enter width (30-60): ", 30, 60);

                    string border = new string('=', userWidth);
                    string upperTitle = userTitle.ToUpper();

                    string centeredTitle = upperTitle.PadLeft((userWidth + upperTitle.Length) / 2);
                    string centeredSubtitle = userSubtitle.PadLeft((userWidth + userSubtitle.Length) / 2);

                    Console.WriteLine("Centered Banner: ");
                    Console.WriteLine(border);
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(centeredSubtitle);
                    Console.WriteLine(border);
                    Console.WriteLine();

                    Console.WriteLine("Other examples (left, right): ");
                    Console.WriteLine(border);
                    Console.WriteLine(upperTitle.PadLeft(userWidth));
                    Console.WriteLine(userSubtitle.PadLeft(userWidth));
                    Console.WriteLine(border);

                    Console.WriteLine(border);
                    Console.WriteLine(upperTitle.PadRight(userWidth));
                    Console.WriteLine(userSubtitle.PadRight(userWidth));
                    Console.WriteLine(border);

                    break;

                // ===== OPTION 6: Exit with String Analysis =====
                // Prompt: "Enter a closing word: "
                // Required string operations (demonstrate these 4 methods):
                // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
                // - Use Substring() to extract first 3 characters (check length first!)
                // - Use EndsWith() to check if ends with "!"
                // - Use IndexOf() to find position of space character
                // Display the results of all four operations
                // Then print: "Goodbye!"
                case 6:
                    Console.WriteLine("Enter a closing word: ");
                    string closingLine = Console.ReadLine() ?? string.Empty;

                    string goodbye = "goodbye";
                    bool matchesGoodbye = closingLine.Equals(goodbye, StringComparison.OrdinalIgnoreCase);

                    string firstLetters = closingLine.Length >= 3 ? closingLine.Substring(0, 3) : closingLine;

                    bool endsWithMark = closingLine.EndsWith("!");

                    int lineIndex = closingLine.IndexOf(' ');

                    Console.WriteLine($"Matches 'goodbye': {matchesGoodbye}");
                    Console.WriteLine($"First 3: '{firstLetters}'");
                    Console.WriteLine($"Ends with '!': {endsWithMark}");
                    Console.WriteLine($"Index of first space: {lineIndex}");
                    Console.WriteLine("Goodbye!");

                    break;

                    // TODO 6: Add a blank line between menu actions (but not after Exit)
            }

            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // TODO 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number
        int value;
        bool isValid;

        do
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);
        return value;
    }

    private static double ReadDouble(string prompt)
    {
        // TODO 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number
        double value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = double.TryParse(input, out value);
        }
        while (!isValid);

        return value;
    }
}
