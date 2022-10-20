//Maddie Gowan
//10-18-2022
//Mini Challenge #4 - Greater Than Or Less Than
//In this challenge we will compare two numbers, in order to etermine if they are
//greater than or smaller than eachother

Console.Clear();

Console.Write("Would you like to play Greater Than or Less Than? Y or N: ");
string play = Console.ReadLine().ToUpper();

if (play != "Y" && play != "N")
{
    Console.WriteLine("This is an incorrect response. Please try again.");
    Console.WriteLine("Would you like to play Greater Than or Less Than? Y or N: ");
    play = Console.ReadLine().ToUpper();
}


if (play == "N")
{
    Console.WriteLine("Okay, goodbye.");
}

while (play == "Y")
{
    bool validNum1;
    bool validNum2;
    int numOne;
    int numTwo;

    Console.WriteLine("Please enter your first number:");
    string num1 = Console.ReadLine();

    Console.WriteLine("Now please enter your second number:");
    string num2 = Console.ReadLine();

    validNum1 = int.TryParse(num1, out numOne);
    validNum2 = int.TryParse(num2, out numTwo);

    if (validNum1 == false || validNum2 == false)
    {
        Console.WriteLine("Only enter valid numbers please!");
    }


    if (validNum1 == true && validNum2 == true)
    {

        Console.WriteLine("Is your first number greater, smaller, or equal to your second number?");
        if (numOne > numTwo)
        { Console.WriteLine(numOne + " is greater than " + numTwo); }

        else if (numOne == numTwo)
        { Console.WriteLine(numOne + " is equal to " + numTwo); }

        else if (numOne < numTwo)
        { Console.WriteLine(numOne + " is smaller than " + numTwo); }


        Console.WriteLine("Is your second number greater, smaller, or equal to your first number?");
        if (numTwo > numOne)
        {
            Console.WriteLine(numTwo + " is greater than " + numOne);
            Console.Write("Would you like to play again? Y or N: ");
            play = Console.ReadLine().ToUpper();
            if (play != "N" && play != "Y")
            {
                Console.WriteLine("Please enter a valid response");
                play = Console.ReadLine().ToUpper();
            }
        }

        else if (numTwo == numOne)
        {
            Console.WriteLine(numTwo + " is equal to " + numOne);
            Console.Write("Would you like to play again? Y or N: ");
            play = Console.ReadLine().ToUpper();
            if (play != "N" && play != "Y")
            {
                Console.WriteLine("Please enter a valid response");
                play = Console.ReadLine().ToUpper();
            }
        }

        else if (numTwo < numOne)
        {
            Console.WriteLine(numTwo + " is smaller than " + numOne);
            Console.Write("Would you like to play again? Y or N: ");
            play = Console.ReadLine().ToUpper();
            if (play != "N" && play != "Y")
            {
                Console.WriteLine("Please enter a valid response");
                play = Console.ReadLine().ToUpper();
            }
        }
    }
}
