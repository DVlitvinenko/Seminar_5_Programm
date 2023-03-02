
// A=2
// B=9

// A<B, A, B - натуральные числа

// k1 = +1
// k2 = x2

// Найти количество комбинаций "превращения" числа А в число B.

// ** Показать(вывести на экран) один из способов такого "превращения"

// GetWays(2, 9) => 5
// GetWays(2, 11) => 7

using static Metods;
public class ex004
{
  public static void ex004_prog()
  {
    // Ввод А и В с клавиатуры
    int A = Input ("Введите A: ");
    int B = Input ("Введите B: ");
    // Поиск комбинаций
    if (A==B) 
    Console.WriteLine("Числа равны");
    else
  {
    Console.WriteLine((GetWays(A,B)+1));
    // вывод комбинации
    PrintPrevr(A, B);
  }
  }
}