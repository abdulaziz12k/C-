using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // IncrementDecrement();
        // CalculateGrades();
        // CalculateGPA();
        // GenerateRandomNumber();
        SumMethod();
        // DisplayDate();
        // Sortarrays();
        Joinarrays();
        // RollDice();
        // EvenOdd();
        Console.ReadLine();
    }
    public static void EvenOdd()
    {
        for (var i = 0; i <= 10; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine($"{i} is even");
            else
                Console.WriteLine($"{i} is odd");
        }
        Console.WriteLine("");
    }
    //---------------------ROLLING DICES-------------------//
    public static void RollDice()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random dice = new();
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
        Console.WriteLine("");
    }
    //---------------------JOIN ARRAYS-------------------//
    public static void Joinarrays()
    {
        string value = "The quick brown fox jumps over the lazy dog";
        char[] tochararray = value.ToCharArray();
        Array.Reverse(tochararray);
        //constructs strings from the elements of the array//
        string result = string.Join("", tochararray);
        Console.WriteLine($"the original array:\n{value}");
        Console.WriteLine($"the edited array into char value is as follows\n{result}");

        // string[] index = result.Split(',');
        // foreach (string i in index)
        // {
        //     Console.Write(i);
        // }
        // Console.WriteLine("");
        // string word = "The quick brown fox jumps over the lazy dog";
        // string[] edited = word.Split(' ');
        // Array.Reverse(edited);
        // foreach (var i in edited)
        // {

        //     Console.WriteLine(i);
        // }



    }
    //---------------------ARRAY METHODS-------------------//
    public static void Sortarrays()
    {
        // "foreach" when the index is no concern
        decimal[] aziz = { 1, 3, 6, 4, 5, 2 };

        Array.Reverse(aziz);
        Console.Write("Working...\nReversed:\n");
        foreach (decimal i in aziz)
        {
            Console.Write($"{i},");
        }
        Array.Resize(ref aziz, 8);
        aziz[6] = 55;
        aziz[7] = 66;
        Array.Sort(aziz);
        Console.Write("\nSorted:\n");
        foreach (decimal i in aziz)
        {
            Console.Write($"{i},");
        }

        Console.Write("\nOriginal: ");
        for (int i = 0; i < aziz.Length; i++)
        {
            Console.Write(aziz[i] + " ");
        }
        Array.Clear(aziz, 0, 4);
        for (int i = 0; i < aziz.Length; i++)
        {
            if (aziz[i] == 0)
            { Console.WriteLine($"Clearing indexe...{i}"); }

        }
        Console.WriteLine("Array after clearing");
        foreach (decimal i in aziz)
        {
            if (i != 0)
            {

                Console.WriteLine($"{i}");
            }

        }

        Console.WriteLine($"\nThe array has {aziz.Length} indexes");
        Console.WriteLine("");

    }
    public static void IncrementDecrement()
    {
        int value = 10;

        value++;
        Console.WriteLine("First increment: " + value);

        value++;
        Console.WriteLine("Second increment: " + value);

        value -= 5;
        Console.WriteLine("Third decrement: " + value);
        Console.WriteLine("");
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
        Console.WriteLine("");
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
        double calc1 = course1Credit * gradeA;
        double calc2 = course2Credit * gradeB;
        double calc3 = course3Credit * gradeB;
        double calc4 = course4Credit * gradeB;
        double calc5 = course5Credit * gradeA;

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
        Console.WriteLine("");
    }

    public static void GenerateRandomNumber()
    {
        Random number = new();
        Console.WriteLine("Generating Random numbers....");
        for (int i = 1; i < 6; i++)
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
        Console.WriteLine("");
    }
    public static void CompareLargerNumber()
    {
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine($"the larger between {firstValue} and {secondValue} is: {largerValue}");
        Console.WriteLine("");
    }

    public static void SumMethod()
    {
        int A = 5;
        int B = 40;
        int sum = A + B;
        Console.WriteLine($"the sum of {A} + {B} = {sum}");
        Console.WriteLine("");
        decimal price = 67.55m;
        decimal salePrice = 59.99m;

        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

        yourDiscount += $"A discount of {(price - salePrice) / price:P2}!"; //inserted
        Console.WriteLine(yourDiscount);
    }

    public static void DisplayDate()
    {
        Console.WriteLine("");
        DateTime date = DateTime.Now;
        CultureInfo arabic = new("ar-SA");
        arabic.DateTimeFormat.Calendar = new HijriCalendar();

        Console.WriteLine(
            $"Universal format: {date.ToString("U", CultureInfo.InvariantCulture)}\nHijri format: {date.ToString(arabic)}"
        );
        Console.WriteLine("");
    }

}