/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Enter number 1");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99 && numberA < 1000)
{
    int numberB = ((numberA % 100)/10);
    Console.WriteLine(numberB);
}
else
{
    Console.WriteLine("Enter correction numbers");
}
