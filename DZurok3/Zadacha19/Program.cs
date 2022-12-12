Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine() ?? "";
int num = number.Length;

if (num == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
   {
Console.WriteLine($"число: {number} - является палиндромом");    
   }
else
   {
Console.WriteLine($"число: {number} - не является палиндром");
   }
}
else
{
    Console.WriteLine($"Ошибка: число {number} - не являетя пятизначным");
}
        
   