/*
Composite Formatting(("{0}{1},x,y)")
string result = string.Format("{0} {1}!", first, second);
string interpolation($"{x}{y}")
c-->currency
p-->percentage
N-->number
*/
/*
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
*/
/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
*/

/*
Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
Methods that turn a string into an array of strings or characters (Split(), ToCharArray())
*/

//overloaded method--> '-'
/*
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
*/

/*
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/

//excercise
/*
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine(@$"Dear {customerName},
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N2} shares at a return of {currentReturn:P}.

Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C2}");

Console.WriteLine(@$"Here's a quick comparison:

{currentProduct.PadRight(20)}   {currentReturn:P}   {currentProfit:C2}     
{newProduct.PadRight(20)}   {newReturn:P}   {newProfit:C2}");

*/