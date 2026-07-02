//Keagan Miller 6/24/2026 Lab 6: Lab 6 MadLibs 
/*
String intro = "Welcome to MadLibs with MasterMiller!";

foreach (char c in intro) //Does the complier implicitly convert the string to char? 
{
    Console.Write(c);
    
    Thread.Sleep(15); // speed (milliseconds) "I got this from the internet! It will feel more like a game!"
}
Console.WriteLine();

//What do you call this? We just made a type/method. Very cool!
static void TypeText(string text, int speed = 15)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(speed);
    }
    Console.WriteLine();
}

TypeText("You will provide specific word types and I will make a funny story using them!", 15);
TypeText("Press space to continue", 15);
Console.ReadKey();
Console.Clear();
*/

string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";
string[] storyWords = originalStory.Split(' ');

{
    string newStory = ""; //I was getting issues here. By assigning it an empty value we essentiall can buidl the story again word by word and get around it not being assigned a variable.
    string replaceable = "";

    //foreach (string word in storyWords)

    for (int i =0; i < storyWords.Length; i++)
    {
        if (storyWords[i].Contains('('))
        {
            replaceable += storyWords[i] + " "; 
            while (!storyWords[i].Contains(')'))
            {
                i++;
                replaceable += storyWords[i] + " ";
                
            }
          
            replaceable = replaceable.Replace("(", "").Replace(")", "");
            Console.Write($"Give me a(n) {replaceable}");
            replaceable = ""; 
            string userInput = Console.ReadLine();
            newStory += userInput + " ";
            
        }


/*
    if (word.Contains('('))
    {
        //Add word
        //Add following words until ")"

        int start = word.IndexOf('(');
        int end = word.IndexOf(')');
        
        string placeholder = word.Substring(start + 1, end - start - 1); //Gets rid of "()" = -/+ 1
        //"(adjective)" and others now are a variable and replaceable
        Console.WriteLine($"Give me a(n) {placeholder}");
        string userInput = Console.ReadLine();
        string filledWord = word.Replace($"{placeholder}", userInput);
        newStory += filledWord + " ";
    }
    */
    else
    {
        newStory += storyWords[i] + " ";
    }
    }
    Console.Write(newStory);


}
