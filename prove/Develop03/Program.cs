
// Creativity and Exceeding Requirements
// Changing scriptures between multiple ones

using System;

public class Program
{
    public static void Main(string[] args)
    {
        var scriptureLibrary = new ScriptureLibrary();

        // Add scriptures to the library
        var nephi37 = new Scripture(new Reference("Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        var moroni43 = new Scripture(new Reference("Moroni", 4, 3), "O God, the Eternal Father, we ask thee in the name of thy Son, Jesus Christ, to bless and sanctify this bread to the souls of all those who partake of it; that they may eat in remembrance of the body of thy Son, and witness unto thee, O God, the Eternal Father, that they are willing to take upon them the name of thy Son, and always remember him, and keep his commandments which he hath given them, that they may always have his Spirit to be with them. Amen.");
        var moroni52 = new Scripture(new Reference("Moroni", 5, 2), "O God, the Eternal Father, we ask thee, in the name of thy Son, Jesus Christ, to bless and sanctify this wine to the souls of all those who drink of it, that they may do it in remembrance of the blood of thy Son, which was shed for them; that they may witness unto thee, O God, the Eternal Father, that they do always remember him, that they may have his Spirit to be with them. Amen.");

        scriptureLibrary.AddScripture(nephi37);
        scriptureLibrary.AddScripture(moroni43);
        scriptureLibrary.AddScripture(moroni52);

        while (true)
        {
            var randomScripture = scriptureLibrary.GetRandomScripture();
            if (randomScripture != null)
            {
                PresentScripture(randomScripture);

                if (randomScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words in the scripture are hidden. Press Enter to exit.");
                    Console.ReadLine();
                    break;
                }
            }

            Console.WriteLine("Press Enter to continue or type 'exit' to quit:");
            var input = Console.ReadLine();
            if (input.ToLower() == "exit" || input.ToLower() == "quit")
                break;

            // Hide random words after displaying the scripture
            HideRandomWords(randomScripture, 3); // Hide 3 random words
        }
    }

    public static void PresentScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }

    public static void HideRandomWords(Scripture scripture, int numberToHide)
    {
        scripture.HideRandomWords(numberToHide);
    }
}