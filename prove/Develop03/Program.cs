using System;
using System.Collections.Generic;
namespace scripturememory
{

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        
        
        Console.WriteLine("Let's memorize some scriptures");
        string entry = "";
        Repository repository = new Repository();
        Scripture scripture = new();
        do
        {
        Console.WriteLine("enter 1 for load a book, 2 for record a scripture, 4 for memorize a scripture, 5 for a new book, type quit to leave");
        string menu_select = Console.ReadLine();
        
        if (menu_select == "1"){
            
            repository.RetrieveBook();
        }
        else if (menu_select == "2"){
            if(repository.getbookfilename()== ""){
                Console.WriteLine("book is not selected, please select load book in menu");
                Main(args);
            }
            repository.AddScripture();
            
        }
        /*else if (menu_select == "3"){ 
            
            repository.EditScripture();
        }*/
        else if (menu_select == "5"){
            repository.NewBook();
        }
        else if (menu_select == "4"){
            int checker = 1;
            Word word = new Word();
            //Scripture scripture = new();
            int boolchecker=0;
            Console.WriteLine("enter the reference of the scripture in form ch:verse with no spaces:");
            string reff = Console.ReadLine();
            List<Word> versememory;
            Dictionary<string, List<Word>> boo = repository.SendDict();
            bool exists = boo.ContainsKey(reff);
            if (exists == true)
            {
                //do
                //{
                scripture.GetVerse(repository, reff, boo);
                if (scripture.sendVerseL() <= 1) {return;}
                //} while( checker == 1);
                string script = "";
                List<string> here = new();
                int b = 0;
                foreach ( Word i in scripture.verse)
                    {
                        word = scripture.verse[b];
                        script+=($" {word.sendText()} ");
                        here.Add(word.sendText());
                        b++;
                    }
                Console.Write($"\n{script}");
               versememory = scripture.verse;
                do
                {
                    //Console.Write("\b \b");
                    scripture.verse = word.HideWord(scripture.verse);
                    foreach (Word text in scripture.verse)
                    {
                        boolchecker = 0;
                        if (text._visible == false){ boolchecker += 1;}
                    }
                    b = 0;
                    script = "";
                    foreach ( Word i in scripture.verse)
                        {
                            word = scripture.verse[b];
                            script+=($" {word.sendText()} ");
                            b++;
                        };
                    Console.WriteLine($"\b\b\n\n\n\n\n{script}");
                    entry = Console.ReadLine();
                    if (entry == "quit")
                    {
                        boolchecker = scripture.sendVerseL();
                        Program.Main(args);
                    }
                } while (boolchecker != scripture.sendVerseL());
                scripture.verse = versememory;
            }
            else if (exists == false)
            {
                Console.WriteLine("invalid reference");

            }
            
        }
        else if (menu_select == "quit"){entry = "quit";}
        } while (entry != "quit");
    }
    /*public string ExceptionInput( string i)
    {
        if (i == ""){throw new ArgumentException( string.Format("book not loaded, please load a book through the menu."));}
        else{return " ";}
    }*/
}}