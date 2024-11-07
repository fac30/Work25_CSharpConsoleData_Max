string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(",");
Array.Sort(orders);

string[] tag = new string[orders.Length];

for (int i = 0; i < orders.Length; i++)
{
    string order = orders[i];
    Console.Write(order);
    Console.WriteLine(order.Length == 4 ? "" : $"\t - Error");
}