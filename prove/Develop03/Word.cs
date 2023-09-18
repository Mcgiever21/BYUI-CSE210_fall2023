using System;
using System.IO;
using System.Collections.Generic;

namespace scripturememory
{
public class Word
{
    public bool _visible = true;
    public string _text = "";


    public Word(){ Word word = new Word();}


    public List<Word> HideWord(List<Word> scripture)
    {
        int length =scripture.Count;
        Random rand = new Random();
        int spacing = length/4;
        for (int i = 0 ; i < spacing ; i++)
        {
            int number = rand.Next(length);
            
            if (scripture[number]._visible == true)
            {
                scripture[number]._visible = false;
                scripture[number]._text = "____";
            }
        }
        return scripture;
    }
}}