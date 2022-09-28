// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;
using System.Text;

namespace datatype
{ class StringPractise
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int months = 12, bonus = 1000;
            bool isActive = true;
            double rating = 99.25;
            //byte numberOfEmployees = 300; it can store between 0-255
            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;
            double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
            Console.WriteLine(currentMonthWage);
            int a = int.MinValue;
            bool b;
            //Console.WriteLine(a); UserStringHandle of unassigned local variable 'a'
            //Console.WriteLine(b);
            Console.WriteLine(a);
            char myChar = 'a';
            string myName = "Akanksha ";
            bool isWhiteSpace = char.IsWhiteSpace(myChar);
            bool isDigit = char.IsDigit(myChar);
            bool isPunctuation = char.IsPunctuation(myChar);
            Console.WriteLine($"status os charater 'a' is : {isWhiteSpace},{isDigit}, {isPunctuation}");
            DateTime hireDate = new DateTime(2022,9, 28,12, 30, 0);
            Console.WriteLine(hireDate);
            DateTime exitDate = new DateTime(2021, 12, 11);
            DateTime startDate = exitDate.AddDays(15);
            Console.WriteLine(startDate);
            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(3, 6, 0);
            DateTime endHour = startHour.Add(workTime);
            Console.WriteLine(endHour);
            Console.WriteLine(startHour);
            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(endHour.ToShortTimeString());
            string s1 = "Hello World ";
            string s2 = string.Empty;
            var s3 = "I AM A STRING TOO ";
            string s4 = null; 
            Console.WriteLine($"We all are strings: {s1}, {s2},{s3},{s4}");
            int len = s1.Length;
             string upper = s1.ToUpper();
            Console.WriteLine(upper);
            string lower = s3.ToLower();
            Console.WriteLine(lower);
            bool contain = s1.Contains("Hello");
            Console.WriteLine(contain);
            string s = s1.Replace("Hello", "My");
            Console.WriteLine(s);
            string sub = s3.Substring(1, 3);
            Console.WriteLine(sub);
            Console.WriteLine(s1 + s3);
            Console.WriteLine(String.Concat(s1, s3)); 
            int years =7;
            string greetingText = string.Format("Hello {0}, We are friends since {1} years", s1, years);
            Console.WriteLine(greetingText);
            string apps = "is mine";
            string apps1;
            apps1 = apps;
            s += apps1;
            Console.WriteLine(s);
            string name = "Akanksha";
            string lastName = "Shrivastava";
            string anotherName = name;
            name += " Shrivastava";
            Console.WriteLine("anotherName: " + anotherName);
            Console.WriteLine("Name: "+ name);
            string index = string.Empty;
            for(int i=0; i< 25; i++)
            {
                index += i.ToString();
            }
            Console.WriteLine(index);
            StringBuilder builder = new StringBuilder();
            builder.Append("Last name: ");
            builder.Append(name);
            builder.Append("First Name: ");
            builder.Append(lastName);
            string result = builder.ToString();
        Console.WriteLine(result);

            Console.WriteLine("Enter the wage: ");
            string wage = Console.ReadLine();
            int wageValue = int.Parse(wage);
            Console.WriteLine(wageValue);
             
        }
    }
}
