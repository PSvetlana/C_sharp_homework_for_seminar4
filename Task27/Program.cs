/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int SumOfNumbers(int num) //отвечает за подсчет суммы цифр в числе
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sum = SumOfNumbers(userNumber);
Console.Write($"Сумма цифр в числе {userNumber} равна {sum}");
