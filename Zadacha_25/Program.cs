// Напишите цикл, который принимает на вход два числа (A и В) и 
// возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

int A = ReadInt("Enter A");
int B = ReadInt("Enter B");
ToDegree(A, B);
void ToDegree (int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine(result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}