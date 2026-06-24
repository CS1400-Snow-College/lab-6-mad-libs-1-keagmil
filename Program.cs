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

string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";
string[] storyWords = originalStory.Split(' ');
 
storyWords.Contains("(");
Console.Write(storyWords);
