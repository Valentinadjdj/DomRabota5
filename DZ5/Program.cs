Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine());
int[] Arr = new int[length];
FillArrayRandomNumbers(Arr);
Console.WriteLine("Сгененрированный массив: ");
PrintArray(Arr);
int count = 0;

for (int z = 0; z < Arr.Length; z++)
if (Arr[z] % 2 == 0)
count++;
Console.WriteLine($"{count} - чётные числа");

void FillArrayRandomNumbers(int[] Arr)
{
    for(int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] Arr)
{
    Console.Write("[ ");
    for(int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
