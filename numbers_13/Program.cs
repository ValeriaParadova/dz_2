// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next(1, 100000);

Console.WriteLine(number);


if (number > 99)
{
    string number1 = ("");

    number1 = Convert.ToString(number);
    Console.WriteLine(number1[2]);
}

else

{
    Console.WriteLine("no third digit");
}