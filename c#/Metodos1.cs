/*Method for a random number*/
/*
DisplayRandomNumber();


void DisplayRandomNumber()
{
    Random dice = new Random();

    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(dice.Next(1,100));
    }

}*/
/*Exercise-->Check if the IP is correct*/
/*
bool exit = true;
while(exit)
{
    string? inputIP;
    Console.WriteLine("Input IP:");
    inputIP = Console.ReadLine();
    

    string[] ipArray =inputIP.Split(".");

    if (ipArray.Length != 4)
    {
        Console.WriteLine("IP equivocada. Only 4 numbers.");
    }

    else
    {
        foreach(string data in ipArray)
        {
            if(StringToArray(data))
            {
                if(NumberVerifycation(data))
                {
                    exit=false;
                }
                else
                {   
                    exit = true;
                    break;
                }
            }
            else
            {   
                exit = true;
                break;
            }

        }
    }  
    if(!exit)
        Console.WriteLine($"IP correcta { inputIP}");


}


bool StringToArray(string palabra){

    char[] palabraArray = palabra.ToCharArray();
    if(palabraArray[0] != '0')
        return true;
    else
    {
        Console.WriteLine($"IP equivocada. Star with 0. {palabra}");    
        return false;
    }
}

bool NumberVerifycation(string palabra)
{
    bool result = false;
    int intResultado = 0;
    result = int.TryParse(palabra, out intResultado);
    
    if(result)
    {
        if((intResultado>=0)&&(intResultado<=255))
        {
            return true;
        }
        else
        {
            Console.WriteLine($"Solo numeros de 0 a 255 -->{palabra}");
            return false;
        }
    }
    else
    {
        Console.WriteLine($"Solo numeros y . -->{palabra}");
        return false;
    }
    
}
*/