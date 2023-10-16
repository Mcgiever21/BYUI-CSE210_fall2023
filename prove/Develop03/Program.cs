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
        do
        {
        Console.WriteLine("enter 1 for load a book, 2 for record a scripture, 3 for edit a scripture, 4 for memorize a scripture, 5 for a new book, type quit to leave");
        string menu_select = Console.ReadLine();
        Repository repository = new Repository();
        if (menu_select == "1"){
            
            repository.RetrieveBook();
        }
        else if (menu_select == "2"){
            if(repository.bookfile== ""){
                Console.WriteLine("book is not selected, please select load book in menu");
                Main(args);
            }
            repository.AddScripture();
            
        }
        else if (menu_select == "3"){ 
            
            repository.EditScripture();
        }
        else if (menu_select == "5"){
            repository.NewBook();
        }
        else if (menu_select == "4"){
            int checker = 1;
            Word word = new Word();
            Scripture scripture = new Scripture();
            int boolchecker=0;
            do
            {
                scripture.GetVerse(repository.book);
                if (scripture.verselength <= 1) {checker = 0;}
            } while( checker == 1);
            Console.Write($"\n{scripture.scripture}");
            List<Word> versememory = scripture.scripture;
            do
            {
                scripture.scripture = word.HideWord(scripture.scripture);
                foreach (Word text in scripture.scripture)
                {
                    boolchecker = 0;
                    if (text._visible == false){ boolchecker += 1;}
                    Console.Write($"\n{scripture.scripture}");
                }
                entry = Console.ReadLine();
                if (entry == "quit")
                {
                    boolchecker = scripture.verselength;
                }
            } while (boolchecker != scripture.verselength);
        scripture.scripture = versememory;
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