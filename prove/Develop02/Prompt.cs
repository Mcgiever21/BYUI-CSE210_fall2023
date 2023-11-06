using System;
using System.Collections.Generic;

namespace JournalProgram2
{
    public class Prompt
    {

        public Prompt() { }
        
        public List<string> PromptFileGrab ()
        {
            List<string> PromptList = new List<string>();
            var PromptFile = System.IO.File.ReadAllLines("prompt.txt");
            foreach (var line in PromptFile){PromptList.Add(line);}

            return PromptList;
        }
    }
}