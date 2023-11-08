using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;

namespace scripturememory
{

public class Repository
{

    private Dictionary<string, List<Word>> book;
    private string bookfile ="";
    string reference = "";
    //string bookFile;

    public string getbookfilename(){string bookname = bookfile; return bookname; }

    public Dictionary<string, List<Word>> RetrieveBook()
    {
        Console.WriteLine("type in name of the Book to study from: ");
        bookfile = Console.ReadLine(); 
        bookfile = $"{bookfile}.txt";
        book = new();
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
                scripture.verse = new List<Word>();
                if (line == "" || line ==" "){}
                else
                {
                    string[] parts = line.Split("|");

                    string [] verselist = parts[1].Split(" ");
                    if (line == "" || line ==" "){}
                    else
                        {
                            foreach (string singleword in verselist)
                                {
                                    Word word = new Word();
                                    word.recieveText(singleword);
                                    scripture.verse.Add(word);
                                }
                        }

                    book.Add( parts[0] , scripture.verse );
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid book name, returning to main menu.");
        }
    }

    public Dictionary<string,List<Word>> AddScripture()
    {
        
        //try
        //{
            Console.WriteLine($"current book to add scriptures to is {bookfile}, to change books, please go back to main and retrieve scriptures from a different book");
        //}
        //catch(Exception e ){Console.WriteLine(e.Message); ;}

        bool checker = false;
        Scripture scripture = new();
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

        
        scripture.getsetVerse(verselist, scripture);
         
        book.Add(reference, scripture.verse);

        string path = bookfile; 
        bool exists = path.Contains(reference);
        if (exists == false)
        {
            print2file(scripture);
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
            scripture.verse = book[reference];
            Console.Write(scripture.verse);
            Console.WriteLine("Please type the verse to replace this verse entirely:");
                        string line = Console.ReadLine();
            string[] verselist = line.Split(" ");
            foreach (string singleword in verselist)
            {
                Word word = new Word();
                word.recieveText(singleword);
                scripture.verse.Add(word);
            }
            book[reference] = scripture.verse;
            FileRetriever();
            print2file(scripture);
        }

        else 
        {
            Console.WriteLine("invalid reference, please add instead");
        }

    }

    public void NewBook()
    {
        book = new Dictionary<string, List<Word>>();
        Word word = new();
        Scripture scripture = new();
        word.recieveText("newbookopened");
        
        scripture.SetVerse(word, scripture);
        
        Console.WriteLine("enter name of book: ");
        reference = "1:0";
        bookfile = Console.ReadLine();  
        bookfile = $"{bookfile}.txt"; 
        print2file(scripture);
         
    }

    public Repository(){}

    private void print2file(Scripture scripture)
    {

               
        using (StreamWriter outputFile = new StreamWriter(bookfile))
        {
            Word word = new();
            //Scripture scripture = new Scripture();
            //string path = $"C:\\Users\\matt-\\Documents\\CSE210\\prove\\Develop03\\Library\\{bookfile}.txt"; 
            //scripture.verse = book[reference];
            string script = "";
            int b = 0;
            foreach ( Word i in scripture.verse)
            {
                word = scripture.verse[b];
                script+=($" {word.sendText()} ");
                b++;
            }
            outputFile.Write($"\n{reference}|{script}");
        }
    }

    public Dictionary<string, List<Word>> SendDict()
    {
        Dictionary<string, List<Word>> Aa = book;
        return Aa;
    }
    public void RecieveDict(Dictionary<string, List<Word>> Bb)
    {
        book = Bb;
        return ;
    }

   /* public string ExceptionInput( string i)
    {
        if (i == ""){throw new ArgumentException( string.Format("book not loaded, please load a book through the menu."));}
        else{return " ";}
    }*/
}}