// Напишите метод, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Задачу решить без использования Math.Pow.

int Method1(int result)
{
    Console.WriteLine("Введите число А: ");
    int numA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int numB = int.Parse(Console.ReadLine());

    result = 1;
    for (int i = 0; i < numB; i++)
    {
        result = result * numA;
    
    }
    Console.Write("Результат: ");
    Console.WriteLine(result);
    return result;

}

int result = Method1(result: 1);
