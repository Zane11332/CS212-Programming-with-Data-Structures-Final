HashSet<string> oldPasswords = new HashSet<string>();
string password = "";

while (password != "q")
{
    Console.WriteLine("Enter password ('q' to quit):");
    
    password = Console.ReadLine()!;
    
    if (password == "q")
    {
        break;
    }
    
    if (password == "")
    {
        Console.WriteLine("Please enter something nerd");
    }
    
    else if(oldPasswords.Contains(password))
    {
        Console.WriteLine("You have entered an old password. Try again.");
    }
    
    else
    {
        oldPasswords.Add(password);
    }
}
Console.WriteLine("Thank you for using a set here are all your passwords.");
Console.WriteLine(string.Join(", ", oldPasswords));
