using System;
using System.Collections.Generic;

class WritingAss : Assignment
{
    private string _title;


    private void setwritAssVar()
    {
        _title = SetVar(_title);

    }
    public string GetBookList()
    {
        setwritAssVar();
        return _title;
    }

}