/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

Console.WriteLine ("Введите числа через пробел:");
string numbers = Console.ReadLine();
string [] inputNumbers = new string [numbers.Length];
int k = 0;

for (int i = 0; i < inputNumbers.Length; i++)
{
  if (numbers[i] == ' ')
  {
    k++;
  }
  else
  {
    inputNumbers[k] = inputNumbers[k]+$"{numbers[i]}";
  }
}
k++;

int [] outputNumbers = new int[k];
PrintArray (outputNumbers, inputNumbers);
int sum = 0;
for (int i = 0; i < k; i++)
{
  if (outputNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ($"Количество чисел больше 0: {sum}");

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  }
}