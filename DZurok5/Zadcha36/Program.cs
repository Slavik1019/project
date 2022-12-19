Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNum(num);
Console.WriteLine("задан массив: ");
PrintArray(num);
int sum = 0;

for (int z = 0; z < num.Length; z+=2)
    sum = sum + num[z];

    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");

void FillArrayRandomNum(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
