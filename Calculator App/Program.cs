// See https://aka.ms/new-console-template for more information

//var add = new Addition();
//var sub = new Subtraction();
//var multi = new Multiply();
//var divide = new Divide();
//var mod = new Modulus();

List<Calculator_App.iArithmetic> _all_operators;

_all_operators = new List<Calculator_App.iArithmetic>()
            {
                new Addition(),
                new Subtraction(),
                new Multiply(),
                new Divide(),
                new Modulus(),
                new PowerOfAnswer(),
                new SinAnswer(),
                new LogAnswer(),
                new SquareRootAnswer()
            };

decimal firstNumber;
decimal secondNumber;
decimal thirdNumber;
int numberOfOperators;
int numberOfZeros = 0;
string? operatorType;
string? operatorTypeTwo;
string secondNumberTake;

List<decimal> _numbers = new List<decimal>();
List<decimal> calcNumbers = new List<decimal>();
List<string> _operators = new List<string>();
List<dynamic> calcOperators = new List<dynamic>();
List<dynamic> _outputResult = new List<dynamic>();

void GetAllInputs() {
    Console.WriteLine("How many operators does your calculation have?");
numberOfOperators = Convert.ToInt32(Console.ReadLine());

if (numberOfOperators == 1)
{
        Console.WriteLine("What is the first number of this operation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        _numbers.Add(firstNumber);
        Console.WriteLine("What operator would you like to use?");
        operatorType = Console.ReadLine();
        _operators.Add(operatorType);
        Console.WriteLine("What is the second number of this operation? If there is none, enter 0");
        string secondNumberTest = Console.ReadLine();
        // this is a custom throw error for is users do not input a second number, wiht secondNumber updated to secondNumberTake and conversion to int removed
        //if (string.IsNullOrEmpty(secondNumberTake))
        //{
        //    throw new Calculator_App.NumberNotFound();
        //}
        //else
        //{
        //    secondNumber = Convert.ToInt32(secondNumberTake);
        //    _numbers.Add(secondNumber);
        //};
        // this a try-catch for if users don't input a second number
        try
        {
            // some code that might throw an exception
            secondNumber = Convert.ToInt32(secondNumberTest);
            _numbers.Add(secondNumber);
        }
        catch (Exception e)
        {
            // do something specific with NotSupportedException
            Console.WriteLine("A number was not given");
            throw;

        }

        // this makes code actually work is secondNumber is updated to secondNumberTake and conversion to int is removed
        //if (!string.IsNullOrEmpty(secondNumberTake)){
        //    secondNumber = Convert.ToInt32(secondNumberTake);
        //    _numbers.Add(secondNumber);
        //}
    }
else if (numberOfOperators == 2)
{
        Console.WriteLine("What is the first number of this operation?");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        _numbers.Add(firstNumber);
        Console.WriteLine("What operator would you like to use?");
        operatorType = Console.ReadLine();
        _operators.Add(operatorType);
        Console.WriteLine("What is the second number of this operation?");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        _numbers.Add(secondNumber);
        Console.WriteLine("What is the second operator of this operation?");
        operatorTypeTwo = Console.ReadLine();
        _operators.Add(operatorTypeTwo);
        Console.WriteLine("What is the third number of your operation?");
        thirdNumber = Convert.ToInt32(Console.ReadLine());
        _numbers.Add(thirdNumber);
    }
}

void CompleteCalculations() { 

switch (numberOfOperators)
{
    case 1:
            if (_operators[0] == "sin")
            {
                calcOperators.Add(_all_operators[0]);
                calcNumbers.Add(_numbers[0]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);   
            }
            else if (_operators[0] == "log")
            {
                calcOperators.Add(_all_operators[1]);
                calcNumbers.Add(_numbers[0]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);
            }
            else if(_operators[0] == "sqrt")
            {
                calcOperators.Add(_all_operators[2]);
                calcNumbers.Add(_numbers[0]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);
            }
            else if (_operators[0] == "^")
            {
                calcOperators.Add(_all_operators[5]);
                calcNumbers.Add(_numbers[0]);
                calcNumbers.Add(_numbers[1]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);
            }
            else if (_operators[0] == "+")
        {
                calcOperators.Add(_all_operators[0]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);
            }
        else if (_operators[0] == "-")
        {
                    calcOperators.Add(_all_operators[1]);
                    calcNumbers.Add(_numbers[0]);
                    calcNumbers.Add(_numbers[1]);
                    ListSingleFinalCalculation(calcOperators, calcNumbers);
                }
        else if (_operators[0] == "*")
        {
                        calcOperators.Add(_all_operators[2]);
                        calcNumbers.Add(_numbers[0]);
                        calcNumbers.Add(_numbers[1]);
                        ListSingleFinalCalculation(calcOperators, calcNumbers);

                    }
        else if (_operators[0] == "/")
        {
    calcOperators.Add(_all_operators[3]);
    calcNumbers.Add(_numbers[0]);
    calcNumbers.Add(_numbers[1]);
    ListSingleFinalCalculation(calcOperators, calcNumbers);
}
        else if (_operators[0] == "%")
    {
    calcOperators.Add(_all_operators[4]);
    calcNumbers.Add(_numbers[0]);
    calcNumbers.Add(_numbers[1]);
    ListSingleFinalCalculation(calcOperators, calcNumbers);

}
        break;

    case 2:
        switch (_operators[0])
        {
            case "^":
               if (_operators[1] == "+")
               {
                    calcOperators.Add(_operators[0]);
                    calcOperators.Add(_operators[1]);
                    calcNumbers.Add(_numbers[0]);
                    calcNumbers.Add(_numbers[1]);
                    calcNumbers.Add(_numbers[2]);
                    ListSingleFinalCalculation(calcOperators, calcNumbers);
        }
        else if (_operators[1] == "-")
        {
            calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
        }
        else if (_operators[1] == "*")
        {
            calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
                }
                else if (_operators[1] == "/")
                {
                   calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
                }
                    break;

            case "/":

        if (_operators[1] == "^")
        {
        calcOperators.Add(_operators[1]);
        calcOperators.Add(_operators[0]);
        calcNumbers.Add(_numbers[1]);
        calcNumbers.Add(_numbers[2]);
        calcNumbers.Add(_numbers[0]);
        ListSingleFinalCalculation(calcOperators, calcNumbers);
        }
        else if (_operators[1] == "+")
                {
                   calcOperators.Add(_operators[0]);
                   calcOperators.Add(_operators[1]);
                   calcNumbers.Add(_numbers[0]);
                   calcNumbers.Add(_numbers[1]);
                   calcNumbers.Add(_numbers[2]);
                        ListSingleFinalCalculation(calcOperators, calcNumbers);
                    }
                else if (_operators[1] == "-")
                {
            calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
                        ListSingleFinalCalculation(calcOperators, calcNumbers);
                    }
                else if (_operators[1] == "*")
                {
            calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
                    }
                else if (_operators[1] == "/")
                {
            calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
                    }
;

                    break;

            case "*":
        if (_operators[1] == "+")
        {
            calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
        }
        else if (_operators[1] == "-")
        {
            calcOperators.Add(_operators[0]);
            calcOperators.Add(_operators[1]);
            calcNumbers.Add(_numbers[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
        }
        else if (_operators[1] == "/")
        {
            calcOperators.Add(_operators[1]);
            calcOperators.Add(_operators[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            calcNumbers.Add(_numbers[0]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
        }
        else if (_operators[1] == "^")
        {
            calcOperators.Add(_operators[1]);
            calcOperators.Add(_operators[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            calcNumbers.Add(_numbers[0]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
        }


        break;

            case "+":
                {
                    if (_operators[1] == "-")
                    {
                calcOperators.Add(_operators[0]);
                calcOperators.Add(_operators[1]);
                calcNumbers.Add(_numbers[0]);
                calcNumbers.Add(_numbers[1]);
                calcNumbers.Add(_numbers[2]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);
                        }
                    else if (_operators[1] == "+")
                    {
                calcOperators.Add(_operators[0]);
                calcOperators.Add(_operators[1]);
                calcNumbers.Add(_numbers[0]);
                calcNumbers.Add(_numbers[1]);
                calcNumbers.Add(_numbers[2]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);
                        }
                    else if (_operators[1] == "/")
                    {
                calcOperators.Add(_operators[1]);
                calcOperators.Add(_operators[0]);
                calcNumbers.Add(_numbers[1]);
                calcNumbers.Add(_numbers[2]);
                calcNumbers.Add(_numbers[0]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);
                        }
                    else if (_operators[1] == "*")
                    {
                calcOperators.Add(_operators[1]);
                calcOperators.Add(_operators[0]);
                calcNumbers.Add(_numbers[1]);
                calcNumbers.Add(_numbers[2]);
                calcNumbers.Add(_numbers[0]);
                ListSingleFinalCalculation(calcOperators, calcNumbers);;
                        }
            else if (_operators[1] == "^")
            {
            calcOperators.Add(_operators[1]);
            calcOperators.Add(_operators[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            calcNumbers.Add(_numbers[0]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
           
            };
            break;
                }


            case "-":
                if (_operators[1] == "+")
                {
            calcOperators.Add(_operators[1]);
            calcOperators.Add(_operators[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            calcNumbers.Add(_numbers[0]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
                    }else if (_operators[1] == "/")
                {
            calcOperators.Add(_operators[1]);
            calcOperators.Add(_operators[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            calcNumbers.Add(_numbers[0]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
                    }
                else if (_operators[1] == "*")
                {
            calcOperators.Add(_operators[1]);
            calcOperators.Add(_operators[0]);
            calcNumbers.Add(_numbers[1]);
            calcNumbers.Add(_numbers[2]);
            calcNumbers.Add(_numbers[0]);
            ListSingleFinalCalculation(calcOperators, calcNumbers);
                    }
        else if (_operators[1] == "^")
        {
        calcOperators.Add(_operators[1]);
        calcOperators.Add(_operators[0]);
        calcNumbers.Add(_numbers[1]);
        calcNumbers.Add(_numbers[2]);
        calcNumbers.Add(_numbers[0]);
        ListSingleFinalCalculation(calcOperators, calcNumbers);
       
        }
        break;
        }
        break;
    }


void ListSingleFinalCalculation(List<dynamic> operation, List<decimal> numbers )
{
    if (operation.Count > 1)
    {
            Console.WriteLine("Hello");
            decimal firstResult = operation[0].Do(_numbers[0], _numbers[1]);
            decimal result = operation[1].Do(_numbers[3], firstResult);
        ScientificResult(result);    
    }
    else if (operation.Count == 1 && numbers.Count == 1)
    {

        decimal result = operation[0].Do(_numbers[0]);
        ScientificResult(result);
        }
        else
        {
            decimal result = operation[0].Do(_numbers[0], _numbers[1]);
            ScientificResult(result);
        }

}

void ScientificResult(decimal finalResult){
        string stringFinalResult = finalResult.ToString("");
        string[] splitFinalResult = stringFinalResult.Split(".");
        if (splitFinalResult.Length > 1)
        {
            foreach (var item in splitFinalResult[1])
            {
                if (item.ToString() == "0")
                {
                    numberOfZeros = numberOfZeros + 1;
                }
            }
            if (numberOfZeros >= 7)
            {
                _outputResult.Add(splitFinalResult[1][numberOfZeros]);
                _outputResult.Add('.');
                _outputResult.Add(splitFinalResult[1][numberOfZeros + 1]);
                _outputResult.Add(splitFinalResult[1][numberOfZeros + 2]);
                _outputResult.Add("x 10 ^-");
                _outputResult.Add(numberOfZeros + 1);
                Console.WriteLine("Your result is: " + string.Join("", _outputResult));
            }
        }
        else
        {
            Console.WriteLine("Your result is: " + stringFinalResult);
        }

        

       
    }

}



GetAllInputs();
CompleteCalculations();

        
       
       
         
        
    
  



       


