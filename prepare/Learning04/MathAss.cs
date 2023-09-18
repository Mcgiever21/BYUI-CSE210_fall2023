using System;
using System.Collections.Generic;

class MathAss : Assignment
{
    private string _textbookSection;
    private string _problems;


    private void setMathAssVar()
    {
        _textbookSection = SetVar(_textbookSection);
        _problems = SetVar(_problems);

    }
    public string GetHomeworkList()
    {
        setMathAssVar();
        return ($"{_textbookSection} - {_problems}");
    }


}