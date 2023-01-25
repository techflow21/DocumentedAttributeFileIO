
namespace DocumentedAttribute
{
    internal class MenuOptions
    {
        public void Menu()
        {
            bool repeat = true;

            while (repeat)
            {
                Console.Write("\n\t Select an operation to carry out:\n\t =================================\n\t 1. Write to Text file\n\t 2. Write to JSON file \n\t 3. Read from TXT file \n\t 4. Read from JSON file \n\t 5. To Exit \n\n\t ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.Clear();
                        Operation.WriteToTxt();
                        break;

                    case "2":
                        Console.Clear();
                        WriteToJSON.GetWriteToJson();
                        break;

                    case "3":
                        Console.Clear();
                        Operation.ReadFromTxt();
                        break;

                    case "4":
                        Console.Clear();
                        Operation.ReadFromJson();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n\t Invalid selection. Please try again.\n");
                        break;
                }

                Console.Write("\n\t Do you want to carry out another operation? (y/n) \n\t ");

                string repeatChoice = Console.ReadLine().ToLower();
                
                if (repeatChoice == "n")
                {
                    repeat = false;
                }
                else if (repeatChoice != "y")
                {
                    Console.WriteLine("\n\t You entered invalid character.");
                    repeat = false;
                }
            }
        }
    }
}
