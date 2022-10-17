// На вход: два числа 
// На выход: max, min

Console.WriteLine("Enter two different numbers: ");
int firstnum = Convert.ToInt32(Console.ReadLine());
int secondnum = Convert.ToInt32(Console.ReadLine());

// if (firstnum > secondnum)
// {
//     Console.WriteLine($"Max = {firstnum}, min = {secondnum}");
// } 
// else(firstnum <= secondnum)
// {
//     Console.WriteLine($"Max = {secondnum}, min = {firstnum}");
// }

int max = 0;
int min = 0;

if (firstnum > secondnum) 
{
    max = firstnum; 
    min = secondnum;
}
if (firstnum <= secondnum) 
{
    max = secondnum; 
    min = firstnum;
}

Console.WriteLine("Max = " + max + ", min = " + min);