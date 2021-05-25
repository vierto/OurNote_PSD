using Quiz_Vendly_2301858345.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Vendly_2301858345.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        OurNoteRepository ourNoteRepositories = new OurNoteRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPage.aspx");
        }

        protected void OurNoteGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var row = OurNoteGV.Rows[e.RowIndex];
            String title = row.Cells[0].Text;
            ourNoteRepositories.RemoveOurNote(title);
            InitializeData();
        }

        protected void OurNoteGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var row = OurNoteGV.Rows[e.NewEditIndex];
            String title = row.Cells[0].Text;

            OurNoteRepository noteRepo = new OurNoteRepository();

            var note = noteRepo.FindByTitle(title);
            
            Response.Redirect("UpdatePage.aspx?id=" + note.NoteID);
        }

        protected void InitializeData()
        {
            List<OurNote> ourNotes = ourNoteRepositories.GetOurNotes();
            OurNoteGV.DataSource = ourNotes;
            OurNoteGV.DataBind();
        }
    }
}