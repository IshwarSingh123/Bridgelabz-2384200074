using System;

class AgeOfHarry //creating a class name AgeOfHarry
{
    static void Main(string[] args)//main function
    {
        // creating the variables which is  the birth year and current year
        int birthYear = 2000;
        int currentYear = 2024;

        // Calculate Harry's age
        int harryAge = currentYear - birthYear;

        // print the age of harry in current
        Console.WriteLine("Harry's age in " + currentYear + " is " + harryAge);
    }
}

/*
D:\c-sharp>AgeOfHarry
Harry's age in 2024 is 24
*/
