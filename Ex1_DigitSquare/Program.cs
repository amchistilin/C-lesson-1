
Console.WriteLine("Введите число ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое является квадратом первого введенного числа ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int square = firstDigit*firstDigit;

if (secondDigit == square)
{
    Console.WriteLine ("Второе число является квадратом первого числа");
}
else Console.WriteLine ("Второе число не является квадратом первого числа");


 
