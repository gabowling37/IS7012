// Greg Bowling (bowlingy) - Week 2 Exercise 2

int randomNumber = new Random().Next(1, 7); //GENERATES NUMBER BETWEEN 1 and 6
int winningNumber = 4;

if (randomNumber == winningNumber)
    Console.WriteLine($"The winning number was {winningNumber}, and you rolled {randomNumber}. You are the lucky winner!");
else
    Console.WriteLine($"The winning number was {winningNumber}, and you rolled {randomNumber}. Sorry, you lost this time...");