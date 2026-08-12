

string[] names = new string[] { "Ben", "Yash", "Smokey" };
string indexText;

do
{
    Console.Write("Enter array index: ");
    indexText = Console.ReadLine();

    if (indexText.ToLower() != "exit")
    {
        if (String.IsNullOrEmpty(indexText) == false)
        {
            if (int.TryParse(indexText, out int index))
            {
                if (index >= 0 && index < 3)
                {
                    Console.WriteLine($"Name chosen is {names[index]}");
                }
                else
                {
                    Console.WriteLine("Index out of bounds");
                }
            }
            else
            {
                Console.WriteLine("Invalid index entered");
            }
        }
        else
        {
            Console.WriteLine("Please enter an index");
        }
    }
    else
    {
        Console.WriteLine("Exiting");
    }
 
} while (indexText.ToLower() != "exit");

