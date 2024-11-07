string pangram = "The quick brown fox jumps over the lazy dog";

char[] pangramArray = pangram.ToCharArray();
Array.Reverse(pangramArray);

string result = String.Join("", pangramArray);
Console.WriteLine(result);