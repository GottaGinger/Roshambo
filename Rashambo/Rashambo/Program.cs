
using Rashambo;
using System.Runtime.Serialization;
using System.Transactions;

HumanPlayer player = new HumanPlayer();
RockPlayer rockPlayer = new RockPlayer();
RandomPlayer randomPlayer = new RandomPlayer(); 


Console.WriteLine("What is your name?");
player.Name = Console.ReadLine();

Console.WriteLine($"Who do you want to play against, {player.Name}  Rock or Random?");
string input = Console.ReadLine();
RashamboEnum computerChoice;
RashamboEnum playerChoice;

do
{
    if (input.ToLower() == "rock")
    {
        computerChoice = rockPlayer.GenerateRoshambo();
    }
    else
    {
        computerChoice = randomPlayer.GenerateRoshambo();
    }
    playerChoice = player.GenerateRoshambo();
    Console.WriteLine(playerChoice.ToString());
} while (Play((int)playerChoice,(int)computerChoice));

static bool Play(int playerChoice, int computerChoice)
{
    if (playerChoice == 1 && computerChoice == 3)
    {
        Console.WriteLine("You win!");
    }
    else if (playerChoice == 2 && computerChoice == 1)
    {
        Console.WriteLine("You win!");
    }
    else if (playerChoice == 3 && computerChoice == 2)
    {
        Console.WriteLine("You win!");
    }
    else if (playerChoice == 1 && computerChoice == 2)
    {
        Console.WriteLine("You lose!");
    }
    else if (playerChoice == 2 && computerChoice == 3)
    {
        Console.WriteLine("You lose!");
    }
    else if (playerChoice == 3 && computerChoice == 1)
    {
        Console.WriteLine("You lose!");
    }
    else
    {
        Console.WriteLine("Its a tie!");
        return true;
    }
    return false;
}