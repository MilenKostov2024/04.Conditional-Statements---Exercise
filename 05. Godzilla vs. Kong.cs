// Вход
double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double pricePerClothing = double.Parse(Console.ReadLine());

// Изчисления
double decor = budget * 0.1;  // Декорът е 10% от бюджета
double clothingCost = statists * pricePerClothing;

if (statists > 150)
{
    clothingCost *= 0.9; // 10% отстъпка за повече от 150 статисти
}

double totalCost = decor + clothingCost;

// Проверка дали бюджетът стига
if (totalCost > budget)
{
    double neededMoney = totalCost - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
}
else
{
    double moneyLeft = budget - totalCost;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
}