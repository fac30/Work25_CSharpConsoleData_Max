string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramWords = pangram.Split(" ");

for (int i = 0; i < pangramWords.Length; i++)
{
    char[] charArray = pangramWords[i].ToCharArray();
    Array.Reverse(charArray);
    string reversedWord = String.Join("", charArray);

    pangramWords[i] = reversedWord;
}

string result = String.Join(" ", pangramWords);
Console.WriteLine(result);