// See https://aka.ms/new-console-template for more information

var math = new Arithmetic();

int firstNumber = Convert.ToInt32(Console.ReadLine());
var operationType = Console.ReadLine();
int secondNumber = Convert.ToInt32(Console.ReadLine());
var operationTypeTwo = Console.ReadLine();
var thirdNumber = Convert.ToInt32(Console.ReadLine());
int firstResult = 0;

if (operationType == "+") {
    firstResult = math.AddAnswer(firstNumber, secondNumber);
}else if (operationType == "-")
{
    firstResult = math.SubtractAnswer(firstNumber, secondNumber);
}
else if (operationType == "*")
{
    firstResult = math.MultiplyAnswer(firstNumber, secondNumber);
}
else if (operationType == "/")
{
    firstResult = math.DivideAnswer(firstNumber, secondNumber);
}
else if (operationType == "%")
{
    firstResult = math.ModulusAnswer(firstNumber, secondNumber);
};

if(operationTypeTwo == "")
{
    Console.WriteLine(firstResult);
}else if (operationTypeTwo == "+")
{
    Console.WriteLine(math.AddAnswer(firstResult, secondNumber));
}
else if (operationTypeTwo == "-")
{
    Console.WriteLine(math.SubtractAnswer(firstResult, secondNumber));
}
else if (operationTypeTwo == "*")
{
    Console.WriteLine(math.MultiplyAnswer(firstResult, secondNumber));
}
else if (operationTypeTwo == "/")
{
    Console.WriteLine(math.DivideAnswer(firstResult, secondNumber));
}
else if (operationTypeTwo == "%")
{
    Console.WriteLine(math.ModulusAnswer(firstResult, secondNumber));
};




