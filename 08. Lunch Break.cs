// Входни данни
string seriesName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

// Изчисления
double lunchTime = breakDuration / 8.0;
double relaxTime = breakDuration / 4.0;
double freeTime = breakDuration - (lunchTime + relaxTime);

// Проверка дали времето е достатъчно
if (freeTime >= episodeDuration)
{
    double remainingTime = freeTime - episodeDuration;
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime)} minutes free time.");
}
else
{
    double neededTime = episodeDuration - freeTime;
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(neededTime)} more minutes.");
}