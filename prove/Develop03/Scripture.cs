using System;
using System.IO;
using System.Collections.Generic;

namespace scripturememory
{

class Scripture
{
    public List<Word> scripture;
    public int verselength;

    public void GetVerse(Dictionary< string , List<Word> > book)
    {
        Console.WriteLine("enter the reference of the scripture in form ch:verse with no spaces:");
        string reference = Console.ReadLine();
        bool exists = book.ContainsKey(reference);
        if (exists == true)
        {
            scripture = book[reference];
            verselength =scripture.Count;
            return;
        }
        else if (exists == false)
        {
            Console.WriteLine("invalid reference");
        }
    }


}}