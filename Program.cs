using System;

Console.Write("First Name > ");
string firstName = Console.ReadLine();
string reverseFirst = string.Empty;
for (int i = firstName.Length - 1; i >= 0; i--)
{
    reverseFirst += firstName[i];
}
Console.WriteLine(reverseFirst);

Console.Write("Last Name> ");
string lastName = Console.ReadLine();
string reverseLast = string.Empty;
for (int i = lastName.Length - 1; i >= 0; i--)
{
    reverseLast += lastName[i];
}
Console.WriteLine(reverseLast);

Console.Write("First Name > ");
string firstNameB = Console.ReadLine();
string reverseFirstB = string.Empty;
foreach (char c in firstNameB)
{
    reverseFirstB = c + reverseFirstB;
}
Console.WriteLine(reverseFirstB);

Console.Write("Last Name> ");
string lastNameB = Console.ReadLine();

// string initials = firstName[0] + " " + lastName[0];
// Console.WriteLine(initials);

// for (int num = 10; num >= 1; --num)
// {
//     Console.WriteLine(num);
// }
/*
Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}
*/