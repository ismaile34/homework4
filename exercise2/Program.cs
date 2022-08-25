// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int summ(int number)
{
    int result = 0;
    int temp = 0;
    for (int i = 0; i <=number; i++)
    {
        temp = number - number%10;
        result = result + (number - temp);
        number = number/10;
    }
    System.Console.WriteLine(result);
    return result;
}

int number = Prompt("Введите число > ");
summ(number);