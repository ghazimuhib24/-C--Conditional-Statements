string classID = "120703";
string regID = "66582";
string studentName = "Ghazi Muhib";
string submissionDate = "27-Oct-2026 ";

Console.WriteLine($"Class ID: {classID} | Student ID: {regID} | Name: {studentName} | Date: {submissionDate}\n");
Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

if (year % 400 == 0)
{
    Console.WriteLine("Leap Year");
}
else if (year % 100 == 0)
{
    Console.WriteLine("Not a Leap Year");
}
else if (year % 4 == 0)
{
    Console.WriteLine("Leap Year");
}
else
{
    Console.WriteLine("Not a Leap Year");
}

Console.ReadKey();