Console.WriteLine("Программа котрая выводит массив из 8 элементов, элементы массива вводятся в ручную");

int [] arr = new int [8];

for (int i = 0; i<arr.Length; i++)
{
    Console.WriteLine($"Введите элемент массива номер {i}");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
   Console.WriteLine (string.Join (", ", arr));
