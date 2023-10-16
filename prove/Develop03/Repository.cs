using System;
using System.IO;
using System.Collections.Generic;

namespace scripturememory
{

class Repository
{

    public Dictionary<string, List<Word>> book;
    public string bookfile ="";
    string reference = "";
    //string bookFile;

    public Dictionary<string, List<Word>> RetrieveBook()
    {
        Console.WriteLine("type in name of the Book to study from: ");
        bookfile = Console.ReadLine(); 
        bookfile = $"{bookfile}.txt";
        book = new Dictionary<string, List<Word>>();
        FileRetriever();
        return book;
    }

    private void FileRetriever()
    {
        //string path = $"C:\\Users\\matt-\\Documents\\CSE210\\prove\\Develop03\\Library\\{bookfile}";
        if(File.Exists(bookfile))
        {
            string[] lines = System.IO.File.ReadAllLines(bookfile);
            //Journal journal = new Journal();

            foreach (string line in lines)
            {
                Scripture scripture = new Scripture();
                string[] parts = line.Split("|");

                string [] verselist = parts[1].Split(" ");
                foreach (string singleword in verselist)
                {
                    Word word = new Word();
                    word._text = singleword;
                    scripture.scripture.Add(word);
                }

                book.Add( parts[0] , scripture.scripture );
            }
        }
        else
        {
            Console.WriteLine("Invalid book name, returning to main menu.");
        }
    }

    public Dictionary<string,List<Word>> AddScripture()
    {
        Scripture scripture = new Scripture();
        //try
        //{
            Console.WriteLine($"current book to add scriptures to is {bookfile}, to change books, please go back to main and retrieve scriptures from a different book");
        //}
        //catch(Exception e ){Console.WriteLine(e.Message); ;}

        bool checker = false;
        
        do 
        {
            Console.WriteLine("enter the scripture reference in format ch:vs' with no spaces: ");
            reference = Console.ReadLine();
            bool WhiteSpaceChecker = reference.Contains(" ");
            if (WhiteSpaceChecker == true)
            {
                Console.WriteLine("Invalid reference, contained a space or error. retry");
                
            }
            else{ checker = true;}
        } while(checker == false);

        Console.WriteLine("enter the scripture corresponding the above entered reference: ");
        string line = Console.ReadLine();
        string[] verselist = line.Split(" ");
        foreach (string singleword in verselist)
        {
            Word word = new Word();
            word._text = singleword;
            scripture.scripture.Add(word);
        }
        book.Add(reference, scripture.scripture);

        string path = bookfile; 
        bool exists = path.Contains(reference);
        if (exists == false)
        {
            print2file();
        }
        else
        {
            Console.WriteLine("scripture is already recorded. returning to main");
            return book;
        }
        return book;
        
    }

    public void EditScripture()
    {
        Console.WriteLine("enter reference of scripture to edit in format ch:verse with no spaces:");
        string reference = Console.ReadLine();
        bool exists = book.ContainsKey(reference);
        if (exists == true)
        {
            Scripture scripture = new Scripture();
            scripture.scripture = book[reference];
            Console.Write(scripture.scripture);
            Console.WriteLine("Please type the verse to replace this verse entirely:");
                        string line = Console.ReadLine();
            string[] verselist = line.Split(" ");
            foreach (string singleword in verselist)
            {
                Word word = new Word();
                word._text = singleword;
                scripture.scripture.Add(word);
            }
            book[reference] = scripture.scripture;
            FileRetriever();
            print2file();
        }

        else 
        {
            Console.WriteLine("invalid reference, please add instead");
        }

    }

    public void NewBook()
    {
        book = new Dictionary<string, List<Word>>();
        Word word = new Word();
        Scripture scripture = new Scripture();
        word._text = "newbookopened";
        scripture.scripture.Add(word);
        
        Console.WriteLine("enter name of book: ");
        bookfile = Console.ReadLine();
        bookfile = $"{bookfile}.txt";   
        reference = "1:100";
        print2file();
         
    }

    public Repository(){}

    private void print2file()
    {
        using (StreamWriter outputFile = new StreamWriter(bookfile))
        {
        Scripture scripture = new Scripture();
        //string path = $"C:\\Users\\matt-\\Documents\\CSE210\\prove\\Develop03\\Library\\{bookfile}txt"; 
        scripture.scripture = book[reference];
        string script = "";
        foreach (Word word in scripture.scripture)
        {
            script.Insert(script.Length,$"{word._text} ");
        }
        outputFile.Write($"\n{reference}|{script}");
        }
    }

   /* public string ExceptionInput( string i)
    {
        if (i == ""){throw new ArgumentException( string.Format("book not loaded, please load a book through the menu."));}
        else{return " ";}
    }*/
}}