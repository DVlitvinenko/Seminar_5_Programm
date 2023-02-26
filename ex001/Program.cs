// Задача 1: 
// Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// 1. Создание массива

        int[] CreateArray(int size)
        {
            int[] array = new int[size];
            return array;
        }

// 2. Заполнение массива
//   2.1 Случайно
void Fill(int[] array)
{
  for(int i =0; i < array.Length;i++)
  {
    array[i] = new Random().Next(-9, 9);
  }
}


//   <!-- int[] Fill(int[] array) -->

//   2.2 Руками
//   2.3 Из файла

// 3. Найти сумму положительных элементов массива
int FindSumPositiveElementsIn(int[] array)
{
  int summ = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if (array[i]>0)
    {
      summ = summ + array[i];
    }
  }
  return summ;
}

// 4. Найти сумму отрицательных элементов массива
int FindSumNegativeElementsIn(int[] array)
{
  int summ = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if (array[i]<0)
    {
      summ = summ + array[i];
    }
  }
  return summ;
}


// 5. Печать
//   5.1 В терминал
//   void Print(int[] array)
void Print1(int[] array)
{
int length = array.Length;
int index = 0;
while (index < length)
{
Console.Write(array[index] + " ");
index++;
}
System.Console.WriteLine();
}
//   string ArrayToString(int[] array)
//   5.2 в файл

// 6. Считывание руками числа
//    int GetNumberByUser(string text) 
int GetNumberByUser(string msg)
{
  Console.WriteLine(msg);
  // вводим строку
  string? input = Console.ReadLine();
  // Проверяем введено ли число
  bool result = int.TryParse(input, out int number);

  if (result)
  {
    return number;
  }
  else
  {
    Console.WriteLine("Введено не число :");
    return -1;
  }
}


void ex01()
{
  int []array = CreateArray(GetNumberByUser("Введите размер массива: "));
  Print1(array);
  Fill(array);
  Print1(array);
  Console.WriteLine();
  Console.Write("Сумма положительных: " +  FindSumPositiveElementsIn(array));
  Console.WriteLine();
  Console.Write("Сумма отрицательных: " + FindSumNegativeElementsIn(array));
}
ex01();