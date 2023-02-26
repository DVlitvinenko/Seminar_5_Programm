using System.Text;
using static Metods;
public class ex002_prog
{
public static void ex002()
{
//создадим массив
int [] array = CreateArray(Input("Введите размер массива: "));
//заполняем случайно
FillArray(array);
ArrayToFile("File1_Ex002.txt", array);
//поиск и замена одинаковых+-
FindNumberInArrayAndReplase(array);
//запись в файл (для теста метода записи)
ArrayToFile("File2_Ex002.txt", array);
}
}