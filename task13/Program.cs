// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99)
{
    int first=(number/100);
    while (first>9)
    {
        number=number/10;
        first=(number/100);
    }
    int third = number%10;
    Console.WriteLine("Третья цифра - "+third);
}
else
    Console.WriteLine("Третьей цифры нет");