int number = ReadInt("Введите трехзначное число: ");
int count = number.ToString().Length;
if (count < 3 || count > 3)
{
 Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
 Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
    
 int result = ((a / 10) % 10);
 return result;
}
