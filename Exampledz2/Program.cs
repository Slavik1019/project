Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine("Первое число большее, Второе число меньшее");
if (a < b) Console.WriteLine("Первое число меньшее, Второе число большее");
if (a == b) Console.WriteLine("Числа равны");