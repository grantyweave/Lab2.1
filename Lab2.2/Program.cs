using System;
using System.Security.Cryptography;
EnterName:
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();

EnterNumber:
Console.WriteLine($"{userName}, Enter a number between 1 - 100: ");

int userInput = int.Parse(Console.ReadLine());

if (userInput >= 1 && userInput <= 100)
{
    Console.WriteLine($"{userInput}");
}

else
{
    Console.WriteLine($"{userName}, {userInput} is an invalid input. Please try again.");
    goto EnterNumber;
}

var isEven = userInput % 2 == 0;


if (!isEven && userInput <= 60)
{
    Console.WriteLine("Odd and less than 60.");
}


if (isEven && userInput >= 2 && userInput <= 24)
{
    Console.WriteLine("Even and less than 25.");
}



if (isEven && userInput >= 26 && userInput <= 60)
{
    Console.WriteLine("Even and between 26 and 60.");
}




if (isEven && userInput >= 60)
{
    Console.WriteLine("Even and greater than 60.");
}



if (!isEven && userInput >= 60)
{
    Console.WriteLine("Odd and greater than 60.");
}



//reset
Console.WriteLine($"{userName}, Would you like to restart? Enter 'yes' or 'y' to continue, or enter any other key to exit.");

var input2 = Console.ReadLine();

var lowercaseInput2 = input2.ToLower();

if (lowercaseInput2 == "yes" || lowercaseInput2 == "y")
{
    goto EnterName;
}


Environment.Exit(0);