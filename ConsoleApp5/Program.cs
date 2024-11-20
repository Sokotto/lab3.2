Console.Write("Введите вещественное число A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите целое число N (<0): ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 0)
{
    Console.WriteLine(" Ошибка: N должно быть меньше 0.");
    return;
}
double result = CalculatePower(A, N);
Console.WriteLine($"Результат A^{N}={result}");
static double CalculatePower(double A, int N)
{
    int positiveN = -N;
    double power = 1.0;
    for (int i = 0; i < positiveN; i++)
    {
        power *= A;
    }
    return 1.0 / power;
}
