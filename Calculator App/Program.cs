// See https://aka.ms/new-console-template for more information

var math = new Arithmetic();

int firstNumber = Convert.ToInt32(Console.ReadLine());
var operationType = Console.ReadLine();
int secondNumber = Convert.ToInt32(Console.ReadLine());
var operationTypeTwo = Console.ReadLine();
var thirdNumber = Convert.ToInt32(Console.ReadLine());
int firstResult = 0;

if (operationType == "/" && operationTypeTwo != "/")
{
    firstResult = math.DivideAnswer(firstNumber, secondNumber);
    if (operationTypeTwo == "+")
    {
        Console.WriteLine(math.AddAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "-")
    {
        Console.WriteLine(math.SubtractAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "*")
    {
        Console.WriteLine(math.MultiplyAnswer(firstResult, thirdNumber));
    }
}
else if (operationTypeTwo == "/" && operationType != "/")
{
    firstResult = math.DivideAnswer(secondNumber, thirdNumber);
    if (operationType == "+")
    {
        Console.WriteLine(math.AddAnswer(firstNumber, firstResult));
    }
    else if (operationType == "-")
    {
        Console.WriteLine(math.SubtractAnswer(firstNumber, firstResult));
    }
    else if (operationType == "*")
    {
        Console.WriteLine(math.MultiplyAnswer(firstNumber, firstResult));
    }
}
else if (operationType == "*" && operationTypeTwo != "*")
{
    firstResult = math.MultiplyAnswer(firstNumber, secondNumber);
    if (operationTypeTwo == "+")
    {
        Console.WriteLine(math.AddAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "-")
    {
        Console.WriteLine(math.SubtractAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "/")
    {
        Console.WriteLine(math.DivideAnswer(firstResult, thirdNumber));
    }
}
else if (operationType != "*" && operationTypeTwo == "*")
{
    firstResult = math.MultiplyAnswer(secondNumber, thirdNumber);
    if (operationType == "+")
    {
        Console.WriteLine(math.AddAnswer(firstNumber, firstResult));
    }
    else if (operationType == "-")
    {
        Console.WriteLine(math.SubtractAnswer(firstNumber, firstResult));
    }
    else if (operationType == "/")
    {
        Console.WriteLine(math.DivideAnswer(firstNumber, firstResult));
    }
}
else if (operationType == "+" && operationTypeTwo != "+")
{
    firstResult = math.AddAnswer(firstNumber, secondNumber);
    if (operationTypeTwo == "-")
    {
        Console.WriteLine(math.SubtractAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "/")
    {
        Console.WriteLine(math.DivideAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "*")
    {
        Console.WriteLine(math.MultiplyAnswer(firstResult, thirdNumber));
    }
}
else if (operationType != "+" && operationTypeTwo == "+")
{
    firstResult = math.AddAnswer(secondNumber, thirdNumber);
    if (operationType == "-")
    {
        Console.WriteLine(math.SubtractAnswer(firstNumber, firstResult));
    }
    else if (operationType == "/")
    {
        Console.WriteLine(math.DivideAnswer(firstNumber, firstResult));
    }
    else if (operationType == "*")
    {
        Console.WriteLine(math.MultiplyAnswer(firstNumber, firstResult));
    }
}
else if (operationType == "-" && operationTypeTwo != "-")
{
    firstResult = math.SubtractAnswer(firstNumber, secondNumber);
    if (operationTypeTwo == "+")
    {
        Console.WriteLine(math.AddAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "/")
    {
        Console.WriteLine(math.DivideAnswer(firstResult, thirdNumber));
    }
    else if (operationTypeTwo == "*")
    {
        Console.WriteLine(math.MultiplyAnswer(firstResult, thirdNumber));
    }
}
else if (operationType != "-" && operationTypeTwo == "-")
{
    firstResult = math.SubtractAnswer(secondNumber, thirdNumber);
    if (operationType == "+")
    {
        Console.WriteLine(math.AddAnswer(firstNumber, firstResult));
    }
    else if (operationType == "/")
    {
        Console.WriteLine(math.DivideAnswer(firstNumber, firstResult));
    }
    else if (operationType == "*")
    {
        Console.WriteLine(math.MultiplyAnswer(firstNumber, firstResult));
    }
}else if (operationType == "-" && operationTypeTwo == "-")
{
    firstResult = math.SubtractAnswer(firstNumber, secondNumber);
    Console.WriteLine(math.SubtractAnswer(firstResult, thirdNumber));
}
else if (operationType == "+" && operationTypeTwo == "+")
{
    firstResult = math.AddAnswer(firstNumber, secondNumber);
    Console.WriteLine(math.AddAnswer(firstResult, thirdNumber));
}
else if (operationType == "/" && operationTypeTwo == "/")
{
    firstResult = math.DivideAnswer(firstNumber, secondNumber);
    Console.WriteLine(math.DivideAnswer(firstResult, thirdNumber));
}
else if (operationType == "*" && operationTypeTwo == "*")
{
    firstResult = math.MultiplyAnswer(firstNumber, secondNumber);
    Console.WriteLine(math.MultiplyAnswer(firstResult, thirdNumber));
};





//check both operators and do divide first then other
//if no divide do multiply then other
//if no multiply then add then other
//if no add then subtract startig with operationTypeOne


//if (operationType == "+") {
//    firstResult = math.AddAnswer(firstNumber, secondNumber);
//}else if (operationType == "-")
//{
//    firstResult = math.SubtractAnswer(firstNumber, secondNumber);
//}
//else if (operationType == "*")
//{
//    firstResult = math.MultiplyAnswer(firstNumber, secondNumber);
//}
//else if (operationType == "/")
//{
//    firstResult = math.DivideAnswer(firstNumber, secondNumber);
//}
//else if (operationType == "%")
//{
//    firstResult = math.ModulusAnswer(firstNumber, secondNumber);
//};

//if(operationTypeTwo == "")
//{
//    Console.WriteLine(firstResult);
//}else if (operationTypeTwo == "+")
//{
//    Console.WriteLine(math.AddAnswer(firstResult, secondNumber));
//}
//else if (operationTypeTwo == "-")
//{
//    Console.WriteLine(math.SubtractAnswer(firstResult, secondNumber));
//}
//else if (operationTypeTwo == "*")
//{
//    Console.WriteLine(math.MultiplyAnswer(firstResult, secondNumber));
//}
//else if (operationTypeTwo == "/")
//{
//    Console.WriteLine(math.DivideAnswer(firstResult, secondNumber));
//}
//else if (operationTypeTwo == "%")
//{
//    Console.WriteLine(math.ModulusAnswer(firstResult, secondNumber));
//};


//division then multiplication then addition then subtraction

