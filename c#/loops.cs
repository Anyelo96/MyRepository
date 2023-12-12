/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/

/*
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/
/*
for(int number = 1;number<=100;number++)
{
    if ((number%3 == 0)&&(number%5 == 0))
        Console.WriteLine($"{number} - FizzBuzz");

    else if(number%3 == 0)
        Console.WriteLine($"{number} - Fizz");

    else if(number%5 == 0)
        Console.WriteLine($"{number} - Buzz");
    else
        Console.WriteLine($"{number}");
}*/

/*
int hpHero = 10;
int hpMonster = 10;
var attack = new Random();
int damage = 0;

Console.WriteLine($"HeroHP = {hpHero}\t\t\tMonsterHP = {hpHero}");

do{
damage = attack.Next(1,11);
hpMonster -= damage;
Console.WriteLine($"Hero hit the Mosetr for {damage} damage.");
Console.WriteLine($"HeroHP = {hpHero}\t\t\tMonsterHP = {hpMonster}");
if(hpMonster <= 0)
    continue;
damage = attack.Next(1,11);
hpHero -= damage;
Console.WriteLine($"Monster hit the Hero for {damage} damage.");
Console.WriteLine($"HeroHP = {hpHero}\t\t\tMonsterHP = {hpMonster}");

}while((hpHero>=0)&&(hpMonster>=0));


Console.WriteLine(hpHero > hpMonster ? "Hero wins!" : "Monster wins!");
*/