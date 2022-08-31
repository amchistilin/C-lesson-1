
Console.WriteLine("Введите целое число");
int digit = Convert.ToInt32(Console.ReadLine());
try
    {
    int i = - digit;
    while (i<=digit)
            {
                Console.Write (i + ", ");
                i++;
            }
    }
catch 
{
    Console.WriteLine("Надо было вводить именно целое число");
}