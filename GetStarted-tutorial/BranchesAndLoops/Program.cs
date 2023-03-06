// BranchesAndLoopsFunction();

void BranchesAndLoopsFunction(){

// int a = 5;
// int b = 6;
// int b = 3;
// if (a + b > 10)
//     Console.WriteLine("The answer is greater than 10.");

int a = 5;
int b = 3;
// if (a + b > 10)
//     Console.WriteLine("The answer is greater than 10");
// else
//     Console.WriteLine("The answer is not greater than 10");

int c = 4;
// if ((a + b + c > 10) && (a == b))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("And the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("Or the first number is not equal to the second");
// }

if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

}


// ExploreIf();

void ExploreIf()
{
    // int a = 5;
    // int b = 3;
    // if (a + b > 10)
    // {
    //     Console.WriteLine("The answer is greater than 10");
    // }
    // else
    // {
    //     Console.WriteLine("The answer is not greater than 10");
    // }

    // int c = 4;
    // if ((a + b + c > 10) && (a > b))
    // {
    //     Console.WriteLine("The answer is greater than 10");
    //     Console.WriteLine("And the first number is greater than the second");
    // }
    // else
    // {
    //     Console.WriteLine("The answer is not greater than 10");
    //     Console.WriteLine("Or the first number is not greater than the second");
    // }

    // if ((a + b + c > 10) || (a > b))
    // {
    //     Console.WriteLine("The answer is greater than 10");
    //     Console.WriteLine("Or the first number is greater than the second");
    // }
    // else
    // {
    //     Console.WriteLine("The answer is not greater than 10");
    //     Console.WriteLine("And the first number is not greater than the second");
    // }


//     int counter = 0;
// while (counter < 10)
// {
//     Console.WriteLine($"Hello World! The counter is {counter}");
//     counter++;
// }

// int counter = 0;
// do
// {
//     Console.WriteLine($"Hello World! The counter is {counter}");
//     counter++;
// } while (counter < 10);

// for (int index = 0; index < 10; index++)
// {
//     Console.WriteLine($"Hello World! The index is {index}");
// }





}

// ExploreLoops();

void ExploreLoops(){
    for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
}

// ChallengeAnswer();

void ChallengeAnswer()
{
    int sum = 0;
    for (int number = 1; number < 21; number++)
    {
        if (number % 3 == 0)
        {
            sum = sum + number;
        }
    }
    Console.WriteLine($"The sum is {sum}");
}

// DisplayWeatherReport(15.0);  // Output: Cold.
// DisplayWeatherReport(24.0);  // Output: Perfect!

void DisplayWeatherReport(double tempInCelsius)
{
    // if (tempInCelsius < 20.0)
    // {
    //     Console.WriteLine("Cold.");
    // }
    // else
    // {
    //     Console.WriteLine("Perfect!");
    // }


}

// DisplayMeasurement(45);  // Output: The measurement value is 45
// DisplayMeasurement(-3);  // Output: Warning: not acceptable value! The measurement value is -3

// void DisplayMeasurement(double value)
// {
//     if (value < 0 || value > 100)
//     {
//         Console.Write("Warning: not acceptable value! ");
//     }

//     Console.WriteLine($"The measurement value is {value}");
// }

// DisplayCharacter('f');  // Output: A lowercase letter: f
// DisplayCharacter('R');  // Output: An uppercase letter: R
// DisplayCharacter('8');  // Output: A digit: 8
// DisplayCharacter(',');  // Output: Not alphanumeric character: ,

void DisplayCharacter(char ch)
{
    if (char.IsUpper(ch))
    {
        Console.WriteLine($"An uppercase letter: {ch}");
    }
    else if (char.IsLower(ch))
    {
        Console.WriteLine($"A lowercase letter: {ch}");
    }
    else if (char.IsDigit(ch))
    {
        Console.WriteLine($"A digit: {ch}");
    }
    else
    {
        Console.WriteLine($"Not alphanumeric character: {ch}");
    }
}

// DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
// DisplayMeasurement(5);  // Output: Measured value is 5.
// DisplayMeasurement(30);  // Output: Measured value is 30; too high.
// DisplayMeasurement(double.NaN);  // Output: Failed measurement.

// void DisplayMeasurement(double measurement)
// {
//     switch (measurement)
//     {
//         case < 0.0:
//             Console.WriteLine($"Measured value is {measurement}; too low.");
//             break;

//         case > 15.0:
//             Console.WriteLine($"Measured value is {measurement}; too high.");
//             break;

//         case double.NaN:
//             Console.WriteLine("Failed measurement.");
//             break;

//         default:
//             Console.WriteLine($"Measured value is {measurement}.");
//             break;
//     }
// }

// DisplayMeasurement(-4);  // Output: Measured value is -4; out of an acceptable range.
// DisplayMeasurement(50);  // Output: Measured value is 50.
// DisplayMeasurement(132);  // Output: Measured value is 132; out of an acceptable range.

// void DisplayMeasurement(int measurement)
// {
//     switch (measurement)
//     {
//         case < 0:
//         case > 100:
//             Console.WriteLine($"Measured value is {measurement}; out of an acceptable range.");
//             break;
        
//         default:
//             Console.WriteLine($"Measured value is {measurement}.");
//             break;
//     }
// }


DisplayMeasurements(3, 4);  // Output: First measurement is 3, second measurement is 4.
DisplayMeasurements(5, 5);  // Output: Both measurements are valid and equal to 5.

void DisplayMeasurements(int a, int b)
{
    switch ((a, b))
    {
        case (> 0, > 0) when a == b:
            Console.WriteLine($"Both measurements are valid and equal to {a}.");
            break;

        case (> 0, > 0):
            Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
            break;

        default:
            Console.WriteLine("One or both measurements are not valid.");
            break;
    }
}