Console.WriteLine("Input number 1: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int B = int.Parse(Console.ReadLine());
int C = 0;

if (A > B)
{
    C = A;
}
else
{
    C = B;
}
Console.WriteLine (C);