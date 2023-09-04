
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Xml.Linq;

string? readResult = "";
string firstName = "";
string age = "";

//-welcome to the application
Console.WriteLine("Welcome to the application!\n");

//-ask for name
Console.Write("What is your first name?\t");
readResult = Console.ReadLine();
if (readResult != null)
    firstName  = readResult.Trim().ToLower();

//- ask for age
Console.Write("How old are you?\t");
readResult = Console.ReadLine();
if (readResult != null)
    age = readResult.Trim();

//- welcome user
//--if name is Bob or Sue
//Welcome Proffesor!
//--if not
//Hi { name}!
Console.WriteLine();
if (firstName == "bob" || firstName == "sue")
{
    Console.WriteLine("Welcome Proffesor!");
}
else
{
    Console.WriteLine($"Welcome {firstName}!");
}

//-turn age into int
//-if person is uner 21
//--wait {21-age} years to start this class
//-if not
//--you can start the class now!
Console.WriteLine();
if (int.TryParse(age, out int validAge))
{
    if(validAge < 21)
    {
        int yearsToWait = 21 - validAge;
        Console.WriteLine($"You should wait {yearsToWait} years to start this class.");
    }
    else 
    {
        Console.WriteLine("You can start the class now!");
    }
}
else
{
    Console.WriteLine("Sorry, your age is not in valid format. Try again.");
}

Console.ReadLine();