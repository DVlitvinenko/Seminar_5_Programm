using System.Text;
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}

// 2. Заполнение массива рандомно

public static void FillArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
    NameArray[index] = Rundom(-10, 11);
    index++;
  }
}


// 3. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}


// 5. Вывод массива

public static void WriteArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}

// Вывод массива в строку stringBuilder

public static void WriteArrayInStringBuilder (int []NameArray)
{
    StringBuilder text = new();
    int index = 0;
    while (index < NameArray.Length)
    {
      text.Append(NameArray[index] + " ");
      index++;
    }
  System.Console.WriteLine(text);
}

// запись массива в файл

public static void ArrayToFile(string fileName, int []NameArray)
{
  StringBuilder text = new();
  for(int i = 0; i < NameArray.Length; i++)
  {
    text.Append(NameArray[i] + " ");
  }
  File.WriteAllText(fileName, text.ToString());
  Console.WriteLine("Запись в файл" + fileName + "успешно завершена.");
}

//поиск и замена одинаковых+-

public static void FindNumberInArrayAndReplase(int [] array)
{
  int temp = 0;
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = 0; j < array.Length; j++)
    {
      if (array[j] == -array[i])
      {
        temp = array[j];
        array[j] = array[i];
        array[i] = temp;
      }
    }
  }

}
// 3.2 ввод данных рандомно

public static int Rundom (int min, int max)
{
  int result = 0;
  result = new Random().Next(min, max);
  return result;
}
}


 

 
