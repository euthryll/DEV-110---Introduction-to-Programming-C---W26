using System.Reflection.Metadata.Ecma335;

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // Variables below:
        string usersName = "placeholder";
        string userHometown = "placeholder, placeholder";
        string userColor = "placeholder";
        string userDreamjob = "placeholder";

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();
        Console.WriteLine("Please enter your full name");
        usersName = Console.ReadLine();
        Console.WriteLine($"{usersName} recorded, Please enter your hometown in this format [City, State]");
        userHometown = Console.ReadLine();
        Console.WriteLine($"{userHometown} recorded, Please enter your favorite color");
        userColor = Console.ReadLine();
        Console.WriteLine($"{userColor} recorded, Please enter your dream job");
        userDreamjob = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";
        string userMajor = "placeholder";
        double userGPA = 0;
        int userGradyear = 0;

        Console.WriteLine($"{userDreamjob} recorded, Please enter your current major");
        userMajor = Console.ReadLine();
        Console.WriteLine($"{userMajor} recorded, Please enter your GPA");
        userGPA = double.Parse(Console.ReadLine());
        Console.WriteLine($"{userGPA} recorded, Please enter your expected year of graduation");
        userGradyear = int.Parse(Console.ReadLine());
        Console.WriteLine($"{userGradyear} recorded, Please confirm if you are a full time student (yes/no)");
        string timeChoice = Console.ReadLine().ToLower();
        bool userFulltime = timeChoice == "yes" || timeChoice == "y";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)
        int userAge = 0;
        double userHeight = 0;
        int userFavNumber = 0;

        Console.WriteLine($"Student status recorded, Please enter your age");
        userAge = int.Parse(Console.ReadLine());
        Console.WriteLine($"{userAge} recorded, Please enter your height in inches");
        userHeight = double.Parse(Console.ReadLine());
        Console.WriteLine($"{userHeight} recorded, Please enter your favorite number");
        userFavNumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12
        bool honorStudent = false;
        int userBirthYear = 2026 - userAge;
        int userYearsTillGrad = userGradyear - 2026;
        int heightFeet = (int)(userHeight / 12);
        double heightInches = userHeight % 12;
        if (userGPA >= 3.5)
        {
            honorStudent = true;
        }
        else
        {
            honorStudent = false;
        }

        double userAgeMonths = userAge * 12;

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n======Personal Information======");
        Console.WriteLine($"Name: {usersName}");
        Console.WriteLine($"Hometown: {userHometown}");
        Console.WriteLine($"Favorite color: {userColor}");
        Console.WriteLine("\n======Academic Details======");
        Console.WriteLine($"Dream job: {userDreamjob}");
        Console.WriteLine($"Major: {userMajor}");
        Console.WriteLine($"GPA: {userGPA:F2}");
        Console.WriteLine($"Graduation year: {userGradyear}");
        Console.WriteLine("\n======Calculated statistics======");
        Console.WriteLine($"Age: {userAge}");
        Console.WriteLine($"Birth year: {userBirthYear}");
        Console.WriteLine($"Years until graduation: {userYearsTillGrad}");
        Console.WriteLine($"\nHeight: {heightFeet} feet {heightInches} inches");
        Console.WriteLine($"Height in inches: {userHeight}");
        Console.WriteLine($"Honor student: {honorStudent}");
        Console.WriteLine($"Age in months: {userAgeMonths}");
        Console.WriteLine($"Favorite number: {userFavNumber}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
