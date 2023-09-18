using System;
using System.Collections.Generic;


namespace JournalProgram2
{
    public class Journal
    {
        public List<Entry> journal = new List<Entry>();

        public Journal()
        {
        }
        
        public List<Entry> AddEntry(Entry entry)
        {
            if(!journal.Contains(entry))
            {
                journal.Add(entry);
            }
            return journal;
        }

        public List<Entry> RemoveEntry(Entry entry)
        {
            if(journal.Contains(entry))
            {
                journal.Remove(entry);
            }
            return journal;        
        }

        public void DisplayJournal()
        {
            foreach (Entry e in journal)
            {
                Console.WriteLine($"{e.Prompt} \n {e.Text} \n {e.DateTime} \n");
            }
        }
    }
}