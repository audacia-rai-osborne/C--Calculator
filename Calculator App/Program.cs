// See https://aka.ms/new-console-template for more information

var math = new Arithmetic();
int firstNumber;
int secondNumber;
int firstResult;

Console.WriteLine("How many operators does your calculation have?");
int numberOfOperators = Convert.ToInt32(Console.ReadLine());

if (numberOfOperators == 1)
{
    Console.WriteLine("What operator would you like to use?");
    var operatorType = Console.ReadLine();
    if (operatorType == "sin")
    {
        Console.WriteLine("What is the number you'd like to peform this operation on?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your result is - " + math.SinAnswer(firstNumber));
    }
    else if (operatorType == "log")
    {
        Console.WriteLine("What is the number you'd like to peform this operation on?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your result is - " + math.LogAnswer(firstNumber));
    }
    else if (operatorType == "sqrt")
    {
        Console.WriteLine("What is the number you'd like to peform this operation on?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your result is - " + math.SquareRootAnswer(firstNumber));
    }else if (operatorType == "+")
    {
        Console.WriteLine("What is the first number of your calculation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number of your calculation?");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        math.AddAnswer(firstNumber, secondNumber);
    }
    else if (operatorType == "-")
    {
        Console.WriteLine("What is the first number of your calculation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number of your calculation?");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your result is - " + math.SubtractAnswer(firstNumber, secondNumber));
    }
    else if (operatorType == "*")
    {
        Console.WriteLine("What is the first number of your calculation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number of your calculation?");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstNumber, secondNumber));
    }
    else if (operatorType == "/")
    {
        Console.WriteLine("What is the first number of your calculation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number of your calculation?");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your result is - " + math.DivideAnswer(firstNumber, secondNumber));
    }
    else if (operatorType == "%")
    {
        Console.WriteLine("What is the first number of your calculation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number of your calculation?");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your result is - " + math.ModulusAnswer(firstNumber, secondNumber));
    }
       
else if (numberOfOperators == 2)
    {
        Console.WriteLine("What is the first number of your calculation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the first operation of your calculation?");
        var operationType = Console.ReadLine();
        Console.WriteLine("What is the second number of your calculation?");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second operation of your calculation?");
        var operationTypeTwo = Console.ReadLine();
        Console.WriteLine("What is the third number of your calculation?");
        var thirdNumber = Convert.ToInt32(Console.ReadLine());
    if (operationTypeTwo == "sin")
        {
            firstResult = math.SinAnswer(firstNumber);
            if (operationType == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstNumber, firstResult));
            }
            else if (operationType == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstNumber, firstResult));
            }
            else if (operationType == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstNumber, firstResult));
            }
            else if (operationType == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstNumber, firstResult));
            }

        }
        else if(operationTypeTwo == "log")
        {
            firstResult = math.LogAnswer(firstNumber);
            if (operationType == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstNumber, firstResult));
            }
            else if (operationType == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstNumber, firstResult));
            }
            else if (operationType == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstNumber, firstResult));
            }
            else if (operationType == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstNumber, firstResult));
            }
        }
        else if(operationTypeTwo == "sqrt")
        {
            firstResult = math.SinAnswer(firstNumber);
            if (operationType == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstNumber, firstResult));
            }
            else if (operationType == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstNumber, firstResult));
            }
            else if (operationType == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstNumber, firstResult));
            }else if(operationType == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstNumber, firstResult));
            }
        }else if(operationType == "^" && operationTypeTwo != "^")
        {
            // firstResult = math.PowerOfAnswer(firstNumber, secondNumber);
        }
        else if (operationType != "^" && operationTypeTwo == "^")
        {
           //  firstResult = math.PowerOfAnswer(firstNumber, secondNumber);
        }
        else if (operationType == "/" && operationTypeTwo != "/")
        {
            firstResult = math.DivideAnswer(firstNumber, secondNumber);
            if (operationTypeTwo == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "")
            {
                Console.WriteLine("Your result is - " + firstResult);
            }
        }
        else if (operationTypeTwo == "/" && operationType != "/")
        {
            firstResult = math.DivideAnswer(secondNumber, thirdNumber);
            if (operationType == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstNumber, firstResult));
            }
            else if (operationType == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstNumber, firstResult));
            }
            else if (operationType == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstNumber, firstResult));
            }
        }
        else if (operationType == "*" && operationTypeTwo != "*")
        {
            firstResult = math.MultiplyAnswer(firstNumber, secondNumber);
            if (operationTypeTwo == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "")
            {
                Console.WriteLine("Your result is - " + firstResult);
            }
        }
        else if (operationType != "*" && operationTypeTwo == "*")
        {
            firstResult = math.MultiplyAnswer(secondNumber, thirdNumber);
            if (operationType == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstNumber, firstResult));
            }
            else if (operationType == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstNumber, firstResult));
            }
            else if (operationType == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstNumber, firstResult));
            }
        }
        else if (operationType == "+" && operationTypeTwo != "+")
        {
            firstResult = math.AddAnswer(firstNumber, secondNumber);
            if (operationTypeTwo == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "")
            {
                Console.WriteLine("Your result is - " + firstResult);
            }
        }
        else if (operationType != "+" && operationTypeTwo == "+")
        {
            firstResult = math.AddAnswer(secondNumber, thirdNumber);
            if (operationType == "-")
            {
                Console.WriteLine("Your result is - " + math.SubtractAnswer(firstNumber, firstResult));
            }
            else if (operationType == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstNumber, firstResult));
            }
            else if (operationType == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstNumber, firstResult));
            }
        }
        else if (operationType == "-" && operationTypeTwo != "-")
        {
            firstResult = math.SubtractAnswer(firstNumber, secondNumber);
            if (operationTypeTwo == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstResult, thirdNumber));
            }
            else if (operationTypeTwo == "")
            {
                Console.WriteLine("Your result is - " + firstResult);
            }
        }
        else if (operationType != "-" && operationTypeTwo == "-")
        {
            firstResult = math.SubtractAnswer(secondNumber, thirdNumber);
            if (operationType == "+")
            {
                Console.WriteLine("Your result is - " + math.AddAnswer(firstNumber, firstResult));
            }
            else if (operationType == "/")
            {
                Console.WriteLine("Your result is - " + math.DivideAnswer(firstNumber, firstResult));
            }
            else if (operationType == "*")
            {
                Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstNumber, firstResult));
            }
        }
        else if (operationType == "-" && operationTypeTwo == "-")
        {
            firstResult = math.SubtractAnswer(firstNumber, secondNumber);
            Console.WriteLine("Your result is - " + math.SubtractAnswer(firstResult, thirdNumber));
        }
        else if (operationType == "+" && operationTypeTwo == "+")
        {
            firstResult = math.AddAnswer(firstNumber, secondNumber);
            Console.WriteLine("Your result is - " + math.AddAnswer(firstResult, thirdNumber));
        }
        else if (operationType == "/" && operationTypeTwo == "/")
        {
            firstResult = math.DivideAnswer(firstNumber, secondNumber);
            Console.WriteLine("Your result is - " + math.DivideAnswer(firstResult, thirdNumber));
        }
        else if (operationType == "*" && operationTypeTwo == "*")
        {
            firstResult = math.MultiplyAnswer(firstNumber, secondNumber);
            Console.WriteLine("Your result is - " + math.MultiplyAnswer(firstResult, thirdNumber));
        };
    }

}

