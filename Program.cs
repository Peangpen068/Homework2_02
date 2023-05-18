using System;

class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter a DNA sequence (half): ");
            string halfDNA = Console.ReadLine();

            if (IsValidSequence(halfDNA))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNA);
                Console.Write("Do you want to replicate it? (Y/N): ");
                string response = Console.ReadLine();

                if (response.ToUpper() == "Y")
                {
                    string replicatedHalfDNA = ReplicateSequence(halfDNA);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedHalfDNA);
                }
                else if (response.ToUpper() != "N")
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            string continueResponse = Console.ReadLine();

            if (continueResponse.ToUpper() == "N")
            {
                continueProgram = false;
            }
            else if (continueResponse.ToUpper() != "Y")
            {
                Console.WriteLine("Please input Y or N.");
            }

            Console.WriteLine();
        }
    }
}

