// Create an instance of the Random class

// first
Random random = new Random();
int coinFlip = random.Next(11);
Console.WriteLine($"Result: {(coinFlip <= 5 ? "Heads" : "Tails")}");

// second
Random coin = new Random();
int flip = coin.Next(2);
Console.WriteLine(flip == 0 ? "heads" : "tails");

// therd
Random flipCoin = new Random();
Console.WriteLine(flipCoin.Next(0, 2) == 0 ? "heads" : "tails");
