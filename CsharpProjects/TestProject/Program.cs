string? readResult;
bool validEntry = false;
Console.Write("Enter your role name (Administrator, Manager, or User): ");
do
{
    readResult = Console.ReadLine().ToLower().Trim();
    if (readResult != null)
    {
        if (readResult == "administrator" || readResult == "manager" || readResult == "user")
        {
           validEntry = true;
           Console.WriteLine($"Your input value \"{readResult}\" has been accepted.");
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role");
        }
    }
} while (validEntry == false);



