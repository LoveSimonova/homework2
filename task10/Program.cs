// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int second=(number/10)%10;
Console.WriteLine("Вторая цифра - "+second);