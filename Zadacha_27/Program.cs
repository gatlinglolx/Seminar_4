//Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int N = ReadInt("Enter N");
sum (N);
void sum (int N)
{
    int result = 0;
    while (N > 0)
    {
        result = result + N % 10;
        N /= 10;
    }
    Console.WriteLine(result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
