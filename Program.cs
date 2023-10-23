using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random dice = new();
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");

        IncrementDecrement();
        CalculateGrades();
        CalculateGPA();
        GenerateRandomNumber();
        SumMethod();
        ShowTime();
        Console.ReadLine();
    }

    public static void IncrementDecrement()
    {
        int value = 10;

        value = value++;
        Console.WriteLine("First increment: " + value);

        value++;
        Console.WriteLine("Second increment: " + value);

        value--;
        Console.WriteLine("Third decrement: " + value);
    }

    public static void CalculateGrades()
    {
        // initialize variables - graded assignments

        //############# Total grade ###########
        int currentAssignments = 5;

        decimal[] sophia = { 93m, 87m, 98m, 95m, 100m };
        decimal[] nicolas = { 80m, 83m, 82m, 88m, 85m };
        decimal[] zahirah = { 70m, 96m, 73m, 85m, 79m };
        decimal[] jeong = { 90m, 92m, 98m, 100m, 97m };

        string CalculateAverage(decimal[] grades)
        {
            decimal total = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }
            decimal output = total / currentAssignments;

            if (output >= 95)
                return $"({output})\tA+";
            else if (output >= 90)
                return $"({output})\tA";
            else if (output >= 83 && output <= 86)
                return $"({output})\tB+";
            else
                return $"({output})\tB";
        }

        Console.WriteLine("Student\t\tGrade");
        Console.WriteLine("Sophia\t\t" + CalculateAverage(sophia));
        Console.WriteLine("Nicolas\t\t" + CalculateAverage(nicolas));
        Console.WriteLine("Zahirah\t\t" + CalculateAverage(zahirah));
        Console.WriteLine("Jeong\t\t" + CalculateAverage(jeong));
    }

    public static void CalculateGPA()
    {
        //-------------- CALCULATE THE GPA OF A STUDENT -------------------------//
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";
        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;
        int gradeA = 4;
        int gradeB = 3;
        double totalHours =
            course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
        double calc1 = (course1Credit) * (gradeA);
        double calc2 = (course2Credit) * (gradeB);
        double calc3 = (course3Credit) * (gradeB);
        double calc4 = (course4Credit) * (gradeB);
        double calc5 = (course5Credit) * (gradeA);

        double calcsum = calc1 + calc2 + calc3 + calc4 + calc5;
        double gpa = calcsum / totalHours;

        Console.WriteLine(
            $"Student: {studentName}\n\n"
                + "Course\t\t\tGrade\tCredit Hours\n"
                + $"{course1Name}\t\t{gradeA}\t\t{course1Credit}\n"
                + $"{course2Name}\t\t{gradeB}\t\t{course2Credit}\n"
                + $"{course3Name}\t\t{gradeB}\t\t{course3Credit}\n"
                + $"{course4Name}\t{gradeB}\t\t{course4Credit}\n"
                + $"{course5Name}\t\t{gradeA}\t\t{course5Credit}\n"
                + $"Final GPA: \t\t{gpa.ToString("F2")}"
        );
    }

    public static void GenerateRandomNumber()
    {
        Random number = new();
        Console.WriteLine("Generating Random numbers....");
        for (int i = 1; i < 11; i++)
        {
            int randomNumber = number.Next(1000, 2000);
            Console.WriteLine($"The random number({i})\t " + randomNumber);
            if (randomNumber < 1200 && randomNumber.ToString().Contains("1"))
            {
                Console.WriteLine("Win !");
            }
            else
                Console.WriteLine("Lose !");
        }
    }

    public static void CompareLargerNumber()
    {
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine($"The larger between {firstValue} and {secondValue} is: {largerValue}");
    }

    public static void SumMethod()
    {
        int A = 5;
        int B = 40;
        int sum = A + B;
        Console.WriteLine("The sum of numbers is: " + sum);
    }

    public static void ShowTime()
    {
        DateTime date = DateTime.Now;
        CultureInfo arabic = new("ar-SA");
        arabic.DateTimeFormat.Calendar = new HijriCalendar();

        Console.WriteLine(
            $"Universal format: {date.ToString("U", CultureInfo.InvariantCulture)}\nHijri format: {date.ToString(arabic)}"
        );
    }
}