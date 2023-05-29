// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number==6||number==7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Рабочий день");