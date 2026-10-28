
string classID = "120703";
string regID = "66582";
string studentName = "Ghazi Muhib";
string submissionDate = "26-Oct-2026";

Console.WriteLine($"ClassID: {classID} | RegID: {regID} | Name: {studentName} | Date: {submissionDate}\\n");

Console.Write("Enter purchase amount: ");
double amount = Convert.ToDouble(Console.ReadLine());

double discount = 0;

if (amount >= 5000)
{
    discount = 20;
}
else if (amount >= 2000)
{
    discount = 10;
}

double discountAmount = amount * discount / 100;
double finalAmount = amount - discountAmount;

Console.WriteLine("Discount: " + discount + "%");
Console.WriteLine("Discount Amount: " + discountAmount);
Console.WriteLine("Final Amount: " + finalAmount);

Console.ReadKey();