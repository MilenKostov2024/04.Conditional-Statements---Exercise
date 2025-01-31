// Вход
int number = int.Parse(Console.ReadLine());
double bonus = 0;

// Основни бонус точки
if (number <= 100)
{
    bonus = 5;
}
else if (number <= 1000)
{
    bonus = number * 0.2;
}
else
{
    bonus = number * 0.1;
}

// Допълнителни бонуси
if (number % 2 == 0)  // Четно число
{
    bonus += 1;
}
if (number % 10 == 5)  // Число, завършващо на 5
{
    bonus += 2;
}

// Изход
Console.WriteLine(bonus);
Console.WriteLine(number + bonus);