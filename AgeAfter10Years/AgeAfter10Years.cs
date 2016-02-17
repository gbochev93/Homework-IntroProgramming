using System;

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        Console.WriteLine("Въведете рождена дата (YYYY-MM-DD): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        DateTime dateToday = DateTime.Now;
        int age = dateToday.Year - dateOfBirth.Year;
        int ageAfter10 = age + 10; 
        Console.WriteLine("Now: {0}",age);
        Console.WriteLine("After 10 years: {0}",ageAfter10 );
    }
}
