
//Creating guess game

//declaring and initialiszing variables
string secrectWord = "kahakmed";
string guess = "";
int userGuessCount = 0;
int userGuessLimit = 3;
bool isOutOfGuess = false;

while(guess != secrectWord && !isOutOfGuess)
{
    if (userGuessCount < userGuessLimit)
    {
        Console.WriteLine("Please enter a guess word: ");
        guess = Console.ReadLine();
        userGuessCount++;
    }
    else 
    { 
        isOutOfGuess = true;
    }
}
if (isOutOfGuess)
{
    Console.WriteLine("You lose!");
}
else
{
    Console.WriteLine("You Win");

}



