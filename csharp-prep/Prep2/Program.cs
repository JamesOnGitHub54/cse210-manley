using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent_answer = Console.ReadLine();
        int percentage = int.Parse(percent_answer);

        string letter = "";
        string message = "";
        string sign = "";


        //Letter Check
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine(letter);


        //Pass or Fail check
        if (percentage >= 70)
        {
            message = "Congratulations! You passed the course!";
        }
        else
        {
            message = "Unfortunately, you did not obtain the necessary grade to pass the course. You can do better next time!";
        }


        //Precise grade check
        int remain = percentage % 10;
        if (remain >= 7)
        {
            sign = "+";
        }
        else if (remain < 3)
        {
            sign = "-";
        }


        //Logic check
        if (letter + sign == "A+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is as follows: {letter}{sign}\n{message}");
    }
}