// На ввод: число
// На вывод: является ли число четным (да/нет)

Console.Write("Enter a number: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{number} - is even");
    Console.ResetColor();
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{number} - isn`t even");
    Console.ResetColor();
}