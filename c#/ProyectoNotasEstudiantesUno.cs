using System;
/*
// initialize variables - graded assignments 
int currentAssignments = 5;

string[] studentsName = {"Sophia","Andrew","Emma","Logan"};

int[] sophiaNotes = {90,86,87,98,100};

int[] andrewNotes = {92,89,81,96,90};

int[] emmaNotes = {90,85,87,98,68};

int[] loganNotes = {90,95,87,88,96};

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;
int count = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

foreach(string student in studentsName)
{
    int asigCounter = 0;
    if(student == studentsName[0])
    {
        foreach(int points in sophiaNotes)
        {   
            asigCounter+=1;
            if(asigCounter<=currentAssignments)
                sophiaSum += points;
            else
                sophiaSum += points/10;
            
        }
    }

    else if(student == studentsName[1])
    {
        foreach(int points in andrewNotes)
        {
            asigCounter+=1;
            if(asigCounter<=currentAssignments)
                andrewSum+=points;
            else
                andrewSum += points/10;
        }
    }


    else if(student == studentsName[2])
    {
        foreach(int points in emmaNotes)
        {
            asigCounter+=1;
            if(asigCounter<=currentAssignments)
                emmaSum+=points;
            else
                emmaSum += points/10;
        }
    }

    else if(student == studentsName[3])
    {
        foreach(int points in loganNotes)
        {
            asigCounter+=1;
            if(asigCounter<=currentAssignments)
                loganSum+=points;
            else
               loganSum += points/10;
        }
    }

    else
        Console.WriteLine($"{student} is not an student");
    
}

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

decimal[] studentsScoreArray = {sophiaScore,andrewScore,emmaScore,loganScore};
string[] letterNote = new string[studentsName.Length];

foreach(decimal numberScore in studentsScoreArray)
{
    if(numberScore >= 97)
        letterNote[count] = "A+";

    else if(numberScore >= 93)
        letterNote[count] = "A";

    else if(numberScore >= 90)
        letterNote[count] = "A-";

    else if(numberScore >= 87)
        letterNote[count] = "B+";

    else if(numberScore >= 83)
        letterNote[count] = "B";

    else if(numberScore >= 80)
        letterNote[count] = "B-";

    else if(numberScore >= 77)
        letterNote[count] = "C+";

    else if(numberScore >= 73)
        letterNote[count] = "C";

    else if(numberScore >= 70)
        letterNote[count] = "C-";

    else if(numberScore >= 67)
        letterNote[count] = "D+";

    else if(numberScore >= 63)
        letterNote[count] = "D";

    else if(numberScore >= 60)
        letterNote[count] = "D-";

    else if(numberScore >= 0)
        letterNote[count] = "F";

    count+=1;
}

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"{studentsName[0]}:\t\t{sophiaScore}\t{letterNote[0]}");
Console.WriteLine($"{studentsName[1]}:\t\t{andrewScore}\t{letterNote[1]}");
Console.WriteLine($"{studentsName[2]}:\t\t{emmaScore}\t{letterNote[2]}");
Console.WriteLine($"{studentsName[3]}:\t\t{loganScore}\t{letterNote[3]}");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


*/