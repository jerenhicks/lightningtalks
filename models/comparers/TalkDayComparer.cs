using System;
using System.Collections;

class TalkDayComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return(new CaseInsensitiveComparer()).Compare(((TalkDay)x).startDateTime,
               ((TalkDay)y).startDateTime);
    }
}