using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them..");
        
        while (!scripture.IsCompletelyHidden()) {
            Console.Clear();
            Console.Write($"Reference: {scripture.Reference} - ");
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("Press enter to hide a word, or type 'quit' to exit");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") {
                return;
            }
            else {
                scripture.HideWords(1);
            }
        }

        Console.Clear();
        Console.WriteLine("All the words are completely hidden.");
        Console.WriteLine(scripture.GetRenderedText());
    }
}