/*string name = "Maria";
int itemCount = 3;

// Prefix a string literal with $ to interpolate expressions inside braces.
Console.WriteLine($"Hello, {name}! You have {itemCount} items in your cart.");
// => Hello, Maria! You have 3 items in your cart.

decimal subtotal = 23.5m;
decimal taxRate = 0.08m;

Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax rate: {taxRate:P0}");
Console.WriteLine($"Total:    {subtotal * (1 + taxRate):C}");

(string Name, int Quantity, decimal Price)[] orders =
[
    ("Espresso", 2, 3.50m),
    ("Cappuccino", 1, 4.25m),
    ("Tea", 4, 2.00m),
];

foreach (var order in orders)
{
    Console.WriteLine($"{order.Name,-12}{order.Quantity,3}{order.Price * order.Quantity,10:C}");
}

decimal total = 1234.56m;

// An interpolated string uses the current culture by default.
// Use string.Create with a culture to control the formatting explicitly.
string germanReceipt = string.Create(
    new CultureInfo("de-DE"), $"Gesamt: {total:C}");
string invariantLog = string.Create(
    CultureInfo.InvariantCulture, $"total={total:F2}");

Console.WriteLine(germanReceipt);
Console.WriteLine(invariantLog);

List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello, {name.ToUpper()}!");
}

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello, {name.ToUpper()}!");
}*/

List<int> fibonacciNumbers = [1, 1];

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
}

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}