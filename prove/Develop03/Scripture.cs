using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Data;

namespace scripturememory
{

public class Scripture
{
    public List<Word> verse;
    private int verselength;

    public void SetVerse(Word word, Scripture scripture)
    {
        verse = new();
        scripture.verse.Add(word);
    }

#pragma warning disable IDE0060
    public void getsetVerse(string[] verselist, Scripture scripture)
#pragma warning restore IDE0060
    {
        verse = new();
        foreach (string singleword in verselist)
        {
            //verse = new();
            Word word = new();
            word.recieveText(singleword);
            scripture.verse.Add(word);
            
        }
    
   
    }

   /* public List<Word> getScripture();
    {
        List<Word> verse = scripture;
        return verse;
    }*/
    public void GetVerse(Repository repository, string reff, Dictionary<string, List<Word>> boo)
    {
            verse = boo[reff];
            verselength =verse.Count;
            return;
        
    }

    public int sendVerseL()
    {
        int alpha = verselength;
        return alpha;
    }

    //public void AddScripture(Word)
    //{
    //    scripture.Add(Word);
    //}


}}