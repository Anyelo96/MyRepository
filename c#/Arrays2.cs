
// Sort()-->  sort the items in the array alphanumerically
/*string[] pallets = { "B14", "A11", "B12", "A13" };


Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Reverse() --> reverse the order of items.

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}*/

//he Array.Clear() method allows you to remove
//the contents of specific elements in your array
//and replace it with the array default value(null)

/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
//Resize() --> Change the Length of the array
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// divide a string(ToCharArray), join an array(Join) to a string
//and divide a string in a secific character (slipt) to an array
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
string result2 = String.Join(",", valueArray);
Console.WriteLine(result2);
string[] items = result2.Split(',');
foreach (string item in items)
{
    Console.Write(item+" ");
}
Console.WriteLine();
*/
//Excercise
/*
string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(" ");
string newString = "";

foreach(string data in pangramArray)
{
char[] supArray = data.ToCharArray();
Array.Reverse(supArray);
string newSupString = new string(supArray);
newString += newSupString+" "; 

}

Console.WriteLine(newString);*/

//Exercise2
/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] newArray = orderStream.Split(",");
foreach(string data in newArray)
{
    if(data.Length!=4)
        Console.WriteLine(data+"\t - Error");
    
    else    
        Console.WriteLine(data);

}
*/
