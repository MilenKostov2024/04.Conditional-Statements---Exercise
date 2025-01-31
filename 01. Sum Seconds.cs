//Input
int firstTimePlayer = int.Parse(Console.ReadLine());
int secondTimePlayer = int.Parse(Console.ReadLine());
int thirdTimePlayer = int.Parse(Console.ReadLine());

//Calculation
int timeInSeconds = firstTimePlayer + secondTimePlayer + thirdTimePlayer;
int minutes = timeInSeconds / 60;
int seconds = timeInSeconds % 60;

//Output
if (seconds < 10)
    Console.WriteLine($"{minutes}:0{seconds}");
else
    Console.WriteLine($"{minutes}:{seconds}");