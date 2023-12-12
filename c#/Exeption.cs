/*try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}*/

using System.Security.Cryptography.X509Certificates;
int x=3;
Console.WriteLine(10%3);
int[] hola = {1,2,3,4};
Console.WriteLine(hola[2]);

try{
int z=3+2;
float c=3/0;
}
catch{
int c=4;
}