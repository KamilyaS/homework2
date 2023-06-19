/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679345 -> 6*/

System.Console.WriteLine("Enter number");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99 && numberA <999)
{
    numberA = numberA % 10;
    System.Console.WriteLine(numberA);
}
else if (numberA < 99)
{
    System.Console.WriteLine("Attention! No third digit");
}
while (numberA >1000)
    {
        numberA = numberA / 10;
    }
    numberA = numberA % 10;


