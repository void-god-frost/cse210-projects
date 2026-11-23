using System;

class Program
{
    static void Main(string[] args)
    {
            Reference reference = new Reference("Joseph Smith first vision", 0, 0);
            Scripture scripture = new Scripture(
                reference,
                """
                I saw a pillar of light, exactly over my head above the brightness
                 of the sun which descended upon me gradually. When it fell upon, 
                 I saw two personages, standing above me in the air, one of them 
                 spake, calling me by name and said, pointing to the other, this 
                 sis my beloved son, hear him!
                """
            );

            string command = "";
        while (command.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.Write("Press Enter to hide words or type 'quit' to end: ");
            command = Console.ReadLine() ?? "";
            if (command.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}