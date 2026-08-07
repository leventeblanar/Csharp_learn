Console.WriteLine("Rock Paper Scissors");

Random random = new Random();
bool playAgain = true;
String player;
String computer;

while(playAgain)
{
    player = "";
    computer = "";

    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
    Console.WriteLine("Enter Rock, Paper, Scissors: ");
    player = Console.ReadLine();
    player = player.ToUpper();
    }

    switch(random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }

    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);


    switch(player)
    {
        case "ROCK":
            if (computer == "PAPER")
            {
                Console.WriteLine("Computer wins!");
            }
            else if (computer == "ROCK")
            {
                Console.WriteLine("It's a Tie!");
            }
            else
            {
                Console.WriteLine("Player wins!");
            }
            break;
        case "PAPER":
            if (computer == "SCISSORS")
            {
                Console.WriteLine("Computer wins!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("It's a Tie!");
            }
            else
            {
                Console.WriteLine("Player wins!");
            }
            break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("Computer wins!");
            }
            else if (computer == "SCISSORS")
            {
                Console.WriteLine("It's a Tie!");
            }
            else
            {
                Console.WriteLine("Player wins!");
            }
            break;
    }

    Console.WriteLine("Do you want to play again? (Y/N)");
    String player_response = Console.ReadLine();
    player_response = player_response.ToUpper();
    if (player_response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}

Console.WriteLine("Thanks for playing!");