    
string classID = "120703";
string regID = "66582";
string studentName = "Ghazi Muhib";
string submissionDate = "25-Oct-2026 ";

Console.WriteLine($"Class ID: {classID} | Student ID: {regID} | Name: {studentName} | Date: {submissionDate}\n");
Console.Write("Enter day number (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());


    switch (day) 
    {   
        case 1: Console.WriteLine("Monday"); break; 
        case 2: Console.WriteLine("Tuesday"); break;
        case 3: Console.WriteLine("Wednesday"); break; 
        case 4: Console.WriteLine("Thursday"); break; 
        case 5: Console.WriteLine("Friday"); break; 
        case 6: Console.WriteLine("Saturday"); break; 
        case 7: Console.WriteLine("Sunday"); break; 
        default: Console.WriteLine("Invalid number"); break;
    }

Console.ReadKey();