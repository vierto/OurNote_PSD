using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz_Vendly_2301858345.Repository
{
    public class OurNoteRepository
    {
        OurNoteDBEntities db = new OurNoteDBEntities();

        public List<OurNote> GetOurNotes()
        {
            return db.OurNotes.ToList();
        }

        public OurNote FindByTitle(String title)
        {
            return db.OurNotes.Where(o => o.Title == title).FirstOrDefault();
        }

        public void UpdateOurNote(OurNote ourNote, String title, int writer, String content, String code)
        {
            ourNote.Title = title;
            ourNote.Writer = writer;
            ourNote.Content = content;
            ourNote.Code = code;
            db.SaveChanges();
        }

        public void RemoveOurNote(String title)
        {
            var ourNote = FindByTitle(title);
            db.OurNotes.Remove(ourNote);
            db.SaveChanges();
        }

        public OurNote FindById(int id)
        {
            return db.OurNotes.Find(id);
        }

        public void InsertOurNote(OurNote ourNote)
        {
            db.OurNotes.Add(ourNote);
            db.SaveChanges();
        }
    }
}