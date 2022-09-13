Console.WriteLine("Программа которая принимает на вход число и выдает сумму цифр в нем");
Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine ());

int i = 0;

while (N > 0) {
        i = N % 10 + i;
        N = N / 10;
    }
Console.WriteLine ("Сумма цифр в числе");
Console.WriteLine (i);


