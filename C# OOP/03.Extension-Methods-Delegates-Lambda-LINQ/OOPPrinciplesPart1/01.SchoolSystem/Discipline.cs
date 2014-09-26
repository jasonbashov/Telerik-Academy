namespace _01.SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<string> comments = new List<string>();

        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

        public Discipline(string name, int lecturesCount, int exercisesCount)
        {
            this.Name = name;
            this.NumberOfLectures = lecturesCount;
            this.NumberOfExercises = exercisesCount;
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public void AddComment()
        {
            throw new NotImplementedException();
        }
    }
}
