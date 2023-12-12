/*
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string corporateDomain = "contoso.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    CreateEmail(corporate[i,0],corporate[i,1],corporateDomain);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    CreateEmail(external[i,0],external[i,1],externalDomain);
    // display external email addresses
}



void CreateEmail(string names, string apellido, string nivelSocio)
{
    string name = names.Remove(2);
    Console.WriteLine($"{name}{apellido}@{nivelSocio}");
}
*/
