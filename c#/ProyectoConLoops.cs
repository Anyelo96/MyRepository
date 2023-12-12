
/*
string? intUser = "";

bool myLoop = false;
*/
/*
int result = 0;

//int indicado

do
{

Console.Write("Incresa un numero entre 5 y 10: ");
intUser = Console.ReadLine();
myLoop = int.TryParse(intUser, out result);
if((result>=10)||(result<=5))
    myLoop=false;
if(myLoop==false)
    Console.WriteLine("Solo numeros en el rango indicado, intentalo denuevo.");
}while(myLoop == false);

Console.WriteLine($"Tu numero es: {intUser}");
*/

//string indicado


/*
string intUserClean = "";
do
{

Console.Write("Enter your role name (Administrator, Manager, or User): ");
intUser = Console.ReadLine();
intUserClean = intUser.ToLower().Trim();
myLoop = (intUserClean == "administrator")||(intUserClean=="manager")||(intUserClean=="user");
if(myLoop==false)
    Console.WriteLine("Ingresa una identificacion correcta");
}while(myLoop == false);

Console.WriteLine($"Tu roll es: {intUser}");
*/

//tercer ejercicio

/*

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

String[] procesData = new string[4];
string backup = "";
int count = 0;

foreach(string letras in myStrings)
{   
    backup = letras;
    

    for(int i = 0;i<letras.Length;i++)
    {
    int periodlocation = 0;
    periodlocation = backup.IndexOf(".");

    if(periodlocation == -1)
    {
      procesData[count] = backup;
      count++;
      break;  
    }

    procesData[count] = backup.Substring(0,periodlocation);
    backup = backup.Remove(1,periodlocation);
    backup = backup.TrimStart();
   
    count++;
    }
    
}
for(int i=0;i<procesData.Length;i++)
    Console.WriteLine(procesData[i]);
*/