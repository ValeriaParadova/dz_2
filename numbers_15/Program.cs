// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)

{
    Console.WriteLine("no");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("data entry error");
}
