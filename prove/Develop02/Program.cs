using System;
using System.Collections.Generic;

namespace JournalProgram2
{
    public class Program
    {
        public static void Main()
        {
            int PromptLineCount = 0;
            Prompt prompt = new Prompt();
            List<string> Prompts = prompt.PromptFileGrab();
            foreach (var line in Prompts){PromptLineCount += 1;}
            int menuEntry;

            Journal journal = new Journal();
            Repository repository = new Repository();

            do{
                Console.WriteLine ("Select an option below by typing the corresponding number \n\n1. Create new journal entry with a prompt \n2. Create new journal entry without a prompt \n3. Display Journal \n4. Save Journal to file \n5. Load Journal from file  \n0. Exit Program");
                menuEntry = int.Parse(Console.ReadLine());

                if (menuEntry == 1)
                {
                    Entry entry = new Entry();
                    Random rdm = new Random();
                    int randomInt = rdm.Next(0,PromptLineCount);
                    string randomPrompt = Prompts[randomInt];

                    Console.WriteLine(randomPrompt);
                    entry.Prompt = randomPrompt;
                    entry.Text = Console.ReadLine();
                    entry.DateTime = Convert.ToString(DateTime.Now);

                    journal.AddEntry(entry);
                }

                else if (menuEntry == 2)
                {
                    Entry entry = new Entry();
                    entry.Prompt = "Free Script";
                    entry.Text = Console.ReadLine();
                    entry.DateTime = Convert.ToString(DateTime.Now);

                    journal.AddEntry(entry);    
                }

                else if (menuEntry == 3)
                {
                    journal.DisplayJournal();
                }

                else if (menuEntry == 4)
                {
                    repository.RecordJournal(journal.journal);
                }

                else if (menuEntry == 5)
                {
                    journal.journal = repository.RetrieveJournal();
                }

                else if (menuEntry == 0){return;}

                else {Console.WriteLine("Invalid entry");}

            } while (menuEntry != 0);

        }
    }
}