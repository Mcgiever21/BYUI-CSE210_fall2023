using System;
using System.IO;
using System.Collections.Generic;

namespace scripturememory
{
public class Word
{
    public bool _visible = true;
    private string _text = "";
    //private string _textHide = "";


    //public Word(){ Word word = new Word();}


    public List<Word> HideWord(List<Word> verse)
    {
        int length =verse.Count;
        Random rand = new Random();
        int spacing = length/4;
        for (int i = 0 ; i < spacing ; i++)
        {
            int number = rand.Next(length);
            
            if (verse[number]._visible == true)
            {
                verse[number]._visible = false;
                verse[number]._text = " ____ ";
            }
        }
        return verse;
    }
    public string sendText()
    {
        string w = _text;
        return w;
    }
     public void recieveText(string w)
    {
        _text = w;
    }

}}