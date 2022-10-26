// --- Mauricio review, good job!


//---Variables--//
int number1;
int number2;
string playAgain = "Y";
bool isValid;


while(playAgain != "N")
{
    //-----inputs----//

    Console.WriteLine("Hello there, enter a number.");
    isValid = int.TryParse(Console.ReadLine(), out number1);

    Console.WriteLine("Enter another number.");
    isValid = int.TryParse(Console.ReadLine(), out number2);

    if(!isValid)
    {
        Console.WriteLine("Please enter a valid number.");
    }

   
    //----Conditionals----//


    if (number1 > number2)
    {
        Console.WriteLine($"{number1} is greater than {number2}.");
    }

    else {
        if (number1 < number2)
        {
        Console.WriteLine($"{number1} is less than {number2}.");  

        }
    }

    if (number1 == number2)
    {
        Console.WriteLine($"{number1} is equal to {number2}.");
    }

    //----second part----//

    if (number2 > number1)
    {
        Console.WriteLine($"{number2} is greater than {number1}.");
    }

    else {
        if (number2 < number1)
        {
        Console.WriteLine($"{number2} is less than {number1}.");  

        }
    }

    if (number2 == number1)
    {
        Console.WriteLine($"{number2} is equal to {number1}.");
    }
    
    Console.WriteLine("Do you want to play again? Y/N");
    playAgain = Console.ReadLine().ToUpper();
}

Console.WriteLine("Bye!");