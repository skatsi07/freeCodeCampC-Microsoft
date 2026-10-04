string pangram = "The quick brown fox jumps over the lazy dog";
char[] pangramArray = pangram.ToCharArray();
Array.Reverse(pangramArray);
Console.WriteLine(String.Join("", pangramArray));
