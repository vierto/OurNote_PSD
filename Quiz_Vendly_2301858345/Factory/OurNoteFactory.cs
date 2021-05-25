using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz_Vendly_2301858345.Factory
{
    public class OurNoteFactory
    {
        public static OurNote GetOurNote(String title, int writer, String content, String code)
        {
            OurNote ourNote = new OurNote();
            ourNote.Title = title;
            ourNote.Writer = writer;
            ourNote.Content = content;
            ourNote.Code = code;
            return ourNote;
        }
    }
}