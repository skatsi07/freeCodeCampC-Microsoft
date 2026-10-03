Random coin = new Random();
string coinResult = coin.Next(0, 2) == 0 ? "heads" : "tails";
Console.WriteLine(coinResult);