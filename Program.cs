//Ввод трех целых чисел

Console.WriteLine("Введите три целых числа");

string Number = Console.ReadLine() ?? "";
int a = int.Parse(Number);

Number = Console.ReadLine() ?? "";
int b = int.Parse(Number);

Number = Console.ReadLine() ?? "";
int c = int.Parse(Number);

//Нахождение максимального числа

int max = a;
if (b > max) max = b;
if (c > max) max = c;

//Вывод результата

Console.WriteLine($"{a}, {b}, {c} -> {max}");
