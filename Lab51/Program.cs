//Лабораторная работа №5
//Строковый тип данных
//Средний уровень, Вариант 2
Console.Write("Введите строку:");
string text = Console.ReadLine();
int count = text.Split(" ").Length;
Console.WriteLine($" Количество слов:{count}");