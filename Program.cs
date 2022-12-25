Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите значение {i + 1} строки: ");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3)
        count++;
}
string[] result = new string[count];
int j = 0;
int a = 0;
while (j < n)
    if (array[j].Length <= 3)
    {
        result[a] = array[j];
        a++;
        j++;
    }
    else
        j++;
Console.Clear();
Console.WriteLine($"Ваш массив:\n{string.Join(", ", array)}");
Console.WriteLine($"\nЭлементы массива, длина которых меньше, либо равна 3:\n{string.Join(", ", result)}");
