using System;
using System.IO;
using System.Collections.Generic;

namespace JournalProgram2
{
    
    public class Repository
    {
        string filename = "";
        public void RecordJournal(List<Entry> journal)
        {
            Console.WriteLine("enter file name to save under:");
            filename = Console.ReadLine();
            filename = $"{filename}.txt";
            //string path = $"C:\\Users\\matt-\\Documents\\CSE210\\prove\\Develop02\\{filename}";
            //if(File.Exists(path))
            //{
                using (StreamWriter outputFile = new StreamWriter(filename))

                foreach (Entry entry in journal)
                {
                    outputFile.WriteLine($"{entry.Prompt}|{entry.Text}|{entry.DateTime}");
                }
           /* }
            else
            {
                Console.WriteLine("Invalid File name, returning to main menu.");
            }*/

            return;
        }

        public List<Entry> RetrieveJournal()
        {
            Console.WriteLine("type in file name to load: ");
            //filename = Console.ReadLine(); 
            filename = $"{Console.ReadLine()}.txt";
            //string path = $"C:\\Users\\matt-\\Documents\\CSE210\\prove\\Develop02\\{filename}";
            Journal journal = new Journal();
            if(File.Exists(filename))
            {
                string[] lines = System.IO.File.ReadAllLines(filename);
                //Journal journal = new Journal();

                foreach (string line in lines)
                {
                    Entry entry = new Entry();
                    string[] parts = line.Split("|");
                    entry.Prompt = parts[0];
                    entry.Text = parts[1];
                    entry.DateTime = parts[2];
                    journal.AddEntry(entry);
                }
            }
            else
            {
                Console.WriteLine("Invalid File name, returning to main menu.");
            }
            return journal.journal;
        }

        public Repository()
        {
        }
    }
}