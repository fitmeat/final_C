void NewString(string[] oldString, string[] newString)
{
    int count = 0;
    for (int i = 0; i < oldString.Length; i++)
    {
            if (oldString[i].Length <= 3)
            {
                newString[count] = oldString[i];
                count++;
            }
    }
    Console.WriteLine($"{string.Join(" ", newString)}");
}


Console.Clear();
Console.WriteLine("Введите размер массива строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения массива строк: ");
string[] str1 = new string[n];
for (int i = 0; i < n; i++)
{
    str1[i] = Console.ReadLine();
}
Console.WriteLine("Начальный массив:");
Console.WriteLine($"{string.Join(" ", str1)}");
string[] str2 = new string[n];
Console.WriteLine("Конечный массив:");
NewString(str1, str2);
