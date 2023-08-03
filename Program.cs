using System;

class Program
{
  static void Main(string[] args)
  {
    string[] inputArray = { "short", "cut", "cat", "dog", "long" };

    string[] resultArray = FilterArray(inputArray);

    Console.WriteLine("Результат:");
    foreach (string str in resultArray)
    {
      Console.WriteLine(str);
    }
  }

  static string[] FilterArray(string[] inputArray)
  {
    int resultSize = 0;

    // Считаем количество строк, длина которых <= 3
    foreach (string str in inputArray)
    {
      if (str.Length <= 3)
      {
        resultSize++;
      }
    }

    string[] resultArray = new string[resultSize];
    int index = 0;

    // Заполняем новый массив элементами, длина которых <= 3
    foreach (string str in inputArray)
    {
      if (str.Length <= 3)
      {
        resultArray[index] = str;
        index++;
      }
    }

    return resultArray;
  }
}