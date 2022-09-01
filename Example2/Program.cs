Console.WriteLine("Input number 1: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Input number 3: ");
int C = int.Parse(Console.ReadLine());

int max = A;

if (A > max)
{
    max = A;
}
else if (B > max)
{
    max = B;
}
else if (C > max)
{
    max = C;
}
Console.WriteLine(max);