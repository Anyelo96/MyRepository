/*int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);*/

 //widening conversion: attempting to convert a value from 
 //a data type that could hold less information to a data 
 //type that can hold more information
//narrowing conversion:

//cast: (int)variableNombre
/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
*/
/*string str = myDecimal.ToString();//int to string --> its not ncesary
Console.WriteLine(str);*/


/*//string to int
string first = "5";
string second = "g";
int number1=0;
int number2=1;
bool sum1 = int.TryParse(first, out number1);
bool sum2 = int.TryParse(second, out number2);
int sum = number1 + number2;

Console.WriteLine(sum);
*/

/* //string to int
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);*/

//Exercice 1
/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
bool pass= false;
float result = 0;
float resulInt= 0;
string resultStr = "";

foreach(string i in values)
{
pass = float.TryParse(i,out result);
if(pass)   
    resulInt+=result;
    

else
    resultStr+=i;     
}

Console.WriteLine(resulInt);
Console.WriteLine(resultStr);
*/

//Excercice 2
/*
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32((decimal)value1/value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2/(decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3/value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/