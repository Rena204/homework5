void Array(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 100);
}

int Sum(int[] array) {
    int sum = 0;
    for(int i = 0; i < array.Length; i++) {
        if(i % 2 != 0) {
            sum += array[i];
        }
    }
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Sum(array);
Console.WriteLine($"Результат: {Sum(array)}");
