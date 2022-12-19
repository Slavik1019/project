Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNum(num);
Console.WriteLine("задан массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
        {
            max = num[z];
        }
    if (num[z] < min)
        {
            min = num[z];
        }
}

Console.WriteLine($"Макс. значение = {max}, мин. значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNum(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}