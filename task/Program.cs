//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int n = 3;
int size = 6;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов, означающих значение строкового элемента массива, {size} раз через энтер, без пробелов");
//FillArray(arrayOne);
FillArrayRandomly(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы, размер которых меньше либо равен {n}:");
if (GetSecondSizeArray(arrayOne) == 0){Console.WriteLine("Искомых элементов строкового массива для переноса в новый массив нет");}
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}

void FillArrayRandomly(string[] arr)
{
    Random rand = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,7);
        for (int g = 0; g < randElemSize; g++)
        {
            arr[i] += AllSymbols[rand.Next(0,AllSymbols.Length)];
        }
    }
}

void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    } 
}

void PrintArray(string[] arr)
{
    int arrLeng = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    } 
    Console.Write("]");
}

int GetSecondSizeArray(String[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[GetSecondSizeArray(arrayOne)];
    for (int i = 0, g = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[g] = arr[i];
            g++;
        }
    }
    return arrayTwo;
}