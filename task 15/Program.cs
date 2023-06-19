/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
6 -> yes
7 -> yes
1 -> no */

System.Console.WriteLine("Enter number");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA ==6 || numberA  ==7)
{
    System.Console.WriteLine("Yes");
}
else if (numberA >0 && numberA <=5)
{
    System.Console.WriteLine("No");
}