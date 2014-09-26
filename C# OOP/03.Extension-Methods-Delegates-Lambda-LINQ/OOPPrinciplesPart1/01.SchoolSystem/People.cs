namespace _01.SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class People : ICommentable
    {
        private string name;

        private List<string> comments = new List<string>();

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<string> Comments 
        { 
            get { return this.comments; } 
        }

        public virtual void AddComment(string comment)
        {
            this.comments.Add(comment);
        }


        public void AddComment()
        {
            throw new NotImplementedException();
        }
    }
}
