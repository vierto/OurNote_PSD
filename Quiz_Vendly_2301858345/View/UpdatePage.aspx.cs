using Quiz_Vendly_2301858345.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Vendly_2301858345.View
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        OurNoteRepository ourNoteRepositories = new OurNoteRepository();
        OurNote ourNote = null;
        int id = 0; 

        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            ourNote = ourNoteRepositories.FindById(id);
            if (ourNote == null) Response.Redirect("HomePage.aspx");

            if(!IsPostBack)
            {
                InitializedData(ourNote);
            }
        }

        protected void InitializedData(OurNote ourNote)
        {
            titleTxt.Text = ourNote.Title;
            writerTxt.Text = ourNote.Writer.ToString();
            contentTxt.Text = ourNote.Content;
            codeTxt.Text = ourNote.Code;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            String title = titleTxt.Text;
            int writer = int.Parse(writerTxt.Text);
            String content = contentTxt.Text;
            String code = codeTxt.Text;

            if (!CheckTitle(title)) return;

            if (writer == 0)
            {
                errorLbl.Text = "Writer Must Be Filled";
                return;
            }

            if (!CheckContent(content)) return;

            if (code == null)
            {
                errorLbl.Text = "Code Must Be Filled";
                return;
            }

            ourNoteRepositories.UpdateOurNote(ourNote, title, writer, content, code);
            Response.Redirect("HomePage.aspx");
        }

        protected bool CheckTitle(String title)
        {
            var ourNote = ourNoteRepositories.FindByTitle(title);

            if (title == null)
            {
                errorLbl.Text = "Title Must Be Filled";
                return false;
            }

            if (ourNote != null)
            {
                errorLbl.Text = "Title Must Be Unique";
                return false;
            }

            return true;
        }

        protected bool CheckContent(String content)
        {
            if (content == null)
            {
                errorLbl.Text = "Content Must Be Filled";
                return false;
            }

            if (content.Length > 100)
            {
                errorLbl.Text = "Maximum Content is 100 characters";
                return false;
            }

            return true;
        }
    }
}