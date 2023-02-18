// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int rec (int m, int n)
{
  if (m == 0)
  {
    return n+1;
  }
  if (m > 0 && n == 0)
  {
    return rec (m - 1, 1);
  }
  return rec (m - 1, rec (m, n - 1));
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("A (m,n) = ");
Console.Write(rec (m,n));
