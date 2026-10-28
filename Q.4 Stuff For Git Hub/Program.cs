string classID = "120703";
string regID = "66582";
string studentName = "Ghazi Muhib";
string submissionDate = "27-Oct-2026 ";

Console.WriteLine($"Class ID: {classID} | Student ID: {regID} | Name: {studentName} | Date: {submissionDate}\n");

Console.Write("Enter Value 01: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter Value 02: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Select an operator( + , - , * , / ): ");
char op = Convert.ToChar(Console.ReadLine()!);

switch (op)
{
    case '+':
        Console.WriteLine("Result: " + (num1 + num2));
        break;

    case '-':
        Console.WriteLine("Result: " + (num1 - num2));
        break;

    case '*':
        Console.WriteLine("Result: " + (num1 * num2));
        break;

    case '/':
        if (num2 != 0)
            Console.WriteLine("Result: " + (num1 / num2));
        else
            Console.WriteLine("Cannot divide by zero.");
        break;

    default:
        Console.WriteLine("Invalid operator.");
        break;
}

Console.ReadKey();