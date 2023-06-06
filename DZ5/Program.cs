//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//345, 897, 568, 234] -> 2

/*Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine());
int[] Arr = new int[length];
FillArrayRandomNumbers(Arr);
Console.WriteLine("Сгененрированный массив: ");
PrintArray(Arr);
int count = 0;
for (int a = 0; a < Arr.Length; a++)
if (Arr[a] % 2 == 0)
count++;
Console.WriteLine($"{count} - чётные числа");
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
void FillArrayRandomNumbers(int[] Arr)
{
    for(int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(100,1000);
    }
}
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine());
int[] numbers = new int[length];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);
int sum = 0;
for (int b = 1; b < numbers.Length; b+=2)
    sum = sum + numbers[b];
    Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.Write("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[length];
FillArrayRandomNumbers(numbers);
Console.Write("Сгенерированный массив: ");
PrintArray(numbers);
double min = Double.MaxValue;
double max = Double.MinValue;

for (int с = 0; с < numbers.Length; с++)
{
    if (numbers[с] > max)
        {
            max = numbers[с];
        }
    if (numbers[с] < min)
        {
            min = numbers[с];
        }
}

Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между данными значениями = {(max - min)}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            //numbers[i] = new Random().Next(100,1000) / 100;
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "; ");
        }
    Console.Write("]");
    Console.WriteLine();
}