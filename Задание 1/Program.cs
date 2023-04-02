// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string ReadIn(string message)
{
    System.Console.WriteLine($"{message}");
    string input = Console.ReadLine();
    return input;
}

string Check (string number)
{
    
    
    if(number[0] == number[4] && number[1]==number[3])
    {
       return number = "Да";
    }
    else
   return number="нет";
}

bool CorrectNumber(string number)
{
    if (number[4]!= null)
    {
        return true;
    }
    return false;
}

string numb = ReadIn("Введите число");


if (CorrectNumber(numb))
{
    System.Console.WriteLine($"Является ли ваше число палиндромом? {Check(numb)} ");
}