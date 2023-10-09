using System;
using System.Collections.Generic;

class MathAss : Assignment
{
    public string _textbookSection = "Textbook section";
    public string _problems = "Promblem list";


    public void setMathAssVar()
    {
        ConsoleGetter con = new ConsoleGetter();
        _textbookSection = con.Getter(_textbookSection);
        _problems = con.Getter(_problems);

    }

}