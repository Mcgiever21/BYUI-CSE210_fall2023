using System;
using System.Collections.Generic;

class WritingAss : Assignment
{
    public string _title = "Title";


    public void setwritAssVar()
    {
        ConsoleGetter con = new ConsoleGetter();
        _title = con.Getter(_title);

    }

}