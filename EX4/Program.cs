// На вход: три числа
// На выход: max

Console.WriteLine("Enter three different numbers: ");

int firstnum = Convert.ToInt32(Console.ReadLine());
int secondnum = Convert.ToInt32(Console.ReadLine());
int thirdnum = Convert.ToInt32(Console.ReadLine());

int max = firstnum;

if (max < secondnum) max = secondnum;
if (max < thirdnum) max = thirdnum;

Console.WriteLine($"Max = {max}");