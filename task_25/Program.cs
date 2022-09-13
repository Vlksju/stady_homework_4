Console.WriteLine("Программа котрая принимает число A и B и возводит A в натуральную степень B");
Console.WriteLine("Введите A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Результат = "); 
int Sum = 1;

while (B!= 0) {
        Sum = Sum * A;
        B--;
    }

Console.Write(Sum);
