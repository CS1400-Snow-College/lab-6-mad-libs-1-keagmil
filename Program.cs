//Keagan Miller 6/24/2026 Lab 6: Lab 6 MadLibs 
String intro = "Welcome to MadLibs with MasterMiller!";

foreach (char c in intro) //Does the complier implicitly convert the string to char? 
{
    Console.Write(c);
    
    Thread.Sleep(35); // speed (milliseconds) "I got this from the internet! It will feel more like a game!"
}
Console.WriteLine();

//What do you call this? We just made a type/method. Very cool!
static void TypeText(string text, int speed = 35)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(speed);
    }
    Console.WriteLine();
}

TypeText("You will provide specific word types and I will make a funny story using them!", 35);
TypeText("Press space to continue", 35);
Console.ReadKey();
Console.Clear();

