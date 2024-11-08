const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantitySearch = "<span>";
int quantityStart = input.IndexOf(quantitySearch) + quantitySearch.Length;
int quantityLength = input.IndexOf("</span>") - quantityStart;
string quantity = input.Substring(quantityStart, quantityLength);

string outputSearch = "<div>";
int outputStart = input.IndexOf("<div>") + outputSearch.Length;
int outputLength = input.IndexOf("</div>") - outputStart;
string output = input.Substring(outputStart, outputLength);

output = output.Replace("&trade", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");