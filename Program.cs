Console.Clear();
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] str1 = new string[n];
for (int i = 0; i < n; i++)
{
    str1[i] = Console.ReadLine();    
}
 Console.WriteLine($"{string.Join(", ", str1)}");
