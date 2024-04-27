using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade_percentage = Convert.ToInt32(Console.ReadLine());

        char letter;
        string sign = "";

        if (grade_percentage >= 90)
        {
            letter = 'A';
        }
        else if (grade_percentage >= 80)
        {
            letter = 'B';
        }
        else if (grade_percentage >= 70)
        {
            letter = 'C';
        }
        else if (grade_percentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        // Determine the sign for the grade (S challenge)
        if (grade_percentage % 10 >= 7 && letter != 'A' && letter != 'F')
        {
            sign = "+";
        }
        else if (grade_percentage % 10 < 3 && letter != 'F')
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}