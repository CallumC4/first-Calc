Console.WriteLine("choose a number");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("choose an operation");
Console.WriteLine("choose 1 for addition");
Console.WriteLine("choose 2 for subtraction");
Console.WriteLine("choose 3 for multiplication");
Console.WriteLine("choose 4 for division");

int operation = int.Parse(Console.ReadLine());
float result = 0;

Console.WriteLine("choose another number");
float num2 = float.Parse(Console.ReadLine());

if (operation == 1)
{ 
    result = num1 + num2;
}


if (operation == 2)
{
     result = num1 - num2;
}

if (operation == 3)
{
     result = num1 * num2;
}

else
{
    result = num1 / num2;
}

Console.WriteLine(result);




