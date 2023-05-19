using System;
class Program
{
    static bool IsValidSequence(string halfDNASequence) => halfDNASequence.All("ATCG".Contains);
    static string ReplicateSequence(string halfDNASequence) => new string(halfDNASequence.Select(n => "TAGC"["ATCG".IndexOf(n)]).ToArray());
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a half DNA sequence: ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);

                bool validReplicateOption = false;
                while (!validReplicateOption)
                {
                    Console.Write("Do you want to replicate it? (Y/N): ");
                    string replicateOption = Console.ReadLine().ToUpper();

                    switch (replicateOption)
                    {
                        case "Y":
                            string replicatedSequence = ReplicateSequence(halfDNASequence);
                            Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                            validReplicateOption = true;
                            break;
                        case "N":
                            validReplicateOption = true;
                            break;
                        default:
                            Console.WriteLine("Please input Y or N.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }
            Console.Write("Do you want to process another sequence? (Y/N): ");
            string continueOption = Console.ReadLine().ToUpper();
            if (continueOption == "N")
                break;
        }
    }
}