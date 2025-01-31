// Вход
double budget = double.Parse(Console.ReadLine());
int videoCardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramCount = int.Parse(Console.ReadLine());

// Ценови калкулации
double videoCardsPrice = videoCardsCount * 250;
double processorPrice = (videoCardsPrice * 0.35) * processorsCount;
double ramPrice = (videoCardsPrice * 0.10) * ramCount;

double totalPrice = videoCardsPrice + processorPrice + ramPrice;

// Отстъпка
if (videoCardsCount > processorsCount)
{
    totalPrice *= 0.85;
}

// Проверка на бюджета
if (budget >= totalPrice)
{
    double moneyLeft = budget - totalPrice;
    Console.WriteLine($"You have {moneyLeft:F2} leva left!");
}
else
{
    double neededMoney = totalPrice - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
}