// Методы:

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите новый элемент массива: ");
        string? A = Console.ReadLine();
        array[i] = A;
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine($"Массив из строк, длина которых менее или равна 3 символам: ");
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

// Ввод первоначального массива с клавиатуры

Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[N];
FillArray(array1);

// Первоначальный массив задан заранее

//string[] array1 = { "Hello", "2", "world", ":-)" };
//string[] array1 = { "1234", "1567", "-2", "computer science" };
//string[] array1 = { "Russia", "Denmark", "Kazan" };

// Вычисление длины нового массива

int NewArrayLength = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        NewArrayLength++;
    }
}

// Формирование нового массива и вывод его на печать
// либо сообщение об отсутствии данных для формирования нового массива

if (NewArrayLength > 0)
{
    string[] NewArray = new string[NewArrayLength];

    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            NewArray[index] = array1[i];
            index++;
        }
    }
    Console.WriteLine();
    PrintArray(NewArray);
}
else
{
    Console.WriteLine();
    Console.Write("Все введенные строки имеют длину более 3 символов");
}
