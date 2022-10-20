// Домашнее задание 36

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-50, 50);
}

int CountEventNumbers(int[] array)
{
int sum = 0;
for (int i = 1; i < array.Length; i+=2) 
sum = sum + array[i];
return sum;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {CountEventNumbers(array)}");