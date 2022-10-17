// На ввод: число (N)
// На вывод: все четные числа от 1 до (N)

Console.Write("Enter a number: ");

int number = Convert.ToInt32(Console.ReadLine());

for (int N = number; N > 1; N--)
{
    if (N % 2 == 0)
    {
        Console.WriteLine(N);
    }
}