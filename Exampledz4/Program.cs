Console.WriteLine("Введите первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int Num3 = Convert.ToInt32(Console.ReadLine());
int max;

if (Num1 >= Num2)
 {
    if (Num3 >= Num1)
    {
       Console.WriteLine("Максимальное число: " + Num3);
    }
    else
    {
       Console.WriteLine("Максимальное число: " + Num1);
    }
 }
 else
 {
    if (Num3 >= Num2)
    {
       Console.WriteLine("Максимальное число: " + Num3);
    }
    else
    {
       Console.WriteLine("Максимальное число: " + Num2);
    }
 }

    
 