/* Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void printArray(int[] arrayToPrint) //выводит массив в определенном формате: "[1, 2, ..., n]"
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] createRandomArray(int length) //создает массив из рандомных элементов в диапазоне от [-100; 100]
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(-100, 101);
    }
    return returningArray;
}

Console.Write("Введите число элементов массива: ");
int numberOfItems = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = createRandomArray(numberOfItems);
printArray(arrayRandom);