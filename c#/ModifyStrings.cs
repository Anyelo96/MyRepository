/*string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition+1, length-1));
*/

/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
*/

/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

/*
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/
/*

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";


string quantity = "";
string output = "";
*/
// Your work here

/*
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/

/*
int delet1 = input.IndexOf("<div>");
output = input.Remove(delet1,"<div>".Length);

delet1 = output.IndexOf("</div>");
output = output.Remove(delet1,"</div>".Length);

output = output.Replace("&trade","&reg");

int lookFor1 = input.IndexOf("<span>");
int lookFor2 = input.IndexOf("</span>")-"</span>".Length;
int lookTotal = lookFor2-lookFor1;
Console.WriteLine($"{lookTotal} {lookFor1} {lookFor2}");

quantity = output.Substring(lookFor1-1,lookTotal+1);

Console.WriteLine(quantity);
Console.WriteLine(output);

*/

