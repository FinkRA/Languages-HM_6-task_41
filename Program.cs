// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа, отделяя их зяпятой с пробелом, десятичные дроби записывайте через '.': ");
string str = Console.ReadLine();
string[] lst1 = str.Split(',');

int count = lst1.Length;
double[] lst2 = new double[count];
for (int j = 0; j < count; j++)
{
    lst2[j] = Convert.ToDouble(lst1[j]);
}

int counting = 0;
for (int i = 0; i < count; i++)
{
    if (lst2[i] > 0)
    {
        counting = counting + 1;
    }
}
Console.WriteLine($"Вы ввели {counting} чисел больше 0.");