//Лабораторная работа №5
//Строковый тип данных
//Средний уровень, Вариант 2
Console.Write("Введите строку:");
string text = Console.ReadLine();
char[] signs = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
string[] words = text.Split(signs);
int count = words.Length;
Console.WriteLine($" Количество слов: {count}");
