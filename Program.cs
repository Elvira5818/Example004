// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int numA = GetNumberFromUserA("Введите целое число А: ", "Ошибка ввода");
int GetNumberFromUserA(string messageA, string errorMessage)
{

    while (true)
    {
        Console.Write(messageA);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);

    }
}
int numB = GetNumberFromUserB("Введите целое число B: ", "Ошибка ввода");
int GetNumberFromUserB(string messageB, string errorMessage)
{

    while (true)
    {
        Console.Write(messageB);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);

    }
}

int result = 1;
for(int i = 1; i <= numB; i++)
{
    result *= numA;
}
Console.WriteLine($"Число {numA} в степени {numB} => {result}");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int num = GetNumberFromUserA("Введите целое число, чтобы узнать сумму его чисел: ", "Ошибка ввода");
int GetNumberFromUserA(string message, string errorMessage)
{

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);

    }
}

int result = CountDidgits(num);
PrintReport(num, result);

int CountDidgits(int chislo)
{
    int count = 0;
    while (chislo > 0)
    {
        int A = chislo % 10;
        count += A;
        chislo /= 10;

    }
    return count;
}
void PrintReport(int num, int result)
{
Console.WriteLine($"Сумма цифр в числе {num} -> {result}");
}

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();

int[] array = new int[8];

        // Просим пользователя ввести элементы массива
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите элемент массива №{0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Выводим массив на экран
        foreach (int result in array)
        {
            Console.Write($"{result}, ->[{result}] ");
        }



