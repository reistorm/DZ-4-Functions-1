// Напишите программу, которая задаёт массив 
// целых чисел и выводит их на экран.
// Размер массива определяется пользователем.

int[] initArray ()
{
    Console.WriteLine("Введите число элементов массива: ");
    
    int N = int.Parse(Console.ReadLine());
    int [] arr = new int[N];
    var rnd = new Random();
    Console.Write("Массив:   ");
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    { 
       arr[i] = rnd.Next(0, 100);
       Console.Write(arr[i] + ", ");
       
    } 
    int Length = arr.Length;
    arr[arr.Length - 1] = rnd.Next(0, 100);
    Console.Write(arr[arr.Length - 1]);
    Console.Write("] ");
    Console.WriteLine();
    return arr;
}
int [] result = initArray();


