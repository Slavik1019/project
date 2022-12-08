Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 6)
{
    Console.WriteLine ("не является выходным");
}
if ((num == 6) || (num == 7))
{
    Console.WriteLine("является выходным");
}
if (num > 7)
{
    Console.WriteLine("Введенное число не соотвествует дням недели");
}